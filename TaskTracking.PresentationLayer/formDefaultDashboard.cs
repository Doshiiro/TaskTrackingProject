﻿using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Management.Concrete;
using static ReaLTaiizor.Controls.ToggleEdit;

namespace TaskTracking.PresentationLayer
{
    public partial class formDefaultDashboard : Form
    {
        public formDefaultDashboard()
        {
            InitializeComponent();
        }
        public static int taskListId;
        private void formDefaultDashboard_Load(object sender, EventArgs e)
        {

            TaskTrackingContext context = new TaskTrackingContext();
            var calendarEvent = context.Calendars
                    .Where(c => c.emp_ID == taskListId).ToList();

            int calStatusData = 0;
            int calStatusNullData = 0;
            double calenderTotalEvent = calendarEvent.Count;

            foreach (var item in calendarEvent)
            {
                dataGridView2.Rows.Add(item.date, item.events, item.status);
                if (item.status != null)
                {
                    calStatusData++;

                }
                else
                {
                    calStatusNullData++;
                }
            }
            tasklbl.Text = calStatusData + " / " + calendarEvent.Count.ToString();

            chart1.Series["s1"].Points.AddY(calStatusData);
            chart1.Series["s1"].Points.AddY(calStatusNullData);


            chart1.Series["s1"].Points[0].Color = Color.FromArgb(176, 217, 177);//yeşil
            chart1.Series["s1"].Points[1].Color = Color.FromArgb(239, 98, 98);//kırmızı


            string  resultPercentage= "%" + Math.Round((((double)calStatusData / calenderTotalEvent) * 100)).ToString();
           
            if (resultPercentage=="%NaN")
            {
                graphPercentage.Text = "Görev yok";
            }
            else
            {
                graphPercentage.Text=resultPercentage;
            }

            dataGridView2.ReadOnly= true;

            dataGridView2.Sort(dataGridView2.Columns[0], ListSortDirection.Ascending);
            dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;


        }
        public void DatagridviewSetting(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }


        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == dataGridView2.RowCount - 1 && e.ColumnIndex >= 0)
            {
                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            }

        }
    }
}
