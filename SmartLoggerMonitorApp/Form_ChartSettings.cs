using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLoggerMonitorApp
{
    public partial class Form_ChartSettings : Form
    {
        public Form_ChartSettings()
        {
            InitializeComponent();

            dataGridViewChartSettings.RowCount = Properties.Settings.Default.serialDataNum;
            string[] dataAryColName = Properties.Settings.Default.dataAryColName.Split(',');
            for (int i = 0; i < Properties.Settings.Default.serialDataNum; i++)
            {
                dataGridViewChartSettings.Rows[i].SetValues(i, dataAryColName[i], false, false, false);
            }

            textBox_xmin.Text = Properties.Settings.Default.xmin.ToString();
            textBox_xmax.Text = Properties.Settings.Default.xmax.ToString();
            textBox_xThicks.Text = Properties.Settings.Default.xThickness.ToString();
            textBox_ymin.Text = Properties.Settings.Default.ymin.ToString();
            textBox_ymax.Text = Properties.Settings.Default.ymax.ToString();
            textBox_yThicks.Text = Properties.Settings.Default.yThickness.ToString();
            textBox_y2min.Text = Properties.Settings.Default.y2min.ToString();
            textBox_y2max.Text = Properties.Settings.Default.y2max.ToString();
            textBox_y2Thicks.Text = Properties.Settings.Default.y2Thickness.ToString();

            comboBox_graphRender.SelectedIndex = 0;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            int chartSettingsRowCount = dataGridViewChartSettings.RowCount;

            int chartSettingsNumber_x = 0;
            int[] chartSettingsNumber_y = new int[1];
            int[] chartSettingsNumber_y2 = new int[1];


            for (int i = 0; i < chartSettingsRowCount; i++)
            {
                if ((bool)dataGridViewChartSettings.Rows[i].Cells[2].Value == true)
                {
                    chartSettingsNumber_x = i;
                }

                if ((bool)dataGridViewChartSettings.Rows[i].Cells[3].Value == true)
                {
                    int[] chartSettingsNumber_y_temp = new int[chartSettingsNumber_y.Length];
                    chartSettingsNumber_y.CopyTo(chartSettingsNumber_y_temp, 0);
                    chartSettingsNumber_y = new int[chartSettingsNumber_y_temp.Length + 1];
                    chartSettingsNumber_y_temp.CopyTo(chartSettingsNumber_y, 0);
                    chartSettingsNumber_y[chartSettingsNumber_y_temp.Length] = i;
                }

                if ((bool)dataGridViewChartSettings.Rows[i].Cells[4].Value == true)
                {
                    int[] chartSettingsNumber_y2_temp = new int[chartSettingsNumber_y2.Length];
                    chartSettingsNumber_y2.CopyTo(chartSettingsNumber_y2_temp, 0);
                    chartSettingsNumber_y2 = new int[chartSettingsNumber_y2_temp.Length + 1];
                    chartSettingsNumber_y2_temp.CopyTo(chartSettingsNumber_y2, 0);
                    chartSettingsNumber_y2[chartSettingsNumber_y2_temp.Length] = i;
                }
            }

            Properties.Settings.Default.chartSettings_x = chartSettingsNumber_x;
            Properties.Settings.Default.chartSettings_y = String.Join(",", chartSettingsNumber_y);
            Properties.Settings.Default.chartSettings_y2 = String.Join(",", chartSettingsNumber_y2);

            Properties.Settings.Default.xmin = int.Parse(textBox_xmin.Text);
            Properties.Settings.Default.xmax = int.Parse(textBox_xmax.Text);
            Properties.Settings.Default.xThickness = int.Parse(textBox_xThicks.Text);
            Properties.Settings.Default.ymin = int.Parse(textBox_ymin.Text);
            Properties.Settings.Default.ymax = int.Parse(textBox_ymax.Text);
            Properties.Settings.Default.yThickness = int.Parse(textBox_yThicks.Text);
            Properties.Settings.Default.y2min = int.Parse(textBox_y2min.Text);
            Properties.Settings.Default.y2max = int.Parse(textBox_y2max.Text);
            Properties.Settings.Default.y2Thickness = int.Parse(textBox_y2Thicks.Text);
            Properties.Settings.Default.serialCountNum = int.Parse(comboBox_graphRender.SelectedItem.ToString());


            Properties.Settings.Default.Save();

            this.Close();
        }

    }
}
