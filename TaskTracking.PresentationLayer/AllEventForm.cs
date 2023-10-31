using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class AllEventForm : Form
    {
        public AllEventForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AllEventShow()
        {
            CalendarRepository calendarRepository = new CalendarRepository();
            var datacal = calendarRepository.GetAll();

            EmployeeRepository employeeRepository = new EmployeeRepository();
            var dataemp = employeeRepository.GetAll();

            foreach (var item in datacal)
            {
                var matchingEmployee = dataemp.FirstOrDefault(emp => emp.emp_ID == item.emp_ID);
                if (matchingEmployee != null)
                {
                    poisonDataGridView1.Rows.Add(item.calender_ID, matchingEmployee.UserName, item.date, item.events, item.emp_ID);
                }
            }

            poisonDataGridView1.Sort(poisonDataGridView1.Columns["CalenderDate"], ListSortDirection.Ascending);
            poisonDataGridView1.Columns["PersonelName"].SortMode = DataGridViewColumnSortMode.NotSortable;
            poisonDataGridView1.Columns["PersonelEvent"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void AllEventForm_Load(object sender, EventArgs e)
        {
            AllEventShow();
            poisonDataGridView1.ClearSelection();


        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = poisonDateTime1.Value;
            string formattedDate = selectedDate.ToString("yyyy/MM/dd");
            string calendarData = formattedDate.Replace(".", "/");

            int calID = Convert.ToInt32(txtCalendarID.Texts);
            string textdate = calendarData;
            string textevent = txtEvent.Texts;
            int empFk = Convert.ToInt32(txtFK.Texts);

            CalendarRepository calendarRepository = new CalendarRepository();

            EmployeeRepository employeeRepository = new EmployeeRepository();

            CalendarEntity calendarEntity = new CalendarEntity()

            {
                date = textdate,
                events = textevent,
                calender_ID = calID,
                emp_ID = empFk
            };

            if (calendarEntity != null)
            {
                await calendarRepository.Update(calendarEntity);
                poisonDataGridView1.DataSource = null;
                poisonDataGridView1.Rows.Clear();
                AllEventShow();
            }
            else
            {
                MessageBox.Show("hata");
            }
        }

        private void poisonDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (poisonDataGridView1.SelectedRows.Count > 0)
            {
                poisonDateTime1.Text = poisonDataGridView1.SelectedRows[0].Cells["CalenderDate"].Value.ToString();
                txtEvent.Texts = poisonDataGridView1.SelectedRows[0].Cells["PersonelEvent"].Value.ToString();
                txtPersonel.Texts = poisonDataGridView1.SelectedRows[0].Cells["PersonelName"].Value.ToString();
                txtCalendarID.Texts = poisonDataGridView1.SelectedRows[0].Cells["CalendarID"].Value.ToString();
                txtFK.Texts = poisonDataGridView1.SelectedRows[0].Cells["FkID"].Value.ToString();
            }
        }

        private async void rjButton1_Click(object sender, EventArgs e)
        {
            CalendarRepository calendarRepository = new CalendarRepository();

            if (poisonDataGridView1.SelectedRows.Count > 0)
            {
                var deletedData = poisonDataGridView1.SelectedRows[0].Cells["CalendarID"].Value.ToString();
                int data = Convert.ToInt32(deletedData);
                await calendarRepository.Delete(data);
                poisonDataGridView1.Rows.RemoveAt(poisonDataGridView1.SelectedRows[0].Index);
                poisonDataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek görevi seçiniz");
            }
        }
    }
}
