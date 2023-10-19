using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTracking.PresentationLayer
{
    public partial class formToDo : Form
    {
        public formToDo()
        {
            InitializeComponent();
        }

        private void formToDo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
