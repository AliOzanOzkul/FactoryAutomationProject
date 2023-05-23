using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Otomasyon.Model.Context;

namespace Otomasyon.UI
{
    public partial class MainForm : Form
    {
        OtomasyonContext _db = new OtomasyonContext();
        public MainForm()
        {
            InitializeComponent();
            Colorlbl.Width = btnDash.Width;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeUC employeeUC = new EmployeeUC();
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(employeeUC);
            Colorlbl.Location = new Point(btnEmployee.Left + 12, pnlMenu.Bottom);
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            DashBoardUC dashBoardUC = new DashBoardUC();
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(dashBoardUC);
            Colorlbl.Location = new Point(btnDash.Left + 12, pnlMenu.Bottom);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (LoginForm.user.Role != "A")
            {
                pnlMenu.Controls.Remove(btnEmployee);
                pnlMenu.Controls.Remove(btnTask);
                pnlMenu.Controls.Remove(btnExpenses);
            }

        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            MessagesUC messagesUC = new MessagesUC();
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(messagesUC);
            Colorlbl.Location = new Point(btnMessages.Left + 12, pnlMenu.Bottom);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            TaskUC taskUC = new TaskUC();
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(taskUC);
            Colorlbl.Location = new Point(btnTask.Left + 12, pnlMenu.Bottom);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            BillUC billUC = new BillUC();
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(billUC);
            Colorlbl.Location = new Point(btnExpenses.Left + 12, pnlMenu.Bottom);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Close", "Would you like to close the program?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var attenList = _db.Employees.Find(LoginForm.user.Id);
                var atList = _db.Attentions.Include(x => x.Employee).Where(x => x.Employee.Id == attenList.Id).ToList();


                int index = atList.Count;
                var selectAttent = atList[index - 1];
                selectAttent.End = DateTime.Now;
                _db.SaveChanges();

            }
            else
            {

                e.Cancel = true;
            }
        }

        private void btnAtten_Click(object sender, EventArgs e)
        {
            AttenceUC attenceUC = new AttenceUC();
            pnlScreen.Controls.Clear();
            pnlScreen.Controls.Add(attenceUC);
            Colorlbl.Location = new Point(btnAtten.Left + 12, pnlMenu.Bottom);

        }

    }
}
