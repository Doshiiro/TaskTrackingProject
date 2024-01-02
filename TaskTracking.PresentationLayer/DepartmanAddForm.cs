using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Entities;

namespace TaskTracking.PresentationLayer
{
    public partial class DepartmanAddForm : Form
    {
        public DepartmanAddForm()
        {
            InitializeComponent();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                string depname = depNametxt.Texts;
                Department _department = new Department()
                {
                    DepartmentName = depname
                };
                if (depNametxt.Texts == "")
                {
                    MessageBox.Show("Departman Adı giriniz");
                }
                else
                {
                    context.Add(_department);
                    context.SaveChanges();
                }

            }

        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
