using Otomasyon.BLL.Services;
using Otomasyon.Entity.Classes;
using Otomasyon.Model.Context;

namespace Otomasyon.UI
{
    public partial class LoginForm : Form
    {
        public static Employee user = new Employee();
        OtomasyonContext _db = new OtomasyonContext();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var control = _db.Employees.FirstOrDefault(x => x.Name == textBox1.Text.ToLower() && x.LastName.ToLower() == textBox2.Text.ToLower());
            if (control != null)
            {



                user = EmplyeeService.GetEmployeeName(textBox1.Text, textBox2.Text);

                var select = _db.Employees.Find(user.Id);
                select.Attentions.Add(new() { Start = DateTime.Now });
                _db.SaveChanges();
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunmamaktadır...");
            }
        }
    }
}
