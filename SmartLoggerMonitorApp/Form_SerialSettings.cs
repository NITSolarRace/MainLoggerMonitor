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
using System.Configuration;
using System.Diagnostics;

namespace SmartLoggerMonitorApp
{
    public partial class Form_SerialSettings : Form
    {

        private bool createTableButtonClickFlag = false;

        public Form_SerialSettings()
        {
            InitializeComponent();

            // アクティブポートをCOM設定コンボボックスの要素に設定
            string[] activePort = SerialPort.GetPortNames();
            int defaultPortNameNum = 0;
            for (int i = 0; i < activePort.Length; i++)
            {
                ComboBox_com.Items.Add(activePort[i]);  // アクティブポートをセット
                // アクティブポートと設定のポートは一致した場合
                if(activePort[i] == Properties.Settings.Default.serialComName)
                {
                    defaultPortNameNum = i;  // 番号を格納
                }
            }

            if (defaultPortNameNum != 0)
            {
                ComboBox_com.SelectedIndex = defaultPortNameNum;  // 設定の番号を表示
            }

            // その他コンボボックスの初期値
            ComboBox_speed.SelectedIndex = 0;
            ComboBox_enter.SelectedIndex = 0;
            ComboBox_encode.SelectedIndex = 0;
            ComboBox_dataBit.SelectedIndex = 0;
            ComboBox_parity.SelectedIndex = 0;
            ComboBox_stopBit.SelectedIndex = 0;
            ComboBox_flow.SelectedIndex = 0;

            dataNumUpDown.Value = Properties.Settings.Default.serialDataNum;

            solarPowerNumber.Value = Properties.Settings.Default.solarPowerNum;
            motorPowerNumber.Value = Properties.Settings.Default.motorPowerNum;
            solarPowerWhNumber.Value = Properties.Settings.Default.solarPowerWhNum;
            motorPowerWhNumber.Value = Properties.Settings.Default.motorPowerWhNum;
            speedNumber.Value = Properties.Settings.Default.speedNum;

            textBox_carWeight.Text = Properties.Settings.Default.carWeight.ToString();
            textBox_motorEff.Text = Properties.Settings.Default.motorEff.ToString();
            
        }

        // OKボタンをクリック
        private void SerialSettings_OK_Click(object sender, EventArgs e)
        {
            if (!createTableButtonClickFlag)
            {
                MessageBox.Show("データ設定を行ってください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SerialPortConfigSetting();
                DataGridViewColSetting();
                DataAnalyzeSettings();
                this.Close();
            }

        }

        private void SerialSetteings_cacel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            string[] dataAryColName = Properties.Settings.Default.dataAryColName.Split(',');
            Properties.Settings.Default.serialDataNum = (int)dataNumUpDown.Value;
            Properties.Settings.Default.Save();

            dataGridView1.RowCount = Properties.Settings.Default.serialDataNum;

            for (int i = 0; i < Properties.Settings.Default.serialDataNum; i++)
            {
                int aryIndex = i > dataAryColName.Length - 1 ? dataAryColName.Length - 1 : i;
                dataGridView1.Rows[i].SetValues(i, true, dataAryColName[aryIndex]);
            }

            createTableButtonClickFlag = true;
        }

        private void SerialPortConfigSetting()
        {
            Properties.Settings.Default.serialComName = ComboBox_com.SelectedItem.ToString();
            Properties.Settings.Default.serialSpeedRate = ComboBox_speed.SelectedItem.ToString();
            Properties.Settings.Default.serialParity = ComboBox_parity.SelectedItem.ToString();
            Properties.Settings.Default.serialDataBits = ComboBox_dataBit.SelectedItem.ToString();
            Properties.Settings.Default.serialStopBits = ComboBox_stopBit.SelectedItem.ToString();
            Properties.Settings.Default.serialFlow = ComboBox_flow.SelectedItem.ToString();
            Properties.Settings.Default.serialEncode = ComboBox_encode.SelectedItem.ToString();
            Properties.Settings.Default.serialEnterCode = ComboBox_enter.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void DataGridViewColSetting()
        {
            int settingDataRowCount = Properties.Settings.Default.serialDataNum;

            bool[] dataAryShowUser = new bool[settingDataRowCount];
            string[] dataAryNameUser = new string[settingDataRowCount];

            for(int i = 0; i < settingDataRowCount; i++)
            {
                dataAryShowUser[i] = (bool)dataGridView1.Rows[i].Cells[1].Value;
                dataAryNameUser[i] = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }

            Properties.Settings.Default.dataAryColName = String.Join(",", dataAryNameUser);
            Properties.Settings.Default.dataAryColShow = String.Join(",", dataAryShowUser);
            Properties.Settings.Default.Save();

        }

        private void DataAnalyzeSettings()
        {
            Properties.Settings.Default.solarPowerNum = (int)solarPowerNumber.Value;
            Properties.Settings.Default.motorPowerNum = (int)motorPowerNumber.Value;
            Properties.Settings.Default.solarPowerWhNum = (int)solarPowerWhNumber.Value;
            Properties.Settings.Default.motorPowerWhNum = (int)motorPowerWhNumber.Value;
            Properties.Settings.Default.speedNum = (int)speedNumber.Value;
            if(double.TryParse(textBox_carWeight.Text, out double w))
            {
                Properties.Settings.Default.carWeight = w;
            }
            else
            {
                MessageBox.Show("数値を入力してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (double.TryParse(textBox_motorEff.Text, out double e))
            {
                Properties.Settings.Default.motorEff = e;
            }
            else
            {
                MessageBox.Show("数値を入力してください", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Properties.Settings.Default.Save();

        }
    }
}
