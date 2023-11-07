using ReaLTaiizor.Controls;
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

            foreach (var item in calendarEvent)
            {
                dataGridView1.Rows.Add(item.date, item.events, item.status);
                if (item.status != null)
                {
                    calStatusData++;
                }
            }
            tasklbl.Text = calStatusData + " / " + calendarEvent.Count.ToString();


            DatagridviewSetting(dataGridView1);
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;


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
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.DefaultCellStyle.BackColor = Color.Red;
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;

            //alt çizgi
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.AllowUserToAddRows = false;

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == dataGridView1.RowCount - 1 && e.ColumnIndex >= 0)
            {
                e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            }
        }

        private void dungeonLabel3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
