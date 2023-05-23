using Otomasyon.BLL.Services;

namespace Otomasyon.UI
{
    public partial class DashBoardUC : UserControl
    {
        public static int index;
        public DashBoardUC()
        {
            InitializeComponent();
        }

        public void DashBoardUC_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = LoginForm.user.PhotoPath;
            var taskList = TaskServices.GetTasks(LoginForm.user.Id);
            int totalTask = taskList.Count;
            dgTask.DataSource = TaskServices.GetTasks(LoginForm.user.Id).Select(x => new { Name = x.Name, StartTime = x.StartTime.ToString(), DeadTime = x.DeadLine.ToString() }).ToList();

            if (totalTask > 0)
            {
                if (totalTask <= 1)
                {
                    int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                    if (day1 <= 0)
                    {
                        day1 = 1;
                    }
                    progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                    progressBar1.Value = progressBar1.Value > 100 ? progressBar1.Value : 50;
                    label1.Text = taskList[totalTask - 1].Name;
                    label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                    label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                }
                else if (totalTask <= 2)
                {
                    int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                    int day2 = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                    if (day1 <= 0)
                    {
                        day1 = 1;
                    }
                    if (day2 <= 0)
                    {
                        day2 = 1;
                    }
                    progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                    progressBar1.Value = progressBar1.Value > 100 ? progressBar1.Value : 50;

                    progressBar2.Value = ((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days * 100) / day2;
                    progressBar2.Value = progressBar2.Value > 100 ? progressBar2.Value : 48;

                    label1.Text = taskList[totalTask - 1].Name;
                    label2.Text = taskList[totalTask - 2].Name;
                    label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                    label9.Text = taskList[totalTask - 2].DeadLine.ToShortDateString();
                    label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                    label15.Text = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime.Date)).Days.ToString();


                }
                else
                {
                    int day1 = (taskList[totalTask - 3].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                    int day2 = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                    int day3 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 3].StartTime)).Days;
                    if (day1 <= 0)
                    {
                        day1 = 1;
                    }
                    if (day2 <= 0)
                    {
                        day2 = 1;
                    }
                    if (day3 <= 0)
                    {
                        day3 = 1;
                    }
                    double a = (Convert.ToDouble((DateTime.Now.Subtract(taskList[totalTask - 3].StartTime)).Days));
                    progressBar1.Value = Convert.ToInt32(((Convert.ToDouble((DateTime.Now.Subtract(taskList[totalTask - 3].StartTime)).Days) ) / Convert.ToDouble(day1))*100);

                    progressBar2.Value = Convert.ToInt32(((Convert.ToDouble((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days) / Convert.ToDouble(day2)) * 100));


                    progressBar3.Value = Convert.ToInt32(((Convert.ToDouble((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days) / Convert.ToDouble(day3))));

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

        private void dgTask_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            TaskSummary taskSummary = new TaskSummary();
            taskSummary.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TaskServices.DeleteTask(label1.Text);
                var taskList = TaskServices.GetTasks(LoginForm.user.Id);
                int totalTask = taskList.Count;
                dgTask.DataSource = TaskServices.GetTasks(LoginForm.user.Id).Select(x => new { Name = x.Name, StartTime = x.StartTime.ToString(), DeadTime = x.DeadLine.ToString() }).ToList();

                if (totalTask > 0)
                {
                    if (totalTask <= 1)
                    {
                        int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                        if (day1 <= 0)
                        {
                            day1 = 1;
                        }
                        progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                        label1.Text = taskList[totalTask - 1].Name;
                        label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                        label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                    }
                    else if (totalTask <= 2)
                    {
                        int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                        int day2 = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                        if (day1 <= 0)
                        {
                            day1 = 1;
                        }
                        if (day2 <= 0)
                        {
                            day2 = 1;
                        }
                        progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                        progressBar2.Value = ((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days * 100) / day2;
                        label1.Text = taskList[totalTask - 1].Name;
                        label2.Text = taskList[totalTask - 2].Name;
                        label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                        label9.Text = taskList[totalTask - 2].DeadLine.ToShortDateString();
                        label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                        label15.Text = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime.Date)).Days.ToString();


                    }
                    else
                    {
                        int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                        int day2 = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                        int day3 = (taskList[totalTask - 3].DeadLine.Subtract(taskList[totalTask - 3].StartTime)).Days;
                        if (day1 <= 0)
                        {
                            day1 = 1;
                        }
                        if (day2 <= 0)
                        {
                            day2 = 1;
                        }
                        if (day3 <= 0)
                        {
                            day3 = 1;
                        }
                        progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                        progressBar2.Value = ((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days * 100) / day2;
                        progressBar3.Value = ((DateTime.Now.Subtract(taskList[totalTask - 3].StartTime)).Days * 100) / day3;
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
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TaskServices.DeleteTask(label2.Text);
                var taskList = TaskServices.GetTasks(LoginForm.user.Id);
                int totalTask = taskList.Count;
                dgTask.DataSource = TaskServices.GetTasks(LoginForm.user.Id).Select(x => new { Name = x.Name, StartTime = x.StartTime.ToString(), DeadTime = x.DeadLine.ToString() }).ToList();

                if (totalTask > 0)
                {
                    if (totalTask <= 1)
                    {
                        int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                        if (day1 <= 0)
                        {
                            day1 = 1;
                        }
                        progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                        label1.Text = taskList[totalTask - 1].Name;
                        label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                        label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                    }
                    else if (totalTask <= 2)
                    {
                        int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                        int day2 = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                        if (day1 <= 0)
                        {
                            day1 = 1;
                        }
                        if (day2 <= 0)
                        {
                            day2 = 1;
                        }
                        progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                        progressBar2.Value = ((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days * 100) / day2;
                        label1.Text = taskList[totalTask - 1].Name;
                        label2.Text = taskList[totalTask - 2].Name;
                        label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                        label9.Text = taskList[totalTask - 2].DeadLine.ToShortDateString();
                        label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                        label15.Text = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime.Date)).Days.ToString();


                    }
                    else
                    {
                        int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                        int day2 = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                        int day3 = (taskList[totalTask - 3].DeadLine.Subtract(taskList[totalTask - 3].StartTime)).Days;
                        if (day1 <= 0)
                        {
                            day1 = 1;
                        }
                        if (day2 <= 0)
                        {
                            day2 = 1;
                        }
                        if (day3 <= 0)
                        {
                            day3 = 1;
                        }
                        progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                        progressBar2.Value = ((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days * 100) / day2;
                        progressBar3.Value = ((DateTime.Now.Subtract(taskList[totalTask - 3].StartTime)).Days * 100) / day3;
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
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TaskServices.DeleteTask(label3.Text);
                var taskList = TaskServices.GetTasks(LoginForm.user.Id);
                int totalTask = taskList.Count;
                dgTask.DataSource = TaskServices.GetTasks(LoginForm.user.Id).Select(x => new { Name = x.Name, StartTime = x.StartTime.ToString(), DeadTime = x.DeadLine.ToString() }).ToList();

                if (totalTask > 0)
                {
                    if (totalTask <= 1)
                    {
                        int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                        if (day1 <= 0)
                        {
                            day1 = 1;
                        }
                        progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                        label1.Text = taskList[totalTask - 1].Name;
                        label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                        label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                    }
                    else if (totalTask <= 2)
                    {
                        int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                        int day2 = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                        if (day1 <= 0)
                        {
                            day1 = 1;
                        }
                        if (day2 <= 0)
                        {
                            day2 = 1;
                        }
                        progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                        progressBar2.Value = ((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days * 100) / day2;
                        label1.Text = taskList[totalTask - 1].Name;
                        label2.Text = taskList[totalTask - 2].Name;
                        label8.Text = taskList[totalTask - 1].DeadLine.ToShortDateString();
                        label9.Text = taskList[totalTask - 2].DeadLine.ToShortDateString();
                        label14.Text = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime.Date)).Days.ToString();
                        label15.Text = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime.Date)).Days.ToString();


                    }
                    else
                    {
                        int day1 = (taskList[totalTask - 1].DeadLine.Subtract(taskList[totalTask - 1].StartTime)).Days;
                        int day2 = (taskList[totalTask - 2].DeadLine.Subtract(taskList[totalTask - 2].StartTime)).Days;
                        int day3 = (taskList[totalTask - 3].DeadLine.Subtract(taskList[totalTask - 3].StartTime)).Days;
                        if (day1 <= 0)
                        {
                            day1 = 1;
                        }
                        if (day2 <= 0)
                        {
                            day2 = 1;
                        }
                        if (day3 <= 0)
                        {
                            day3 = 1;
                        }
                        progressBar1.Value = ((DateTime.Now.Subtract(taskList[totalTask - 1].StartTime)).Days * 100) / day1;
                        progressBar2.Value = ((DateTime.Now.Subtract(taskList[totalTask - 2].StartTime)).Days * 100) / day2;
                        progressBar3.Value = ((DateTime.Now.Subtract(taskList[totalTask - 3].StartTime)).Days * 100) / day3;
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
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }
    }
}
