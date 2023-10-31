using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using takvim;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class formSubmenu1 : Form
    {
        public formSubmenu1()
        {
            InitializeComponent();
        }
        public static int taskEmp_Fk;
        private void formSubmenu1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                int row = 0;
                var calendarEvent = context.Calendars
                    .Where(c => c.emp_ID == taskEmp_Fk).ToList();
                if (calendarEvent != null)
                {
                    foreach (var item in calendarEvent)
                    {
                        if (item.status == "Yapıldı")
                        {
                            dataGridView1.Rows.Add(item.date, item.events, item.status);
                            dataGridView1.Rows[row].Cells[2].Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            item.status = "Yapılmadı";
                            dataGridView1.Rows.Add(item.date, item.events, item.status);
                            dataGridView1.Rows[row].Cells[2].Style.ForeColor = Color.Red;
                        }
                        row++;
                    }
                }
            }
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

            DatagridviewSetting(dataGridView1);
        }



        public void DatagridviewSetting(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 52, 52);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 125, 165);
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Transparent;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.DefaultCellStyle.ForeColor = Color.Black;

            //alt çizgi
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.AllowUserToAddRows = false;

            dataGridView.Columns[0].HeaderCell.Style.BackColor = Color.FromArgb(58, 158, 158);


        }

        private void eventShowBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
