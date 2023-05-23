using Otomasyon.BLL.Services;
using Otomasyon.Model.Context;
using System.Windows.Forms;

namespace Otomasyon.UI
{
    public partial class TaskUC : UserControl
    {
        int dgempIndex;
        int dgMang;
        bool control;
        OtomasyonContext _db = new OtomasyonContext();
        public TaskUC()
        {
            InitializeComponent();
        }

        private void TaskUC_Load(object sender, EventArgs e)
        {
            dgEmployee.DataSource = EmplyeeService.GetAllEmployees();


        }

        private void dgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgempIndex = e.RowIndex;
            control = false;
        }

        private void dgManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgMang = e.RowIndex;
            control = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (control)
                {

                    TaskServices.AddTask(dgMang, txtTaskName.Text, rbMsg.Text, "A", dtpTarih.Value);
                    MessageBox.Show("task assigned");

                }
                else
                {
                    TaskServices.AddTask(dgempIndex, txtTaskName.Text, rbMsg.Text, "B", dtpTarih.Value);
                    MessageBox.Show("task assigned");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Task assing can not be more than three");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string searchText = textBox2.Text.ToLower();
                var list = _db.Employees.ToList();
                dgEmployee.DataSource = list.Where(x => x.Id.ToString().Contains(searchText)).ToList();
            }
            else
            {
                string searchText = textBox2.Text.ToLower();
                var list = _db.Employees.ToList();
                dgEmployee.DataSource = list.Where(x => x.Name.Contains(searchText)).ToList();
            }
        }

        private void dgEmployee_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgEmployee_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (TaskServices.EmployeTaskControl(e.RowIndex))
            {
                DataGridViewRow row = dgEmployee.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = Color.Pink;
            }
        }
    }
}
