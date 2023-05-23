using iTextSharp.text;
using iTextSharp.text.pdf;
using Otomasyon.BLL.Services;
using Otomasyon.Entity.Classes;
using Otomasyon.Entity.Enums;
using Otomasyon.Model.Context;
using Document = iTextSharp.text.Document;

namespace Otomasyon.UI
{
    public partial class EmployeeUC : UserControl
    {
        OtomasyonContext _db = new OtomasyonContext();
        int index;


        public EmployeeUC()
        {
            InitializeComponent();
        }


        private void EmployeeUC_Load(object sender, EventArgs e)
        {
            cbGender.DataSource = Enum.GetNames(typeof(Gender));
            cbDepartman.DataSource = Enum.GetNames(typeof(Departman));

            dataGridView1.DataSource = EmplyeeService.GetAllEmployees();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                Employee employee = new Employee() { Name = txtName.Text, LastName = txtLastName.Text, Departman = (Departman)cbDepartman.SelectedIndex, Gender = (Gender)cbGender.SelectedIndex, BirthDay = dateTimePicker1.Value, PhoneNo = Convert.ToInt64(txtPhoneNo.Text), IdentityNo = Convert.ToInt64(txtIdentityNo.Text), Salary = Convert.ToDecimal(txtSalary.Text) };
                EmplyeeService.AddEmployee(employee);
                dataGridView1.DataSource = EmplyeeService.GetAllEmployees();

            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter Correctly");

            }


        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = e.RowIndex;
            var employee = EmplyeeService.GetEmployee(index);

            txtName.Text = employee.Name.ToString();
            txtLastName.Text = employee.LastName.ToString();
            txtIdentityNo.Text = employee.IdentityNo.ToString();
            txtSalary.Text = employee.Salary.ToString();
            txtPhoneNo.Text = employee.PhoneNo.ToString();
            cbDepartman.Text = employee.Departman.ToString();
            cbGender.Text = employee.Gender.ToString();
            dateTimePicker1.Text = employee.BirthDay.ToShortDateString().ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedEmp = _db.Employees.ToList();

            selectedEmp[index].Name = txtName.Text;
            selectedEmp[index].LastName = txtLastName.Text;
            selectedEmp[index].Departman = (Departman)cbDepartman.SelectedIndex;
            selectedEmp[index].Gender = (Gender)cbGender.SelectedIndex;
            selectedEmp[index].BirthDay = Convert.ToDateTime(dateTimePicker1.Value);
            selectedEmp[index].PhoneNo = Convert.ToInt32(txtPhoneNo.Text);
            selectedEmp[index].IdentityNo = Convert.ToInt64(txtIdentityNo.Text);
            selectedEmp[index].Salary = Convert.ToDecimal(txtSalary.Text);

            _db.SaveChanges();
            dataGridView1.DataSource = EmplyeeService.GetAllEmployees();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmplyeeService.DeleteEmployee(index);
            dataGridView1.DataSource = EmplyeeService.GetAllEmployees();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog1.FileName;
                    string fileName = Path.GetFileName(selectedFilePath);

                    string destinationDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img");
                    string destinationFilePath = Path.Combine(destinationDirectory, fileName);

                    // Başka bir bilgisayarda dizin kontrolü ve oluşturma
                    if (!Directory.Exists(destinationDirectory))
                    {
                        Directory.CreateDirectory(destinationDirectory);
                    }

                    File.Copy(selectedFilePath, destinationFilePath, true);

                    using (System.Drawing.Image image = System.Drawing.Image.FromFile(destinationFilePath))
                    {
                        EmplyeeService.LoadPic(destinationFilePath, index);
                        pictureBox1.Image = (System.Drawing.Image)image.Clone();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please Enter Corectly");
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            var list = _db.Employees.ToList();
            dataGridView1.DataSource = list.Where(x => x.Name.ToLower().Contains(searchText) || x.LastName.ToLower().Contains(searchText)).Select(x => new { ID = x.Id, Name = x.Name, LastName = x.LastName, Salary = x.Salary, BirthDay = x.BirthDay, Departman = x.Departman, Gender = x.Gender, PhoneNo = x.PhoneNo, IdentityNo = x.IdentityNo }).ToList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF dosyaları|*.pdf";
            saveFileDialog.Title = "PDF Olarak Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                doc.Open();


                PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
                }
                table.HeaderRows = 1;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int k = 0; k < dataGridView1.Columns.Count; k++)
                    {
                        if (dataGridView1[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                        }
                    }
                }

                doc.Add(table);
                doc.Close();
            }
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);

        }
    }
}

