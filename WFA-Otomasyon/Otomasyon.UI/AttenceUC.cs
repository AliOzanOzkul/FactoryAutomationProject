using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore;
using Otomasyon.Model.Context;
using System.Data;

namespace Otomasyon.UI
{
    public partial class AttenceUC : UserControl
    {
        OtomasyonContext _db = new OtomasyonContext();


        public AttenceUC()
        {
            InitializeComponent();
        }

        private void AttenceUC_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Attentions.Include(x => x.Employee).Where(x => x.Employee.Id == LoginForm.user.Id).Select(x => new { EmplpyeeID = x.Employee.Id, ActiveDate = x.Start, Name = x.Employee.Name, Surname = x.Employee.LastName, ActiveTime = (x.End - x.Start) }).ToList();

            if (LoginForm.user.Role != "A")
            {
                pnlButton.Controls.Clear();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            var list = _db.Attentions.Include(x => x.Employee).Where(x => x.Employee.Id == LoginForm.user.Id).ToList();
            dataGridView1.DataSource = list.Where(x => x.Employee.Name.ToLower().Contains(searchText) || x.Employee.LastName.ToLower().Contains(searchText)).Select(x => new { EmplpyeeID = x.Employee.Id, ActiveDate = x.Start, Name = x.Employee.Name, Surname = x.Employee.LastName, ActiveTime = (x.End - x.Start) }).ToList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (LoginForm.user.Role == "A")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF dosyaları|*.pdf";
                saveFileDialog.Title = "PDF Olarak Kaydet";

                dataGridView1.DataSource = _db.Attentions.Include(x => x.Employee).Select(x => new { EmplpyeeID = x.Employee.Id, ActiveDate = x.Start, Name = x.Employee.Name, Surname = x.Employee.LastName, ActiveTime = (x.End - x.Start) }).ToList();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (Document doc = new Document())
                    {
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
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
                    }

                    MessageBox.Show("PDF dosyası başarıyla kaydedildi.");


                    //dataGridView1.DataSource = _db.Attentions.Include(x => x.Employee).Where(x => x.Employee.Id == LoginForm.user.Id).Select(x => new { EmplpyeeID = x.Employee.Id, ActiveDate = x.Start, Name = x.Employee.Name, Surname = x.Employee.LastName, ActiveTime = (x.End - x.Start) }).ToList();
                }
            }
        }
    }
}
