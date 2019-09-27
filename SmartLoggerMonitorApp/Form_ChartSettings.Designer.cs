namespace SmartLoggerMonitorApp
{
    partial class Form_ChartSettings
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
            this.dataGridViewChartSettings = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OKButton = new System.Windows.Forms.Button();
            this.textBox_xmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_xmax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ymax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ymin = new System.Windows.Forms.TextBox();
            this.textBox_y2max = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_y2min = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_xThicks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_y2Thicks = new System.Windows.Forms.TextBox();
            this.textBox_yThicks = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_graphRender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChartSettings)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewChartSettings
            // 
            this.dataGridViewChartSettings.AllowUserToAddRows = false;
            this.dataGridViewChartSettings.AllowUserToDeleteRows = false;
            this.dataGridViewChartSettings.AllowUserToResizeColumns = false;
            this.dataGridViewChartSettings.AllowUserToResizeRows = false;
            this.dataGridViewChartSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChartSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewChartSettings.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewChartSettings.Name = "dataGridViewChartSettings";
            this.dataGridViewChartSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewChartSettings.RowHeadersVisible = false;
            this.dataGridViewChartSettings.RowTemplate.Height = 21;
            this.dataGridViewChartSettings.Size = new System.Drawing.Size(503, 487);
            this.dataGridViewChartSettings.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "番号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "x軸";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "y軸";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "y軸2";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 60;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(836, 469);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(101, 30);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // textBox_xmin
            // 
            this.textBox_xmin.Location = new System.Drawing.Point(583, 60);
            this.textBox_xmin.Name = "textBox_xmin";
            this.textBox_xmin.Size = new System.Drawing.Size(100, 25);
            this.textBox_xmin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "x軸";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_xmax
            // 
            this.textBox_xmax.Location = new System.Drawing.Point(703, 60);
            this.textBox_xmax.Name = "textBox_xmax";
            this.textBox_xmax.Size = new System.Drawing.Size(100, 25);
            this.textBox_xmax.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "最小";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "最大";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ymax
            // 
            this.textBox_ymax.Location = new System.Drawing.Point(703, 115);
            this.textBox_ymax.Name = "textBox_ymax";
            this.textBox_ymax.Size = new System.Drawing.Size(100, 25);
            this.textBox_ymax.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "y軸";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_ymin
            // 
            this.textBox_ymin.Location = new System.Drawing.Point(583, 115);
            this.textBox_ymin.Name = "textBox_ymin";
            this.textBox_ymin.Size = new System.Drawing.Size(100, 25);
            this.textBox_ymin.TabIndex = 10;
            // 
            // textBox_y2max
            // 
            this.textBox_y2max.Location = new System.Drawing.Point(703, 168);
            this.textBox_y2max.Name = "textBox_y2max";
            this.textBox_y2max.Size = new System.Drawing.Size(100, 25);
            this.textBox_y2max.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(540, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "y軸2";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_y2min
            // 
            this.textBox_y2min.Location = new System.Drawing.Point(583, 168);
            this.textBox_y2min.Name = "textBox_y2min";
            this.textBox_y2min.Size = new System.Drawing.Size(100, 25);
            this.textBox_y2min.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(737, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "最大";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "最小";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(737, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "最大";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(616, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "最小";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_xThicks);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_y2Thicks);
            this.groupBox1.Controls.Add(this.textBox_yThicks);
            this.groupBox1.Location = new System.Drawing.Point(530, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 198);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "グラフ軸範囲の設定";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "軸間隔";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_xThicks
            // 
            this.textBox_xThicks.Location = new System.Drawing.Point(294, 48);
            this.textBox_xThicks.Name = "textBox_xThicks";
            this.textBox_xThicks.Size = new System.Drawing.Size(100, 25);
            this.textBox_xThicks.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "軸間隔";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "軸間隔";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_y2Thicks
            // 
            this.textBox_y2Thicks.Location = new System.Drawing.Point(294, 156);
            this.textBox_y2Thicks.Name = "textBox_y2Thicks";
            this.textBox_y2Thicks.Size = new System.Drawing.Size(100, 25);
            this.textBox_y2Thicks.TabIndex = 26;
            // 
            // textBox_yThicks
            // 
            this.textBox_yThicks.Location = new System.Drawing.Point(294, 103);
            this.textBox_yThicks.Name = "textBox_yThicks";
            this.textBox_yThicks.Size = new System.Drawing.Size(100, 25);
            this.textBox_yThicks.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(540, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 18);
            this.label13.TabIndex = 23;
            this.label13.Text = "グラフの更新間隔：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_graphRender
            // 
            this.comboBox_graphRender.FormattingEnabled = true;
            this.comboBox_graphRender.Items.AddRange(new object[] {
            "10",
            "1"});
            this.comboBox_graphRender.Location = new System.Drawing.Point(662, 252);
            this.comboBox_graphRender.Name = "comboBox_graphRender";
            this.comboBox_graphRender.Size = new System.Drawing.Size(94, 26);
            this.comboBox_graphRender.TabIndex = 24;
            // 
            // Form_ChartSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 511);
            this.Controls.Add(this.comboBox_graphRender);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_y2max);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_y2min);
            this.Controls.Add(this.textBox_ymax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ymin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_xmax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_xmin);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.dataGridViewChartSettings);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_ChartSettings";
            this.Text = "メイングラフ設定";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChartSettings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChartSettings;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox textBox_xmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_xmax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ymax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ymin;
        private System.Windows.Forms.TextBox textBox_y2max;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_y2min;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_xThicks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_y2Thicks;
        private System.Windows.Forms.TextBox textBox_yThicks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_graphRender;
    }
}