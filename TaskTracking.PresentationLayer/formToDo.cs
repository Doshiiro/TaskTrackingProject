using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTracking.PresentationLayer.DAL;
using TaskTracking.PresentationLayer.Entities;

namespace TaskTracking.PresentationLayer
{
    public partial class formToDo : Form
    {
        public formToDo()
        {
            InitializeComponent();
        }
        static public int eventEmpID;
        private void formToDo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            EventShow();
        }
        public void EventShow()
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                var ProjeEvents = context.ProjeEvent.Where(emp => emp.EventEmpFK_ID == eventEmpID).ToList();
                int row = 0;
                foreach (var item in ProjeEvents)
                {
                    var projectName = context.Projects.Where(p => p.ProjectID == item.ProjectID).FirstOrDefault();

                    if (item.Status == false)
                    {
                        dataGridView1.Rows.Add(projectName.ProjectName, item.ProjeDescription, "Yapılmadı", item.ProjectID, item.ProjeEventID);
                        dataGridView1.Rows[row].Cells[2].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(projectName.ProjectName, item.ProjeDescription, "Yapıldı", item.ProjectID, item.ProjeEventID);
                        dataGridView1.Rows[row].Cells[2].Style.ForeColor = Color.Green;
                    }
                    row++;
                }
            }
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
            dataGridView.MultiSelect = false;

            dataGridView.Columns[0].HeaderCell.Style.BackColor = Color.FromArgb(58, 158, 158);
        }

        private void eventShowBtn_Click(object sender, EventArgs e)
        {
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    string evenDescription = dataGridView1.SelectedRows[0].Cells["Column2"].Value.ToString();
                    string projeID = dataGridView1.SelectedRows[0].Cells["projeID"].Value.ToString();
                    int dtoProjeID = Convert.ToInt32(projeID);
                    string eventID = dataGridView1.SelectedRows[0].Cells["EventID"].Value.ToString();
                    int dtoEventID = Convert.ToInt32(eventID);


                    ProjeEvent _projeEvent = new ProjeEvent()
                    {
                        ProjeEventID = dtoEventID,
                        ProjectID = dtoProjeID,
                        EventEmpFK_ID = eventEmpID,
                        ProjeDescription = evenDescription,
                        Status = true,
                    };
                    if (_projeEvent != null)
                    {
                        context.Update(_projeEvent);
                        context.SaveChanges();
                        dataGridView1.DataSource = null;
                        dataGridView1.Rows.Clear();
                        EventShow();
                    }
                    else
                    {
                        MessageBox.Show("proje Event nesnesi boş bir değer döndürdü");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen yapılan görevi seçiniz");
                }
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //column'da yapıldı yazıyorsa o satırı seçemez.
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                string status = e.Row.Cells["Column3"].Value.ToString();
                if (status == "Yapıldı")
                {
                    e.Row.Selected = false;
                }
            }
        }

        //yapılan proje eventlerini gizler yapılmayanları gösterir.
        private void statusFalseShowbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            using (TaskTrackingContext context = new TaskTrackingContext())
            {
                var ProjeEvents = context.ProjeEvent.Where(emp => emp.EventEmpFK_ID == eventEmpID).ToList();
                foreach (var item in ProjeEvents)
                {
                    var projectName = context.Projects.Where(p => p.ProjectID == item.ProjectID).FirstOrDefault();
                    if (item.Status == false)
                    {
                        dataGridView1.Rows.Add(projectName.ProjectName, item.ProjeDescription, "Yapılmadı", item.ProjectID, item.ProjeEventID);
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            EventShow();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            EventShow();
        }
    }
}
