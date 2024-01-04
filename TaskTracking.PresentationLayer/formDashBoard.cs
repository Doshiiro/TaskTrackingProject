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
                if (item.Access == 1)
                {
                    poisonDataGridView1.Rows.Add(item.emp_ID, item.UserName, dataDep.DepartmentName, item.Email, item.Password, "Admin");
                }
                else if (item.Access == 2)
                {
                    poisonDataGridView1.Rows.Add(item.emp_ID, item.UserName, dataDep.DepartmentName, item.Email, item.Password, "Yönetici");
                }
                else
                {
                    poisonDataGridView1.Rows.Add(item.emp_ID, item.UserName, dataDep.DepartmentName, item.Email, item.Password, "Kullanıcı");
                }

            }

            poisonDataGridView1.AllowUserToAddRows = false;
            poisonDataGridView1.ClearSelection();


            DepartmanShow();


            var departments = context.Departments.ToList();
            foreach (var item in departments)
            {
                metroComboBox1.Items.Add(item.DepartmentName);
            }

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
                if (item.Access == 1)
                {
                    poisonDataGridView1.Rows.Add(item.emp_ID, item.UserName, dataDep.DepartmentName, item.Email, item.Password, "Admin");
                }
                else if (item.Access == 2)
                {
                    poisonDataGridView1.Rows.Add(item.emp_ID, item.UserName, dataDep.DepartmentName, item.Email, item.Password, "Yönetici");
                }
                else
                {
                    poisonDataGridView1.Rows.Add(item.emp_ID, item.UserName, dataDep.DepartmentName, item.Email, item.Password, "Kullanıcı");
                }
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
            PopupFormDesign popupFormDesign = new PopupFormDesign();
            popupFormDesign.Popup<DepartmanAddForm>();
        }

        private void DepartmanRefresh_Click(object sender, EventArgs e)
        {
            poisonDataGridView2.DataSource = null;
            poisonDataGridView2.Rows.Clear();
            DepartmanShow();
        }

        private void DepartmanDelete_Click(object sender, EventArgs e)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                if (poisonDataGridView2.SelectedRows.Count > 0)
                {
                    var deletedData = poisonDataGridView2.SelectedRows[0].Cells["departmanID"].Value.ToString();
                    int departmentId = Convert.ToInt32(deletedData);

                    var departmentToRemove = context.Departments.FirstOrDefault(d => d.DepID == departmentId);

                    if (departmentToRemove != null)
                    {
                        context.Departments.Remove(departmentToRemove);
                        context.SaveChanges();
                        poisonDataGridView2.DataSource = null;
                        poisonDataGridView2.Rows.Clear();
                        DepartmanShow();
                    }
                }
            }
        }

        private void poisonDataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtEmpid.Text = poisonDataGridView1.CurrentRow.Cells[0].Value.ToString();

            kullaniciAdiTxt.Texts = poisonDataGridView1.CurrentRow.Cells[1].Value.ToString();

            metroComboBox1.SelectedItem = poisonDataGridView1.CurrentRow.Cells[2].Value.ToString();

            emailTxt.Texts = poisonDataGridView1.CurrentRow.Cells[3].Value.ToString();

            passwordTxt.Texts = poisonDataGridView1.CurrentRow.Cells[4].Value.ToString();

            metroComboBox2.SelectedItem = poisonDataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string departman = metroComboBox1.SelectedItem.ToString();
            int accessUpdate = (metroComboBox2.SelectedItem.ToString() == "Kullanıcı") ? 0 : 2;

            var depData = context.Departments.SingleOrDefault(d => d.DepartmentName == departman);

            if (depData != null)
            {
                Employee existingEmployee = context.Employees.FirstOrDefault(emp => emp.emp_ID == Convert.ToInt32(txtEmpid.Text));

                if (existingEmployee != null)
                {
                    // Mevcut nesneyi güncelle
                    existingEmployee.UserName = kullaniciAdiTxt.Texts;
                    existingEmployee.Password = passwordTxt.Texts;
                    existingEmployee.Email = emailTxt.Texts;
                    existingEmployee.DepartmentID = depData.DepID;
                    existingEmployee.Access = accessUpdate;

                    context.SaveChanges();
                    MessageBox.Show("Kullanıcı güncellendi");
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı");
                }
            }
            else
            {
                MessageBox.Show("Departman bulunamadı");
            }
        }

        private void poisonDataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            depUpdateid.Text = poisonDataGridView2.CurrentRow.Cells[0].Value.ToString();
            departmantUpdatetxt.Texts = poisonDataGridView2.CurrentRow.Cells[1].Value.ToString();
        }
        private void depUpdatebtn_Click(object sender, EventArgs e)
        {
            int depID = Convert.ToInt32(depUpdateid.Text);
            var existingDepartment = context.Departments.FirstOrDefault(d => d.DepID == depID);

            if (existingDepartment != null)
            {
                // Mevcut nesneyi güncelle
                existingDepartment.DepartmentName = departmantUpdatetxt.Texts;

                context.SaveChanges();
                MessageBox.Show("Departman Adı Güncellendi");
            }
            else
            {
                MessageBox.Show("Nesne hatası: Departman bulunamadı");
            }
        }

    }
}
