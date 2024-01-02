using ReaLTaiizor.Forms;
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
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.DesignForm;
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class formDashBoard : Form
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        public formDashBoard()
        {
            InitializeComponent();
        }

        TaskTrackingContext context = new TaskTrackingContext();

        private void formDashBoard_Load(object sender, EventArgs e)
        {
            poisonDataGridView1.ReadOnly = true;

            this.ControlBox = false;

            var datas = employeeRepository.GetAll();
            foreach (var item in datas)
            {
                var dataDep = context.Departments.FirstOrDefault(d => d.DepID == item.DepartmentID);

                poisonDataGridView1.Rows.Add(item.emp_ID, item.UserName, dataDep.DepartmentName, item.Email);
            }

            poisonDataGridView1.AllowUserToAddRows = false;
            poisonDataGridView1.ClearSelection();


            DepartmanShow();

        }
        public void DepartmanShow()
        {
            poisonDataGridView2.DataSource = null;
            poisonDataGridView2.Rows.Clear();
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                var departmentData = context.Departments.ToList();
                foreach (var item in departmentData)
                {
                    poisonDataGridView2.Rows.Add(item.DepID, item.DepartmentName);
                }
                poisonDataGridView2.AllowUserToAddRows = false;
                poisonDataGridView2.ClearSelection();
            }
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            poisonDataGridView1.DataSource = null;
            poisonDataGridView1.Rows.Clear();
            var datas = employeeRepository.GetAll();

            foreach (var item in datas)
            {
                var dataDep = context.Departments.FirstOrDefault(d => d.DepID == item.DepartmentID);

                poisonDataGridView1.Rows.Add(item.emp_ID, item.UserName, dataDep.DepartmentName, item.Email);
            }
        }

        private async void rjButton3_Click(object sender, EventArgs e)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            if (poisonDataGridView1.SelectedRows.Count > 0)
            {
                var deletedData = poisonDataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                int data = Convert.ToInt32(deletedData);
                await employeeRepository.Delete(data);
                poisonDataGridView1.Rows.RemoveAt(poisonDataGridView1.SelectedRows[0].Index);
                poisonDataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek Kullanıcıyı seçiniz");
            }
        }

        private void KullaniciEkleBtn_Click(object sender, EventArgs e)
        {
            PopupFormDesign popupFormDesign = new PopupFormDesign();
            popupFormDesign.Popup<modelForm1>();
        }

        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void departmanAdd_Click(object sender, EventArgs e)
        {
            DepartmanAddForm depform = new DepartmanAddForm();
            depform.Show();
        }

        private void DepartmanRefresh_Click(object sender, EventArgs e)
        {
            poisonDataGridView2.DataSource = null;
            poisonDataGridView2.Rows.Clear();
            DepartmanShow();
        }
    }
}
