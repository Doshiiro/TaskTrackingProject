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
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.DesignForm;
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class formSubmenu2 : Form
    {
        public formSubmenu2()
        {
            InitializeComponent();
        }
        static public int ProjeAccess;
        static public int ProjeDepID;
        static public int projeEventEmpID;
        static public int projeempID;
        private void formSubmenu2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.AllowUserToAddRows = false;
            showDatas();


        }
        public void showDatas()
        {
            ProjectRepository projectRepository = new ProjectRepository();
            var datacal = projectRepository.GetAll();

            TaskTrackingContext context = new TaskTrackingContext();

            if (ProjeAccess == 0)
            {
                eventShowBtn.Visible = false;
                projeDeletebtn.Visible = false;
                dataGridView2.Columns[3].Visible = false;

                foreach (var item in datacal)
                {
                    var empFKName = context.Employees.Where(emp => emp.emp_ID == item.projectEmp_ID).FirstOrDefault();
                    var empDepName = context.Departments.Where(d => d.DepID == empFKName.DepartmentID).FirstOrDefault();

                    //kullanıcının olduğu departmanda ki projeleri görebilir.
                    if (ProjeDepID == item.DepartmentID)
                    {
                        dataGridView1.Rows.Add(item.ProjectName, empFKName.UserName, empDepName.DepartmentName, item.ProjectID);
                    }

                }

                //giren kullanıcının id'sini almam lazım eğer id proje event tablosu ile eşit ise dgw yazdır

                var projeEvents = context.ProjeEvent.ToList();
                int projeCount = 0;
                int projeEventCount = 0;
                int projeEventStatusFalse = 0;
                int toplamevent = 0;
                foreach (var item in projeEvents)
                {
                    var projectName = context.Projects.Where(p => p.ProjectID == item.ProjectID).FirstOrDefault();

                    if (projeEventEmpID == item.EventEmpFK_ID)
                    {
                        if (item.Status == true)
                        {
                            dataGridView2.Rows.Add(item.ProjeDescription, projectName.ProjectName, item.ProjeEventID, "", "Yapıldı");

                            projeEventCount++;
                        }
                        else
                        {
                            dataGridView2.Rows.Add(item.ProjeDescription, projectName.ProjectName, item.ProjeEventID, "", "Yapılmadı");

                            projeEventStatusFalse++;
                        }
                        toplamevent++;
                    }
                }

                if (ProjeAccess == 0)
                {
                    var projects = context.Projects.ToList();
                    foreach (var item in projects)
                    {
                        var projeEventCountMatch = context.ProjeEvent.Where(p => p.ProjectID == item.ProjectID).FirstOrDefault();
                        if (projeEventCountMatch != null)
                        {
                            projeCount++;
                        }
                    }
                }
                //ilişkili projeleri projeler label'a yazdırma
                projelbl.Text = "Çalışılan Projeler: " + projeCount.ToString();
                tasklbl.Text = projeEventCount.ToString() + "/" + toplamevent.ToString();
            }


            if (ProjeAccess == 2)
            {
                eventShowBtn.Visible = false;
                projeDeletebtn.Visible = false;
                //yönetici bütün eventleri görebilir.


                //bütün projeleri görür
                foreach (var item in datacal)
                {
                    var empFKName = context.Employees.Where(emp => emp.emp_ID == item.projectEmp_ID).FirstOrDefault();
                    var empDepName = context.Departments.Where(d => d.DepID == empFKName.DepartmentID).FirstOrDefault();

                    //kullanıcının olduğu departmanda ki projeleri görebilir.
                    if (ProjeDepID == item.DepartmentID)
                    {
                        dataGridView1.Rows.Add(item.ProjectName, empFKName.UserName, empDepName.DepartmentName, item.ProjectID);
                    }
                }

                //bütün görevler gözükür
                var projeEventsMatch = context.ProjeEvent.ToList();
                foreach (var eventItem in projeEventsMatch)
                {
                    //eğer uygulamaya giren kullanıcının departman id si eşitse. proje eventlerini döndürsün.

                    var projectMatch = context.Projects.Where(proje => proje.ProjectID == eventItem.ProjectID).FirstOrDefault();
                    var employeeMatch = context.Employees.Where(emp => emp.emp_ID == eventItem.EventEmpFK_ID).FirstOrDefault();
                    if (projectMatch.DepartmentID == ProjeDepID)
                    {
                        if (eventItem.Status == true)
                        {
                            dataGridView2.Rows.Add(eventItem.ProjeDescription, projectMatch.ProjectName, eventItem.ProjeEventID, employeeMatch.UserName, "Yapıldı");

                        }
                        else
                        {
                            dataGridView2.Rows.Add(eventItem.ProjeDescription, projectMatch.ProjectName, eventItem.ProjeEventID, employeeMatch.UserName, "Yapılmadı");

                        }
                    }

                }

                var projeEvents = context.ProjeEvent.ToList();
                int projeCount = 0;
                int projeEventCount = 0;
                int projeEventStatusFalse = 0;
                int toplamevent = 0;
                foreach (var item in projeEvents)
                {
                    var projectName = context.Projects.Where(p => p.ProjectID == item.ProjectID).FirstOrDefault();

                    if (projeEventEmpID == item.EventEmpFK_ID)
                    {
                        if (item.Status == true)
                        {
                            projeEventCount++;
                        }
                        else
                        {
                            projeEventStatusFalse++;
                        }
                        toplamevent++;
                    }
                }

                var projects = context.Projects.Where(p => p.projectEmp_ID == projeempID).ToList();
                foreach (var item in projects)
                {
                    projeCount++;
                }

                //ilişkili projeleri projeler label'a yazdırma
                projelbl.Text = "Çalışılan Projeler: " + projeCount.ToString();
                tasklbl.Text = projeEventCount.ToString() + "/" + toplamevent.ToString();
            }


            if (ProjeAccess == 0 || ProjeAccess == 1)
            {
                eventbtn.Visible = false;
                button1.Visible = false;

            }
            if (ProjeAccess == 1)
            {
                foreach (var item in datacal)
                {
                    var empFKName = context.Employees.Where(emp => emp.emp_ID == item.projectEmp_ID).FirstOrDefault();
                    var empDepName = context.Departments.Where(d => d.DepID == empFKName.DepartmentID).FirstOrDefault();

                    dataGridView1.Rows.Add(item.ProjectName, empFKName.UserName, empDepName.DepartmentName, item.ProjectID);

                }

                var projeEvents = context.ProjeEvent.ToList();
                int projeCount = 0;
                int projeEventCount = 0;
                int projeEventStatusFalse = 0;
                int toplamevent = 0;

                foreach (var item in projeEvents)
                {
                    var projectName = context.Projects.Where(p => p.ProjectID == item.ProjectID).FirstOrDefault();
                    var employeeMatch = context.Employees.Where(emp => emp.emp_ID == item.EventEmpFK_ID).FirstOrDefault();



                    if (item.Status == true)
                    {
                        dataGridView2.Rows.Add(item.ProjeDescription, projectName.ProjectName, item.ProjeEventID, employeeMatch.UserName, "Yapıldı");

                        projeEventCount++;
                    }
                    else
                    {
                        dataGridView2.Rows.Add(item.ProjeDescription, projectName.ProjectName, item.ProjeEventID, employeeMatch.UserName, "Yapılmadı");

                        projeEventStatusFalse++;
                    }
                }
                var projects = context.Projects.Where(p => p.projectEmp_ID == projeempID);
                foreach (var item in projects)
                {
                    projeCount++;
                }

                projelbl.Text = "Çalışılan Projeler: " + projeCount.ToString();
                tasklbl.Text = projeEventCount.ToString() + "/" + projeEventStatusFalse.ToString();
            }
        }
        private void eventShowBtn_Click(object sender, EventArgs e)
        {
            PopupFormDesign popupFormDesign = new PopupFormDesign();
            popupFormDesign.Popup<ProjeAddForm>();
        }

        private void eventbtn_Click(object sender, EventArgs e)
        {
            ProjectEventForm projectEventForm = new ProjectEventForm();
            ProjectEventForm.ProjeEventEmpID2 = projeEventEmpID;
            projectEventForm.Show();
        }

        private void projeDeletebtn_Click(object sender, EventArgs e)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var deletedData = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                    int projectID = Convert.ToInt32(deletedData);

                    var projectRemove = context.Projects.FirstOrDefault(p => p.ProjectID == projectID);

                    DialogResult secenek = MessageBox.Show("Projeyi silmek istediğinizden emin misiniz ?", "Proje Silme", MessageBoxButtons.YesNo);
                    if (secenek == DialogResult.Yes)
                    {
                        if (projectRemove != null)
                        {
                            context.Projects.Remove(projectRemove);
                            context.SaveChanges();
                            MessageBox.Show("Proje silindi");
                            dataGridView1.DataSource = null;
                            dataGridView1.Rows.Clear();
                            dataGridView2.DataSource = null;
                            dataGridView2.Rows.Clear();
                            showDatas();
                        }
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    var deletedData = dataGridView2.SelectedRows[0].Cells["eventid"].Value.ToString();
                    int projectID = Convert.ToInt32(deletedData);

                    var projectRemove = context.ProjeEvent.FirstOrDefault(p => p.ProjeEventID == projectID);

                    DialogResult secenek = MessageBox.Show("Görevi silmek istediğinizden emin misiniz ?", "Görev Silme", MessageBoxButtons.YesNo);
                    if (secenek == DialogResult.Yes)
                    {
                        if (projectRemove != null)
                        {
                            context.ProjeEvent.Remove(projectRemove);
                            context.SaveChanges();
                            MessageBox.Show("Görev silindi");
                            dataGridView1.DataSource = null;
                            dataGridView1.Rows.Clear();
                            dataGridView2.DataSource = null;
                            dataGridView2.Rows.Clear();
                            showDatas();
                        }
                    }

                }
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            showDatas();
        }
    }
}
