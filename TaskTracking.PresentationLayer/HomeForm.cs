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

namespace TaskTracking.PresentationLayer
{
    public partial class HomeForm : MetroFramework.Forms.MetroForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            dataGridView1.DataSource = employeeRepository.GetAll();
        }

        

      
    }
}
