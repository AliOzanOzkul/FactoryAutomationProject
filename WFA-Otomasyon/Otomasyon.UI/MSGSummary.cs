using Otomasyon.BLL.Services;
using Otomasyon.Model.Context;

namespace Otomasyon.UI
{
    public partial class MSGSummary : Form
    {
        OtomasyonContext _db = new OtomasyonContext();

        public MSGSummary()
        {
            InitializeComponent();
        }

        private void MSGSummary_Load(object sender, EventArgs e)
        {
            int index = MessagesUC.sendIndex2;
            var deger = MessageServices.ShowMessageFull(LoginForm.user.Id)[index];
            richTextBox1.Text = deger.Message;
            label3.Text = deger.WhoSent;
            label4.Text = (deger.SentDay).ToString();
        }
    }
}
