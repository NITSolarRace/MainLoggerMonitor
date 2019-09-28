using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartLoggerMonitorApp
{
    public partial class Form_Main : Form
    {   
        // シリアル通信設定フォーム
        private Form_SerialSettings form_SerialSettings = new Form_SerialSettings();
        // グラフ設定フォーム
        private Form_ChartSettings form_ChartSettings = new Form_ChartSettings();

        private string global_chartAreaName = "Area1";
        private int[] global_mainChartAry_y;
        private int[] global_mainChartAry_y2;
        private string[] global_mainChartLegend;
        private string global_solarChartLegend = "ソーラ電力";
        private string global_subChartLegend = "モータ電力";
        private string global_subChartLegend_2 = "速度";
        private string global_resChartLegend = "モータ電力";
        private string global_resChartLegendTheory = "理論値";

        private const int SORT_SPEED_NUM = 121;  // 0-120km/hまで
        private int[] global_averageCount = new int[SORT_SPEED_NUM];
        private double[] global_sumMotorPowerData = new double[SORT_SPEED_NUM];
        private double[] global_averageMotorPowerData = new double[SORT_SPEED_NUM];
        private double global_preSpeed = 0;  // 前の速度
        private int global_serialCount = 0;


        public Form_Main()
        {
            InitializeComponent();

        }

        // Mainフォーム起動時
        private void Form_Main_Load(object sender, EventArgs e)
        {
            // Properties.Settings.Default.Reset();

            // シリアル通信設定フォームを立ち上げる
            form_SerialSettings.ShowDialog(this);

            // データグリッドビューの設定
            DataGridViewMainSetting();
            // DataGridViewSolarSetting();

            // グラフ設定
            ChartSettings();

            // 指定のシリアルポートオープン
            SerialPortOpen();
        }

        // 設定>シリアル通信&データ設定をクリックしたとき
        private void SerialSetteingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // シリアルポートを閉じる
            SerialPortClose();

            // シリアル通信設定フォームを立ち上げる
            form_SerialSettings.ShowDialog(this);

            // メインデータグリッドビューの設定
            DataGridViewMainSetting();

            // 指定のシリアルポート立ち上げる
            SerialPortOpen();

        }

        // 設定>グラフ設定をクリックしたとき
        private void ChartSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // シリアルポートを閉じる
            SerialPortClose();

            // グラフ設定フォームを立ち上げる
            form_ChartSettings.ShowDialog(this);

            // グラフ設定
            ChartSettings();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // シリアルポートを閉じる
            SerialPortClose();
        }

        // シリアル通信受信イベントハンドラ（改行コードまで受信されたごとに実行）
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {   
            // シリアルポートが開いていない場合、終了
            if (!serialPort1.IsOpen)
            {
                return;
            }

            string[] serialDataAry = null;   // シリアル通信データ格納用

            try
            {
                // 1行受信後、カンマごとに分割し配列に格納
                serialDataAry = serialPort1.ReadLine().Split(',');
            }
            catch (Exception)
            {
                MessageBox.Show("シリアル通信エラー", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SerialPortClose();
                return;

            }

            // 配列要素数と送信データの要素数が一致した場合
            if(serialDataAry.Length == Properties.Settings.Default.serialDataNum) {
                BeginInvoke((MethodInvoker)delegate
                {   
                    // dataGridViewMainに1行を上からそのまま挿入
                    dataGridViewMain.Rows.Insert(0, serialDataAry);
                    
                    /*
                    // dataGridViewSolarLeftにMPPT発電量を表示
                    double solarLeftSum = 0;
                    for(int i = 0; i < 5; i++)
                    {
                        dataGridViewSolarLeft.Rows[i].Cells[1].Value = serialDataAry[i + 17];
                        // 発電量の合計
                        if(double.TryParse(serialDataAry[i + 17], out double data))
                        {
                            solarLeftSum += data;
                        }
                    }
                    dataGridViewSolarLeft.Rows[6].Cells[1].Value = solarLeftSum;

                    // dataGridViewSolarLeftにMPPT発電量を表示
                    double solarRightSum = 0;
                    for(int i = 0; i < 6; i++)
                    {
                        dataGridViewSolarRight.Rows[i].Cells[1].Value = serialDataAry[i + 22];
                        if(double.TryParse(serialDataAry[i + 22], out double data))
                        {
                            solarRightSum += data;
                        }
                    }
                    dataGridViewSolarRight.Rows[6].Cells[1].Value = solarRightSum;

                    // dataGridViewTempにアレイ温度データを表示
                    for(int i = 0; i < 8; i++)
                    {
                        dataGridViewTempLeft.Rows[i].Cells[1].Value = serialDataAry[i + 28];
                        dataGridViewTempRight.Rows[i].Cells[1].Value = serialDataAry[i + 36];
                    }
                    */

                    // グラフ表示
                    global_serialCount++;
                    // グラフ表示間隔の間引き
                    int mainChart_x = Properties.Settings.Default.chartSettings_x;  // mainChartの横軸の配列要素番号
                    if (global_serialCount >= Properties.Settings.Default.serialCountNum)
                    {
                        global_serialCount = 0;

                        // mainChart表示
                        // グラフ設定で設定された項目を表示していく
                        for (int i = 0; i < global_mainChartAry_y.Length; i++)
                        {
                            if (double.TryParse(serialDataAry[mainChart_x], out double x) && double.TryParse(serialDataAry[global_mainChartAry_y[i]], out double y))
                            {
                                // データをレンダリング
                                mainChart.Series[global_mainChartLegend[i]].Points.AddXY(x, y);
                            }
                        }
                        for (int i = global_mainChartAry_y.Length; i < global_mainChartLegend.Length; i++)
                        {
                            if (double.TryParse(serialDataAry[mainChart_x], out double x2) && double.TryParse(serialDataAry[global_mainChartAry_y2[i - global_mainChartAry_y.Length]], out double y2))
                            {
                                mainChart.Series[global_mainChartLegend[i]].Points.AddXY(x2, y2);
                            }
                        }

                        // solarChart表示
                        int solarChart_y = Properties.Settings.Default.solarPowerNum;  // ソーラー電力
                        if (double.TryParse(serialDataAry[mainChart_x], out double xSolar) && double.TryParse(serialDataAry[solarChart_y], out double ySolar))
                        {
                            solarChart.Series[global_solarChartLegend].Points.AddXY(xSolar, ySolar);
                        }
                    }


                    // subChart表示
                    int subChart_y = Properties.Settings.Default.motorPowerNum;
                    int subChart_y2 = Properties.Settings.Default.speedNum;
                    if (double.TryParse(serialDataAry[mainChart_x], out double xSub) && double.TryParse(serialDataAry[subChart_y], out double ySub))
                    {
                        subChart.Series[global_subChartLegend].Points.AddXY(xSub, ySub);
                    }
                    if (double.TryParse(serialDataAry[mainChart_x], out double xSub2) && double.TryParse(serialDataAry[subChart_y2], out double ySub2))
                    {
                        subChart.Series[global_subChartLegend_2].Points.AddXY(xSub2, ySub2);
                    }
                    subChart.ChartAreas[global_chartAreaName].AxisX.ScaleView.Position = xSub;
                    subChart.ChartAreas[global_chartAreaName].AxisX.Minimum = xSub - 120;


                    // resChart用データ解析
                    int motorPowerNum = Properties.Settings.Default.motorPowerNum;  // モータ電力の配列要素番号
                    int speedNum = Properties.Settings.Default.speedNum;  // 速度の配列要素番号

                    // 加速抵抗補正プログラム
                    // 文字列がdouble型に変換可能な場合
                    if(double.TryParse(serialDataAry[motorPowerNum], out  double motorPower) && double.TryParse(serialDataAry[speedNum], out double speed))
                    {
                        double accel_ms = (speed - global_preSpeed) / 3.6;  // km/h/s→m/s^2

                        // 今回の速度を前回の速度として格納
                        global_preSpeed = speed;

                        double speed_ms = speed / 3.6;
                        double weight = Properties.Settings.Default.carWeight;    // 総重量
                        double eff = Properties.Settings.Default.motorEff / 100;  // 効率
                        double accelPower = weight * accel_ms * speed_ms / eff;   // バッテリーサイドの加速抵抗を計算

                        if(accelPower > 0)
                        {
                            int arySortNum = (int)Math.Round(speed);  // 速度を整数に丸める（直接配列要素数になるようにしている）
                            if (arySortNum >= 0)
                            {
                                global_averageCount[arySortNum]++;  // 平均回数
                                global_sumMotorPowerData[arySortNum] += (motorPower - accelPower);  // 加速抵抗を差し引きモータ電力を合計

                                // 加速抵抗補正された平均モータ電力（合計/平均回数）
                                global_averageMotorPowerData[arySortNum] = global_sumMotorPowerData[arySortNum] / global_averageCount[arySortNum]; 
                            }
                        }
                    }

                    // resChart
                    resChart.Series[global_resChartLegend].Points.Clear();
                    for(int i = 0; i < SORT_SPEED_NUM; i++)
                    {
                        resChart.Series[global_resChartLegend].Points.AddXY(i, global_averageMotorPowerData[i]);
                    }
                });
            }
        }


        // シリアルポート設定を反映する
        private void SerialPortSetting()
        {
            this.serialPort1.PortName = Properties.Settings.Default.serialComName;
            this.serialPort1.BaudRate = int.Parse(Properties.Settings.Default.serialSpeedRate);
            switch (Properties.Settings.Default.serialParity)
            {
                case "none":
                    this.serialPort1.Parity = Parity.None;
                    break;
                case "odd":
                    this.serialPort1.Parity = Parity.Odd;
                    break;
                case "even":
                    this.serialPort1.Parity = Parity.Even;
                    break;
                case "mark":
                    this.serialPort1.Parity = Parity.Mark;
                    break;
                case "space":
                    this.serialPort1.Parity = Parity.Space;
                    break;
                default:
                    this.serialPort1.Parity = Parity.None;
                    break;
            }
            switch (Properties.Settings.Default.serialDataBits)
            {
                case "8 bits":
                    this.serialPort1.DataBits = 8;
                    break;
                case "7 bits":
                    this.serialPort1.DataBits = 7;
                    break;
                default:
                    this.serialPort1.DataBits = 8;
                    break;
            }
            switch (Properties.Settings.Default.serialStopBits)
            {
                case "1 bit":
                    this.serialPort1.StopBits = StopBits.One;
                    break;
                default:
                    this.serialPort1.StopBits = StopBits.One;
                    break;
            }
            switch (Properties.Settings.Default.serialFlow)
            {
                case "none":
                    this.serialPort1.Handshake = Handshake.None;
                    break;
                default:
                    this.serialPort1.Handshake = Handshake.None;
                    break;
            }
            switch (Properties.Settings.Default.serialEncode)
            {
                case "UTF-8":
                    this.serialPort1.Encoding = Encoding.UTF8;
                    break;
                default:
                    this.serialPort1.Encoding = Encoding.UTF8;
                    break;
            }
            switch (Properties.Settings.Default.serialEnterCode)
            {
                case "CRLF":
                    this.serialPort1.NewLine = "\r\n";
                    break;
                case "CR":
                    this.serialPort1.NewLine = "\r";
                    break;
                case "LF":
                    this.serialPort1.NewLine = "\n";
                    break;
                default:
                    this.serialPort1.NewLine = "\r\n";
                    break;
            }
        }

        // フォームで設定された項目を反映する
        private void DataGridViewMainSetting()
        {
            dataGridViewMain.ColumnCount = Properties.Settings.Default.serialDataNum;

            string[] dataAryColName = Properties.Settings.Default.dataAryColName.Split(',');
            string[] dataAryColShow = Properties.Settings.Default.dataAryColShow.Split(',');
            
            for(int i = 0; i < Properties.Settings.Default.serialDataNum; i++)
            {
                dataGridViewMain.Columns[i].HeaderText = dataAryColName[i];
                dataGridViewMain.Columns[i].Width = 80;
                if(dataAryColShow[i] == "False")
                {
                    dataGridViewMain.Columns[i].Visible = false;
                }
                else if(dataAryColShow[i] == "True")
                {
                    dataGridViewMain.Columns[i].Visible = true;
                }

            }
        }

        /*
        // データグリッドビューの設定を反映する
        private void DataGridViewSolarSetting()
        {
            dataGridViewSolarLeft.ColumnCount = 2;
            dataGridViewSolarLeft.RowCount = 7;
            dataGridViewSolarRight.ColumnCount = 2;
            dataGridViewSolarRight.RowCount = 7;

            dataGridViewSolarLeft.Columns[1].HeaderText = "発電量[W]";
            dataGridViewSolarRight.Columns[1].HeaderText = "発電量[W]";

            dataGridViewSolarLeft.Columns[0].Width = 45;
            dataGridViewSolarRight.Columns[0].Width = 45;
            
            dataGridViewSolarLeft.RowHeadersVisible = false;
            dataGridViewSolarRight.RowHeadersVisible = false;

            string[] solarLeftRowHeader = { "1-1", "1-2", "1-3", "1-4", "1-5", "", "合計" };
            string[] solarRightRowHeader = { "2-1", "2-2", "2-3", "2-4", "2-5", "2-6", "合計" };

            for(int i = 0; i < 7; i++)
            {
                dataGridViewSolarLeft.Rows[i].Cells[0].Value = solarLeftRowHeader[i];
                dataGridViewSolarRight.Rows[i].Cells[0].Value = solarRightRowHeader[i];

                dataGridViewSolarLeft.Rows[i].Height = 33;
                dataGridViewSolarRight.Rows[i].Height = 33;
            }

            dataGridViewTempLeft.ColumnCount = 2;
            dataGridViewTempLeft.RowCount = 8;
            dataGridViewTempRight.ColumnCount = 2;
            dataGridViewTempRight.RowCount = 8;

            dataGridViewTempLeft.Columns[1].HeaderText = "温度[℃]";
            dataGridViewTempRight.Columns[1].HeaderText = "温度[℃]";

            dataGridViewTempLeft.RowHeadersVisible = false;
            dataGridViewTempRight.RowHeadersVisible = false;

            dataGridViewTempLeft.Columns[0].Width = 45;
            dataGridViewTempRight.Columns[0].Width = 50;

            for(int i = 0; i < 8; i++)
            {
                dataGridViewTempLeft.Rows[i].Cells[0].Value = i + 1;
                dataGridViewTempRight.Rows[i].Cells[0].Value = i + 1;

                dataGridViewTempLeft.Rows[i].Height = 32;
                dataGridViewTempRight.Rows[i].Height = 32;

            } 
        }
        */

        private void SerialPortOpen()
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    SerialPortSetting();
                    serialPort1.Open();
                }
                else
                {
                    MessageBox.Show(Properties.Settings.Default.serialComName + "はすでに開かれています", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "不明なエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerialPortClose()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        // グラフ設定
        private void ChartSettings()
        {
            mainChart.Series.Clear();
            mainChart.ChartAreas.Clear();
            solarChart.Series.Clear();
            solarChart.ChartAreas.Clear();
            subChart.Series.Clear();
            subChart.ChartAreas.Clear();
            resChart.Series.Clear();
            resChart.ChartAreas.Clear();

            mainChart.ChartAreas.Add(new ChartArea(global_chartAreaName));
            solarChart.ChartAreas.Add(new ChartArea(global_chartAreaName));
            subChart.ChartAreas.Add(new ChartArea(global_chartAreaName));
            resChart.ChartAreas.Add(new ChartArea(global_chartAreaName));

            // mainChartの設定
            int[] mainChartAry_y = StringAryToIntAry(Properties.Settings.Default.chartSettings_y.Split(','));
            int[] mainChartAry_y2 = StringAryToIntAry(Properties.Settings.Default.chartSettings_y2.Split(','));

            global_mainChartAry_y = mainChartAry_y;
            global_mainChartAry_y2 = mainChartAry_y2;

            // legend 1軸・2軸の設定
            string[] dataAryColName = Properties.Settings.Default.dataAryColName.Split(',');
            int mainChartLegendNum = mainChartAry_y.Length + mainChartAry_y2.Length;
            int[] mainChartAryConcat = new int[mainChartLegendNum];
            mainChartAry_y.CopyTo(mainChartAryConcat, 0);
            mainChartAry_y2.CopyTo(mainChartAryConcat, mainChartAry_y.Length);
            string[] mainChartLegendAry = new string[mainChartLegendNum];
            for(int i = 0; i < mainChartLegendNum; i++)
            {
                mainChartLegendAry[i] = dataAryColName[mainChartAryConcat[i]];

                try
                {
                    mainChart.Series.Add(mainChartLegendAry[i]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "グラフ表示エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                mainChart.Series[mainChartLegendAry[i]].ChartType = SeriesChartType.Spline;
                for(int j = 0; j < mainChartAry_y.Length; j++)
                {
                    if(mainChartLegendAry[i] == dataAryColName[mainChartAry_y[j]])
                    {
                        mainChart.Series[mainChartLegendAry[i]].YAxisType = AxisType.Primary;
                    }
                }
                for(int j = 0; j < mainChartAry_y2.Length; j++)
                {
                    if(mainChartLegendAry[i] == dataAryColName[mainChartAry_y2[j]])
                    {
                        mainChart.Series[mainChartLegendAry[i]].YAxisType = AxisType.Secondary;
                    }
                }
            }

            global_mainChartLegend = mainChartLegendAry;

            mainChart.ChartAreas[global_chartAreaName].AxisX.Minimum = Properties.Settings.Default.xmin;
            mainChart.ChartAreas[global_chartAreaName].AxisX.Maximum = Properties.Settings.Default.xmax;
            mainChart.ChartAreas[global_chartAreaName].AxisY.Minimum = Properties.Settings.Default.ymin;
            mainChart.ChartAreas[global_chartAreaName].AxisY.Maximum = Properties.Settings.Default.ymax;
            mainChart.ChartAreas[global_chartAreaName].AxisY2.Minimum = Properties.Settings.Default.y2min;
            mainChart.ChartAreas[global_chartAreaName].AxisY2.Maximum = Properties.Settings.Default.y2max;
            mainChart.ChartAreas[global_chartAreaName].AxisX.Interval = Properties.Settings.Default.xThickness;
            mainChart.ChartAreas[global_chartAreaName].AxisY.Interval = Properties.Settings.Default.yThickness;
            mainChart.ChartAreas[global_chartAreaName].AxisY2.Interval = Properties.Settings.Default.y2Thickness;
            mainChart.ChartAreas[global_chartAreaName].AxisX.MajorGrid.LineColor = Color.Silver;
            mainChart.ChartAreas[global_chartAreaName].AxisY.MajorGrid.LineColor = Color.Silver;
            mainChart.ChartAreas[global_chartAreaName].AxisX2.MajorGrid.LineColor = Color.Silver;
            mainChart.ChartAreas[global_chartAreaName].AxisY2.MajorGrid.LineColor = Color.Silver;


            // solarChart設定（発電確認用グラフ）
            solarChart.Series.Add(global_solarChartLegend);
            solarChart.Series[global_solarChartLegend].ChartType = SeriesChartType.Spline;
            solarChart.Series[global_solarChartLegend].Color = Color.DeepSkyBlue;
            solarChart.ChartAreas[global_chartAreaName].AxisX.Minimum = Properties.Settings.Default.xmin;
            solarChart.ChartAreas[global_chartAreaName].AxisX.Maximum = Properties.Settings.Default.xmax;
            solarChart.ChartAreas[global_chartAreaName].AxisY.Minimum = 0;
            solarChart.ChartAreas[global_chartAreaName].AxisY.Maximum = 1200;
            solarChart.ChartAreas[global_chartAreaName].AxisX.Interval = 3600;
            solarChart.ChartAreas[global_chartAreaName].AxisY.Interval = 200;
            solarChart.ChartAreas[global_chartAreaName].AxisX.MajorGrid.LineColor = Color.Silver;
            solarChart.ChartAreas[global_chartAreaName].AxisY.MajorGrid.LineColor = Color.Silver;
            

            // subChart設定（速度、モータ電力　詳細グラフ）
            subChart.Series.Add(global_subChartLegend);
            subChart.Series.Add(global_subChartLegend_2);
            subChart.Series[global_subChartLegend_2].YAxisType = AxisType.Secondary;
            subChart.Series[global_subChartLegend].ChartType = SeriesChartType.Spline;
            subChart.Series[global_subChartLegend].Color = Color.Red;
            subChart.Series[global_subChartLegend_2].ChartType = SeriesChartType.Spline;
            subChart.Series[global_subChartLegend_2].Color = Color.Black;
            subChart.ChartAreas[global_chartAreaName].AxisY.Minimum = 0;
            subChart.ChartAreas[global_chartAreaName].AxisY.Maximum = 3000;
            subChart.ChartAreas[global_chartAreaName].AxisY2.Minimum = 0;
            subChart.ChartAreas[global_chartAreaName].AxisY2.Maximum = 120;
            subChart.ChartAreas[global_chartAreaName].AxisX.Interval = 10;
            subChart.ChartAreas[global_chartAreaName].AxisY.Interval = 500;
            subChart.ChartAreas[global_chartAreaName].AxisY2.Interval = 10;
            subChart.ChartAreas[global_chartAreaName].AxisX.MajorGrid.LineColor = Color.Silver;
            subChart.ChartAreas[global_chartAreaName].AxisY.MajorGrid.LineColor = Color.Silver;
            subChart.ChartAreas[global_chartAreaName].AxisY2.MajorGrid.LineColor = Color.Silver;

            // resChart設定（走行抵抗曲線データ解析）
            resChart.Series.Add(global_resChartLegend);
            resChart.Series[global_resChartLegend].ChartType = SeriesChartType.Point;
            resChart.Series[global_resChartLegend].Color = Color.DodgerBlue;
            resChart.Series[global_resChartLegend].MarkerStyle = MarkerStyle.Circle;
            resChart.Series[global_resChartLegend].MarkerSize = 5;
            resChart.Series.Add(global_resChartLegendTheory);
            resChart.Series[global_resChartLegendTheory].ChartType = SeriesChartType.Spline;
            resChart.Series[global_resChartLegendTheory].Color = Color.Red;
            resChart.ChartAreas[global_chartAreaName].AxisX.Minimum = 0;
            resChart.ChartAreas[global_chartAreaName].AxisX.Maximum = 120;
            resChart.ChartAreas[global_chartAreaName].AxisY.Minimum = 0;
            resChart.ChartAreas[global_chartAreaName].AxisY.Maximum = 2000;
            resChart.ChartAreas[global_chartAreaName].AxisX.Interval = 10;
            resChart.ChartAreas[global_chartAreaName].AxisY.Interval = 200;
            resChart.ChartAreas[global_chartAreaName].AxisX.MajorGrid.LineColor = Color.Silver;
            resChart.ChartAreas[global_chartAreaName].AxisY.MajorGrid.LineColor = Color.Silver;

            double[] theoryVal_x = {0,10,20,30,40,50,60,70,80,90,100,110,120 };
            double[] theoryVal_y = {0,34.9,78.7,136.2,212.0,310.5,436.6,594.6,789.3,1025.2,1307.0,1639.3,2026.6 };

            for(int i = 0; i < theoryVal_x.Length; i++)
            {
                resChart.Series[global_resChartLegendTheory].Points.AddXY(theoryVal_x[i], theoryVal_y[i]);
            }


        }

        // 文字列配列を数値配列に変換する
        private int[] StringAryToIntAry(string[] strAry)
        {
            int[] intAry = new int[strAry.Length];
            for(int i = 0; i < strAry.Length; i++)
            {
                intAry[i] = int.Parse(strAry[i]);
            }

            // 要素が一つの場合バグる例外対策
            if(intAry.Length == 2 && intAry[0] == 0)
            {
                int temp = intAry[1];
                intAry = new int[1];
                intAry[0] = temp;
            }

            return intAry;
        }

        // csvデータ保存
        private void CSVoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "SerialDataLog.csv";
            sfd.InitialDirectory = @"C:\";
            sfd.Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            sfd.FilterIndex = 1;
            //タイトルを設定する
            sfd.Title = "保存先のファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.RestoreDirectory = true;
            //既に存在するファイル名を指定したとき警告する
            //デフォルトでTrueなので指定する必要はない
            sfd.OverwritePrompt = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、
                //選択された名前で新しいファイルを作成し、
                //読み書きアクセス許可でそのファイルを開く。
                //既存のファイルが選択されたときはデータが消える恐れあり。
                System.IO.Stream stream;
                stream = sfd.OpenFile();
                if (stream != null)
                {
                    //ファイルに書き込む
                    int tableRowsCount = dataGridViewMain.RowCount;
                    int tableColsCount = dataGridViewMain.ColumnCount;
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(stream))
                    {
                        sw.WriteLine("{0}", Properties.Settings.Default.dataAryColName);

                        for (int i = 0; i < tableRowsCount - 1; i++)  
                        {
                            for (int j = 0; j < tableColsCount; j++)
                            {
                                if (j < tableColsCount - 1)
                                {
                                    sw.Write("{0},", dataGridViewMain.Rows[i].Cells[j].Value.ToString());
                                }
                                else
                                {
                                    sw.Write("{0}\r\n", dataGridViewMain.Rows[i].Cells[j].Value.ToString());  // 最後のみ改行コード
                                }
                            }
                        }
                        sw.Close();
                        stream.Close();
                    }
                }
            }

        }

        // 既定の設定
        private void SettingDaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        // 設定リセット
        private void SettingResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        // 表示クリア
        private void AllDataClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewMain.Rows.Clear();
            ChartSettings();
        }

        // 終了ボタン
        private void CloseFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // シリアルポートを閉じる
            SerialPortClose();
            this.Close();
        }
    }
}
