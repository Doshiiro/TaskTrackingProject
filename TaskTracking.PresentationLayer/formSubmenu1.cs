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
using TaskTracking.PresentationLayer.Entities;
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
            EventShow();
            dataGridView1.RowStateChanged += dataGridView1_RowStateChanged;
        }
        public void EventShow()
        {
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
                            dataGridView1.Rows.Add(item.date, item.events, item.status, item.calender_ID);
                            dataGridView1.Rows[row].Cells[2].Style.ForeColor = Color.Green;
                        }
                        else
                        {
                            item.status = "Yapılmadı";
                            dataGridView1.Rows.Add(item.date, item.events, item.status, item.calender_ID);
                            dataGridView1.Rows[row].Cells[2].Style.ForeColor = Color.Red;
                        }
                        row++;
                    }
                }
            }
            DatagridviewSetting(dataGridView1);

            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;

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
            dataGridView.MultiSelect = false;

            dataGridView.Columns[0].HeaderCell.Style.BackColor = Color.FromArgb(58, 158, 158);
        }

        private async void eventShowBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string dateText = dataGridView1.SelectedRows[0].Cells["Column1"].Value.ToString();
                string eventText = dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
                string calID = dataGridView1.SelectedRows[0].Cells["CalendarID"].Value.ToString();
                int id = Convert.ToInt32(calID);

                CalendarRepository calendarRepository = new CalendarRepository();
                CalendarEntity calendarEntity = new CalendarEntity()
                {
                    calender_ID = id,
                    date = dateText,
                    events = eventText,
                    status = "Yapıldı",
                    emp_ID = taskEmp_Fk
                };
                if (calendarEntity != null)
                {
                    await calendarRepository.Update(calendarEntity);
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    EventShow();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
            else
            {
                MessageBox.Show("Lütfen yapılan görevi seçiniz");
            }
            

        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            EventShow();
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                string status = e.Row.Cells["Column3"].Value.ToString();
                if (status == "Yapıldı")
                {
                    e.Row.Selected = false;
                }
            }
        }
    }
}
