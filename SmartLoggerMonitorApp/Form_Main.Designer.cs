namespace SmartLoggerMonitorApp
{
    partial class Form_Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvOutPutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.切り取りToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.allDataClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通信設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SerialSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChartSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingDaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.エネマネサポートToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.シミュレーション読み込みToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データリセットToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.subChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Δt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solar2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.編集EToolStripMenuItem,
            this.通信設定ToolStripMenuItem,
            this.エネマネサポートToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1266, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くOToolStripMenuItem,
            this.csvOutPutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeFormToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くOToolStripMenuItem
            // 
            this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            this.開くOToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.開くOToolStripMenuItem.Text = "開く(&O)...";
            // 
            // csvOutPutToolStripMenuItem
            // 
            this.csvOutPutToolStripMenuItem.Name = "csvOutPutToolStripMenuItem";
            this.csvOutPutToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.csvOutPutToolStripMenuItem.Text = "CSV出力(&A)...";
            this.csvOutPutToolStripMenuItem.Click += new System.EventHandler(this.CSVoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.closeFormToolStripMenuItem.Text = "終了(&X)";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.CloseFormToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.切り取りToolStripMenuItem,
            this.コピーToolStripMenuItem,
            this.toolStripMenuItem2,
            this.allDataClearToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 切り取りToolStripMenuItem
            // 
            this.切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem";
            this.切り取りToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.切り取りToolStripMenuItem.Text = "選択";
            // 
            // コピーToolStripMenuItem
            // 
            this.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem";
            this.コピーToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.コピーToolStripMenuItem.Text = "コピー";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 6);
            // 
            // allDataClearToolStripMenuItem
            // 
            this.allDataClearToolStripMenuItem.Name = "allDataClearToolStripMenuItem";
            this.allDataClearToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.allDataClearToolStripMenuItem.Text = "表示データクリア";
            this.allDataClearToolStripMenuItem.Click += new System.EventHandler(this.AllDataClearToolStripMenuItem_Click);
            // 
            // 通信設定ToolStripMenuItem
            // 
            this.通信設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SerialSettingsToolStripMenuItem,
            this.ChartSettingsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.settingDaveToolStripMenuItem,
            this.settingResetToolStripMenuItem});
            this.通信設定ToolStripMenuItem.Name = "通信設定ToolStripMenuItem";
            this.通信設定ToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.通信設定ToolStripMenuItem.Text = "設定(&S)";
            // 
            // SerialSettingsToolStripMenuItem
            // 
            this.SerialSettingsToolStripMenuItem.Name = "SerialSettingsToolStripMenuItem";
            this.SerialSettingsToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.SerialSettingsToolStripMenuItem.Text = "シリアル通信&&データ設定...";
            this.SerialSettingsToolStripMenuItem.Click += new System.EventHandler(this.SerialSetteingsToolStripMenuItem_Click);
            // 
            // ChartSettingsToolStripMenuItem
            // 
            this.ChartSettingsToolStripMenuItem.Name = "ChartSettingsToolStripMenuItem";
            this.ChartSettingsToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.ChartSettingsToolStripMenuItem.Text = "グラフ設定...";
            this.ChartSettingsToolStripMenuItem.Click += new System.EventHandler(this.ChartSettingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(287, 6);
            // 
            // settingDaveToolStripMenuItem
            // 
            this.settingDaveToolStripMenuItem.Name = "settingDaveToolStripMenuItem";
            this.settingDaveToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.settingDaveToolStripMenuItem.Text = "既定の設定として保存";
            this.settingDaveToolStripMenuItem.Click += new System.EventHandler(this.SettingDaveToolStripMenuItem_Click);
            // 
            // settingResetToolStripMenuItem
            // 
            this.settingResetToolStripMenuItem.Name = "settingResetToolStripMenuItem";
            this.settingResetToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.settingResetToolStripMenuItem.Text = "設定をリセット";
            this.settingResetToolStripMenuItem.Click += new System.EventHandler(this.SettingResetToolStripMenuItem_Click);
            // 
            // エネマネサポートToolStripMenuItem
            // 
            this.エネマネサポートToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.シミュレーション読み込みToolStripMenuItem,
            this.データリセットToolStripMenuItem1});
            this.エネマネサポートToolStripMenuItem.Name = "エネマネサポートToolStripMenuItem";
            this.エネマネサポートToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.エネマネサポートToolStripMenuItem.Text = "エネマネサポート(&X)";
            // 
            // シミュレーション読み込みToolStripMenuItem
            // 
            this.シミュレーション読み込みToolStripMenuItem.Name = "シミュレーション読み込みToolStripMenuItem";
            this.シミュレーション読み込みToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.シミュレーション読み込みToolStripMenuItem.Text = "シミュレーション読み込み";
            // 
            // データリセットToolStripMenuItem1
            // 
            this.データリセットToolStripMenuItem1.Name = "データリセットToolStripMenuItem1";
            this.データリセットToolStripMenuItem1.Size = new System.Drawing.Size(264, 30);
            this.データリセットToolStripMenuItem1.Text = "データリセット";
            this.データリセットToolStripMenuItem1.Click += new System.EventHandler(this.dataResetToolStripMenuItem1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewMain, 2);
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowTemplate.Height = 21;
            this.dataGridViewMain.Size = new System.Drawing.Size(652, 385);
            this.dataGridViewMain.TabIndex = 1;
            this.dataGridViewMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Controls.Add(this.subChart, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMain, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.mainChart, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1266, 652);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // subChart
            // 
            this.subChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.subChart.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.subChart, 2);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.subChart.Legends.Add(legend1);
            this.subChart.Location = new System.Drawing.Point(661, 394);
            this.subChart.Name = "subChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.subChart.Series.Add(series1);
            this.subChart.Size = new System.Drawing.Size(602, 255);
            this.subChart.TabIndex = 4;
            this.subChart.Text = "chart1";
            // 
            // mainChart
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea2);
            this.tableLayoutPanel1.SetColumnSpan(this.mainChart, 2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.MaximumAutoSize = 100F;
            legend2.Name = "Legend1";
            this.mainChart.Legends.Add(legend2);
            this.mainChart.Location = new System.Drawing.Point(3, 394);
            this.mainChart.Name = "mainChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.mainChart.Series.Add(series2);
            this.mainChart.Size = new System.Drawing.Size(652, 255);
            this.mainChart.TabIndex = 3;
            this.mainChart.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Δt,
            this.Solar,
            this.Motor,
            this.Solar2,
            this.Motor2});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Location = new System.Drawing.Point(661, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(602, 385);
            this.dataGridView1.TabIndex = 4;
            // 
            // Time
            // 
            this.Time.HeaderText = "時間";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Δt
            // 
            this.Δt.HeaderText = "Δt";
            this.Δt.Name = "Δt";
            this.Δt.ReadOnly = true;
            // 
            // Solar
            // 
            this.Solar.HeaderText = "Ps[Wh]";
            this.Solar.Name = "Solar";
            this.Solar.ReadOnly = true;
            // 
            // Motor
            // 
            this.Motor.HeaderText = "Pm[Wh]";
            this.Motor.Name = "Motor";
            this.Motor.ReadOnly = true;
            // 
            // Solar2
            // 
            this.Solar2.HeaderText = "補間Ps[Wh]";
            this.Solar2.Name = "Solar2";
            this.Solar2.ReadOnly = true;
            // 
            // Motor2
            // 
            this.Motor2.HeaderText = "補間Pm[Wh]";
            this.Motor2.Name = "Motor2";
            this.Motor2.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Main";
            this.Text = "MainLogger Monitor 2019";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csvOutPutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通信設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 切り取りToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem コピーToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem allDataClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SerialSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem settingDaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem エネマネサポートToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem シミュレーション読み込みToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem ChartSettingsToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart subChart;
        private System.Windows.Forms.ToolStripMenuItem settingResetToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Δt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motor2;
        private System.Windows.Forms.ToolStripMenuItem データリセットToolStripMenuItem1;
    }
}

