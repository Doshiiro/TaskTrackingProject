using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        private void formDefaultDashboard_Load(object sender, EventArgs e)
        {

            CalendarRepository calendarRepository = new CalendarRepository();
            var caldata = calendarRepository.GetAll();
            int calStatusData = 0;

            tasklbl.Text = calStatusData + " / " + caldata.Count.ToString();

            foreach (var item in caldata)
            {
                    dataGridView1.Rows.Add(item.date,item.events,"Null");
            }


            DatagridviewSetting(dataGridView1);

        }
        public void DatagridviewSetting(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(220,220, 220);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.DefaultCellStyle.BackColor = Color.FromArgb(220, 220, 220);
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
    }
}
