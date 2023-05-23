using Otomasyon.BLL.Services;

namespace Otomasyon.UI
{
    public partial class TaskSummary : Form
    {
        public TaskSummary()
        {
            InitializeComponent();
        }

        private void TaskSummary_Load(object sender, EventArgs e)
        {
            int index = DashBoardUC.index;
            var deger = TaskServices.GetTasks((LoginForm.user.Id))[index];
            lblName.Text = deger.Name;
            lblDeadLine.Text = deger.DeadLine.ToString();
            lblStarTime.Text = deger.StartTime.ToString();
            rtbxPage.Text = deger.TaskMessage.ToString();

        }
    }
}
