using Otomasyon.BLL.Services;

namespace Otomasyon.UI
{
    public partial class DashBoardUC : UserControl
    {
        public DashBoardUC()
        {
            InitializeComponent();
        }

        private void DashBoardUC_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = LoginForm.user.PhotoPath;
            var taskList = TaskServices.GetTasks(LoginForm.user.Id);
            int totalTask = taskList.Count;


            if (totalTask > 0)
            {
                if (totalTask <= 1)
                {

                    progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                    label1.Text = taskList[totalTask - 1].Name;
                    label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                    label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                }
                else if (totalTask <= 2)
                {
                    progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                    progressBar2.Value = ((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days * 100) / (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                    label1.Text = taskList[totalTask - 1].Name;
                    label2.Text = taskList[totalTask - 2].Name;
                    label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                    label9.Text = taskList[totalTask - 2].DeadLine.ToShortDateString();
                    label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                    label15.Text = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime.Date)).Days.ToString();


                }
                else
                {
                    progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                    progressBar2.Value = ((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days * 100) / (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                    progressBar3.Value = ((DateTime.Now.Subtract(taskList[totalTask - 3].StartTime)).Days * 100) / (taskList[totalTask - 3].DeadLine.Subtract(taskList[totalTask - 3].StartTime)).Days;
                    label1.Text = taskList[totalTask - 1].Name;
                    label2.Text = taskList[totalTask - 2].Name;
                    label3.Text = taskList[totalTask - 3].Name;
                    label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                    label9.Text = taskList[totalTask - 2].DeadLine.ToShortDateString();
                    label10.Text = taskList[totalTask - 3].DeadLine.ToShortDateString();
                    label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                    label15.Text = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime.Date)).Days.ToString();
                    label16.Text = (taskList[totalTask - 3].DeadLine.Subtract(taskList[totalTask - 3].StartTime.Date)).Days.ToString();
                }
            }

        }
    }
}
