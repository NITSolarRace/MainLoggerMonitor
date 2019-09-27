namespace SmartLoggerMonitorApp
{
    partial class Form_SerialSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SerialSettings_OK = new System.Windows.Forms.Button();
            this.SerialSetteings_cacel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBox_com = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox_speed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_dataBit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboBox_parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBox_stopBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBox_flow = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBox_enter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboBox_encode = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTableButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dataNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_motorEff = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_carWeight = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.motorPowerNumber = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.speedNumber = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.motorPowerWhNumber = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.solarPowerWhNumber = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.solarPowerNumber = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNumUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorPowerNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorPowerWhNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarPowerWhNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarPowerNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialSettings_OK
            // 
            this.SerialSettings_OK.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SerialSettings_OK.Location = new System.Drawing.Point(877, 428);
            this.SerialSettings_OK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialSettings_OK.Name = "SerialSettings_OK";
            this.SerialSettings_OK.Size = new System.Drawing.Size(95, 26);
            this.SerialSettings_OK.TabIndex = 12;
            this.SerialSettings_OK.Text = "OK";
            this.SerialSettings_OK.UseVisualStyleBackColor = true;
            this.SerialSettings_OK.Click += new System.EventHandler(this.SerialSettings_OK_Click);
            // 
            // SerialSetteings_cacel
            // 
            this.SerialSetteings_cacel.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SerialSetteings_cacel.Location = new System.Drawing.Point(877, 462);
            this.SerialSetteings_cacel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SerialSetteings_cacel.Name = "SerialSetteings_cacel";
            this.SerialSetteings_cacel.Size = new System.Drawing.Size(95, 26);
            this.SerialSetteings_cacel.TabIndex = 13;
            this.SerialSetteings_cacel.Text = "キャンセル";
            this.SerialSetteings_cacel.UseVisualStyleBackColor = true;
            this.SerialSetteings_cacel.Click += new System.EventHandler(this.SerialSetteings_cacel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMポート：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_com
            // 
            this.ComboBox_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_com.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ComboBox_com.FormattingEnabled = true;
            this.ComboBox_com.Location = new System.Drawing.Point(122, 53);
            this.ComboBox_com.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_com.Name = "ComboBox_com";
            this.ComboBox_com.Size = new System.Drawing.Size(121, 26);
            this.ComboBox_com.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(18, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "通信速度：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_speed
            // 
            this.ComboBox_speed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_speed.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ComboBox_speed.FormattingEnabled = true;
            this.ComboBox_speed.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.ComboBox_speed.Location = new System.Drawing.Point(122, 87);
            this.ComboBox_speed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_speed.Name = "ComboBox_speed";
            this.ComboBox_speed.Size = new System.Drawing.Size(121, 26);
            this.ComboBox_speed.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(18, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "データ：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_dataBit
            // 
            this.ComboBox_dataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_dataBit.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ComboBox_dataBit.FormattingEnabled = true;
            this.ComboBox_dataBit.Items.AddRange(new object[] {
            "8 bits",
            "7 bits"});
            this.ComboBox_dataBit.Location = new System.Drawing.Point(122, 228);
            this.ComboBox_dataBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_dataBit.Name = "ComboBox_dataBit";
            this.ComboBox_dataBit.Size = new System.Drawing.Size(121, 26);
            this.ComboBox_dataBit.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(18, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "パリティ：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_parity
            // 
            this.ComboBox_parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_parity.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ComboBox_parity.FormattingEnabled = true;
            this.ComboBox_parity.Items.AddRange(new object[] {
            "none",
            "odd",
            "even",
            "mark",
            "space"});
            this.ComboBox_parity.Location = new System.Drawing.Point(122, 262);
            this.ComboBox_parity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_parity.Name = "ComboBox_parity";
            this.ComboBox_parity.Size = new System.Drawing.Size(121, 26);
            this.ComboBox_parity.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(18, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "ストップビット：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_stopBit
            // 
            this.ComboBox_stopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_stopBit.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ComboBox_stopBit.FormattingEnabled = true;
            this.ComboBox_stopBit.Items.AddRange(new object[] {
            "1 bit"});
            this.ComboBox_stopBit.Location = new System.Drawing.Point(122, 296);
            this.ComboBox_stopBit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_stopBit.Name = "ComboBox_stopBit";
            this.ComboBox_stopBit.Size = new System.Drawing.Size(121, 26);
            this.ComboBox_stopBit.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(18, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "フロー制御：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_flow
            // 
            this.ComboBox_flow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_flow.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ComboBox_flow.FormattingEnabled = true;
            this.ComboBox_flow.Items.AddRange(new object[] {
            "none"});
            this.ComboBox_flow.Location = new System.Drawing.Point(122, 330);
            this.ComboBox_flow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_flow.Name = "ComboBox_flow";
            this.ComboBox_flow.Size = new System.Drawing.Size(121, 26);
            this.ComboBox_flow.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(18, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "改行コード：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_enter
            // 
            this.ComboBox_enter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_enter.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ComboBox_enter.FormattingEnabled = true;
            this.ComboBox_enter.Items.AddRange(new object[] {
            "CRLF",
            "CR",
            "LF"});
            this.ComboBox_enter.Location = new System.Drawing.Point(122, 121);
            this.ComboBox_enter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_enter.Name = "ComboBox_enter";
            this.ComboBox_enter.Size = new System.Drawing.Size(121, 26);
            this.ComboBox_enter.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(18, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "エンコード：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBox_encode
            // 
            this.ComboBox_encode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_encode.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ComboBox_encode.FormattingEnabled = true;
            this.ComboBox_encode.Items.AddRange(new object[] {
            "UTF-8"});
            this.ComboBox_encode.Location = new System.Drawing.Point(122, 194);
            this.ComboBox_encode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_encode.Name = "ComboBox_encode";
            this.ComboBox_encode.Size = new System.Drawing.Size(121, 26);
            this.ComboBox_encode.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBox_encode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ComboBox_enter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ComboBox_flow);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComboBox_stopBit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboBox_parity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ComboBox_dataBit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboBox_speed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboBox_com);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 479);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "シリアル通信設定";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.createTableButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dataNumUpDown);
            this.groupBox2.Location = new System.Drawing.Point(277, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 479);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "データ設定";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(6, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(334, 421);
            this.dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "位置番号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "表示";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "データ名";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(160, 19);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(92, 27);
            this.createTableButton.TabIndex = 19;
            this.createTableButton.Text = "設定";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(18, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "データ数：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataNumUpDown
            // 
            this.dataNumUpDown.Location = new System.Drawing.Point(92, 21);
            this.dataNumUpDown.Name = "dataNumUpDown";
            this.dataNumUpDown.Size = new System.Drawing.Size(56, 25);
            this.dataNumUpDown.TabIndex = 0;
            this.dataNumUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataNumUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_motorEff);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBox_carWeight);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.motorPowerNumber);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.speedNumber);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.motorPowerWhNumber);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.solarPowerWhNumber);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.solarPowerNumber);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(630, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 476);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "エネマネサポート・データ解析設定";
            // 
            // textBox_motorEff
            // 
            this.textBox_motorEff.Location = new System.Drawing.Point(134, 304);
            this.textBox_motorEff.Name = "textBox_motorEff";
            this.textBox_motorEff.Size = new System.Drawing.Size(72, 25);
            this.textBox_motorEff.TabIndex = 23;
            this.textBox_motorEff.Text = "90.0";
            this.textBox_motorEff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 306);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 18);
            this.label18.TabIndex = 22;
            this.label18.Text = "モータ効率[%]：";
            // 
            // textBox_carWeight
            // 
            this.textBox_carWeight.Location = new System.Drawing.Point(134, 262);
            this.textBox_carWeight.Name = "textBox_carWeight";
            this.textBox_carWeight.Size = new System.Drawing.Size(72, 25);
            this.textBox_carWeight.TabIndex = 21;
            this.textBox_carWeight.Text = "250.0";
            this.textBox_carWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 264);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 18);
            this.label17.TabIndex = 20;
            this.label17.Text = "マシン総重量[kg]：";
            // 
            // motorPowerNumber
            // 
            this.motorPowerNumber.Location = new System.Drawing.Point(134, 94);
            this.motorPowerNumber.Name = "motorPowerNumber";
            this.motorPowerNumber.Size = new System.Drawing.Size(72, 25);
            this.motorPowerNumber.TabIndex = 10;
            this.motorPowerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 18);
            this.label15.TabIndex = 9;
            this.label15.Text = "モータ電力：";
            // 
            // speedNumber
            // 
            this.speedNumber.Location = new System.Drawing.Point(134, 220);
            this.speedNumber.Name = "speedNumber";
            this.speedNumber.Size = new System.Drawing.Size(72, 25);
            this.speedNumber.TabIndex = 8;
            this.speedNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "速度：";
            // 
            // motorPowerWhNumber
            // 
            this.motorPowerWhNumber.Location = new System.Drawing.Point(134, 178);
            this.motorPowerWhNumber.Name = "motorPowerWhNumber";
            this.motorPowerWhNumber.Size = new System.Drawing.Size(72, 25);
            this.motorPowerWhNumber.TabIndex = 6;
            this.motorPowerWhNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 180);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "モータ積算電力：";
            // 
            // solarPowerWhNumber
            // 
            this.solarPowerWhNumber.Location = new System.Drawing.Point(134, 136);
            this.solarPowerWhNumber.Name = "solarPowerWhNumber";
            this.solarPowerWhNumber.Size = new System.Drawing.Size(72, 25);
            this.solarPowerWhNumber.TabIndex = 4;
            this.solarPowerWhNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 18);
            this.label12.TabIndex = 3;
            this.label12.Text = "ソーラー積算電力：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "位置番号";
            // 
            // solarPowerNumber
            // 
            this.solarPowerNumber.Location = new System.Drawing.Point(134, 52);
            this.solarPowerNumber.Name = "solarPowerNumber";
            this.solarPowerNumber.Size = new System.Drawing.Size(72, 25);
            this.solarPowerNumber.TabIndex = 1;
            this.solarPowerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "ソーラー電力：";
            // 
            // Form_SerialSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 501);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SerialSetteings_cacel);
            this.Controls.Add(this.SerialSettings_OK);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SerialSettings";
            this.Text = "シリアル通信設定＆データ設定";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNumUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorPowerNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorPowerWhNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarPowerWhNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarPowerNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SerialSettings_OK;
        private System.Windows.Forms.Button SerialSetteings_cacel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox_com;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox_speed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_dataBit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboBox_parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBox_stopBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBox_flow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBox_enter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboBox_encode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown dataNumUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown speedNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown motorPowerWhNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown solarPowerWhNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown solarPowerNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown motorPowerNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_motorEff;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_carWeight;
    }
}