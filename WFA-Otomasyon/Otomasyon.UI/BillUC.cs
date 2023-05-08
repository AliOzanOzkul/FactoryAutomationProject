using iTextSharp.text;
using iTextSharp.text.pdf;
using Otomasyon.BLL.Services;
using Otomasyon.Model.Context;

namespace Otomasyon.UI
{
    public partial class BillUC : UserControl
    {
        OtomasyonContext _db = new OtomasyonContext();
        public BillUC()
        {
            InitializeComponent();
        }
        int index;

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
                Paragraph title = new Paragraph("WEEKLY");
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                dataGridView1.DataSource = ExpensesServices.GetExpensesWeek();

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
                dataGridView1.DataSource = ExpensesServices.GetExpensesMon();
                Paragraph title2 = new Paragraph("MONTHLY");
                title2.Alignment = Element.ALIGN_CENTER;
                doc.Add(title2);


                table = new PdfPTable(dataGridView1.Columns.Count);
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
                dataGridView1.DataSource = ExpensesServices.GetExpensesYear();
                Paragraph title3 = new Paragraph("YEARLY");
                title3.Alignment = Element.ALIGN_CENTER;
                doc.Add(title3);


                table = new PdfPTable(dataGridView1.Columns.Count);

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

        private void BillUC_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ExpensesServices.GetExpenses().Select(x => new { x.DateTime, x.Name, x.Bill }).ToList();
            lblTotal.Text = ExpensesServices.GetTotalExpense().ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            var list = _db.Expenses.ToList();
            dataGridView1.DataSource = list.Where(x => x.DateTime.ToString().Contains(searchText) || x.Name.ToString().Contains(searchText)).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            var billList = _db.Expenses.ToList();
            if (billList[index].Name == "Salary")
            {
                txtSalary.Text = billList[index].Bill.ToString();
                txtClean.Text = "0";
                txtElec.Text = "0";
                txtGas.Text = "0";
                txtIndernet.Text = "0";
                txtLaunch.Text = "0";
                txtRent.Text = "0";
                txtSearch.Text = "0";
                txtWater.Text = "0";

            }
            else if (billList[index].Name == "Clean")
            {
                txtSalary.Text = "0";
                txtClean.Text = billList[index].Bill.ToString();
                txtElec.Text = "0";
                txtGas.Text = "0";
                txtIndernet.Text = "0";
                txtLaunch.Text = "0";
                txtRent.Text = "0";
                txtSearch.Text = "0";
                txtWater.Text = "0";
            }
            else if (billList[index].Name == "Electricity")
            {
                txtSalary.Text = "0";
                txtClean.Text = "0";
                txtElec.Text = billList[index].Bill.ToString();
                txtGas.Text = "0";
                txtIndernet.Text = "0";
                txtLaunch.Text = "0";
                txtRent.Text = "0";
                txtSearch.Text = "0";
                txtWater.Text = "0";
            }
            else if (billList[index].Name == "Gas")
            {
                txtSalary.Text = "0";
                txtClean.Text = "0";
                txtElec.Text = "0";
                txtGas.Text = billList[index].Bill.ToString();
                txtIndernet.Text = "0";
                txtLaunch.Text = "0";
                txtRent.Text = "0";
                txtSearch.Text = "0";
                txtWater.Text = "0";
            }
            else if (billList[index].Name == "Internet")
            {
                txtSalary.Text = "0";
                txtClean.Text = "0";
                txtElec.Text = "0";
                txtGas.Text = "0";
                txtIndernet.Text = billList[index].Bill.ToString();
                txtLaunch.Text = "0";
                txtRent.Text = "0";
                txtSearch.Text = "0";
                txtWater.Text = "0";
            }
            else if (billList[index].Name == "Launch")
            {
                txtSalary.Text = "0";
                txtClean.Text = "0";
                txtElec.Text = "0";
                txtGas.Text = "0";
                txtIndernet.Text = "0";
                txtLaunch.Text = billList[index].Bill.ToString();
                txtRent.Text = "0";
                txtSearch.Text = "0";
                txtWater.Text = "0";
            }
            else if (billList[index].Name == "Rent")
            {
                txtSalary.Text = "0";
                txtClean.Text = "0";
                txtElec.Text = "0";
                txtGas.Text = "0";
                txtIndernet.Text = "0";
                txtLaunch.Text = "0";
                txtRent.Text = billList[index].Bill.ToString();
                txtSearch.Text = "0";
                txtWater.Text = "0";
            }
            else if (billList[index].Name == "Search")
            {
                txtSalary.Text = "0";
                txtClean.Text = "0";
                txtElec.Text = "0";
                txtGas.Text = "0";
                txtIndernet.Text = "0";
                txtLaunch.Text = "0";
                txtRent.Text = "0";
                txtSearch.Text = billList[index].Bill.ToString();
                txtWater.Text = "0";
            }
            else if (billList[index].Name == "Water")
            {
                txtSalary.Text = "0";
                txtClean.Text = "0";
                txtElec.Text = "0";
                txtGas.Text = "0";
                txtIndernet.Text = "0";
                txtLaunch.Text = "0";
                txtRent.Text = "0";
                txtSearch.Text = "0";
                txtWater.Text = billList[index].Bill.ToString();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var billList = _db.Expenses.ToList();
            if (billList[index].Name == "Salary")
            {
                billList[index].Bill = Convert.ToDecimal(txtSalary.Text);
                _db.SaveChanges();



            }
            else if (billList[index].Name == "Clean")
            {

                billList[index].Bill = Convert.ToDecimal(txtClean.Text);
                _db.SaveChanges();


            }
            else if (billList[index].Name == "Electricity")
            {

                billList[index].Bill = Convert.ToDecimal(txtElec.Text);
                _db.SaveChanges();


            }
            else if (billList[index].Name == "Gas")
            {
                billList[index].Bill = Convert.ToDecimal(txtGas.Text);
                _db.SaveChanges();


            }
            else if (billList[index].Name == "Internet")
            {

                billList[index].Bill = Convert.ToDecimal(txtIndernet.Text);
                _db.SaveChanges();


            }
            else if (billList[index].Name == "Launch")
            {


                billList[index].Bill = Convert.ToDecimal(txtLaunch.Text);
                _db.SaveChanges();


            }
            else if (billList[index].Name == "Rent")
            {

                billList[index].Bill = Convert.ToDecimal(txtRent.Text);
                _db.SaveChanges();


            }
            else if (billList[index].Name == "Search")
            {

                billList[index].Bill = Convert.ToDecimal(txtSearch.Text);
                _db.SaveChanges();


            }
            else if (billList[index].Name == "Water")
            {

                billList[index].Bill = Convert.ToDecimal(txtWater.Text);
                _db.SaveChanges();
            }
            dataGridView1.DataSource = ExpensesServices.GetExpenses().Select(x => new { x.DateTime, x.Name, x.Bill }).ToList();
        }
    }
}
