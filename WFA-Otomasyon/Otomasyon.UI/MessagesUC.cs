using Otomasyon.BLL.Services;
using Otomasyon.Model.Context;

namespace Otomasyon.UI
{
    public partial class MessagesUC : UserControl
    {
        public int msgIndex;
        OtomasyonContext _db = new OtomasyonContext();
        public static int sendIndex;
        public static int sendIndex2;
        public MessagesUC()
        {
            InitializeComponent();
        }

        private void MessagesUC_Load(object sender, EventArgs e)
        {
            dgPersonel.DataSource = MessageServices.GetEmployees();


            dgInBox.DataSource = MessageServices.ShowMessage(LoginForm.user.Id);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = rbMsg.Text;
            string topic = txtTopic.Text;
            MessageServices.SendMessage(message, topic, sendIndex, LoginForm.user);
            dgInBox.DataSource = MessageServices.ShowMessage(LoginForm.user.Id);
            MessageBox.Show("Message Sent");

        }

        private void dgPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sendIndex = e.RowIndex;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            var list = _db.Employees.ToList();
            dgPersonel.DataSource = list.Where(x => x.Name.ToLower().Contains(searchText) || x.LastName.ToLower().Contains(searchText) || x.Id.ToString().Contains(searchText)).Select(x => new { ID = x.Id, Name = x.Name, LastName = x.LastName, Departman = x.Departman }).ToList();
        }

        private void dgInBox_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sendIndex2 = e.RowIndex;
            MSGSummary mSGSummary = new MSGSummary();
            mSGSummary.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageServices.DeleteMessage(LoginForm.user.Id, msgIndex);
                dgInBox.DataSource = MessageServices.ShowMessage(LoginForm.user.Id);
            }
            catch (Exception)
            {

                MessageBox.Show("Select a Message");
            }
        }

        private void dgInBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            msgIndex = e.RowIndex;
        }
    }
}
