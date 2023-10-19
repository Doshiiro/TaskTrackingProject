using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracking.PresentationLayer.Entities;
using TaskTracking.PresentationLayer.Management.Concrete;

namespace TaskTracking.PresentationLayer
{
    public partial class formDashBoard : Form
    {
        public formDashBoard()
        {
            InitializeComponent();
        }

        private void formDashBoard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            EmployeeRepository employeeRepository = new EmployeeRepository();
            var datas = employeeRepository.GetAll();

            foreach (var item in datas)
            {
                poisonDataGridView1.Rows.Add(item.emp_ID,item.UserName);
            }

            poisonDataGridView1.AllowUserToAddRows = false;
            

        }
        private void poisonDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
