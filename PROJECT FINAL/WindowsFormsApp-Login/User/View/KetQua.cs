using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.Controller;
using WindowsFormsApp_Login.User.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace WindowsFormsApp_Login.User.View
{
    public partial class KetQua : Form
    {
        private int id_User;
        private ExamModify examModify;
        Modify modify = new Modify();   
        public KetQua(int id_User)
        {
            InitializeComponent();
            this.id_User = id_User;
            this.examModify = new ExamModify();
            DisplayHistoryTests();

            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            string querry = "SELECT * FROM Users WHERE Id_User = '" + id_User + "'";
            taiKhoans = modify.TaiKhoans(querry);
            FullName.Text = taiKhoans[0].Fullname;

        }
        private void DisplayHistoryTests()
        {
            
            List<History> historyTests = examModify.GetHistoryTests(id_User);         
            if (historyTests.Count > 0)
            {
                KetQuaTable.Rows.Clear();

                // Duyệt qua từng kết quả và thêm vào DataGridView
                for (int i = 0; i < historyTests.Count; i++)
                {
                    History historyTest = historyTests[i];
                    string[] row = new string[]
                    {
                (i + 1).ToString(),
                historyTest.Id.ToString(),
                historyTest.Id_user.ToString(),
                historyTest.Id_exam.ToString(),
                historyTest.NameExam,
                historyTest.NumberExam.ToString(),
                historyTest.TotalPoint.ToString(),
                historyTest.Time_Completed.ToString(),
                historyTest.Date_Time.ToString(),
                historyTest.Result
                    };

                    
                    KetQuaTable.Rows.Add(row);
                }
            }
            
        }
        private void ketQua_Click(object sender, EventArgs e)
        {
            this.Hide();
            KetQua ketQua = new KetQua(id_User);
            ketQua.ShowDialog();
            this.Close();
        }

        private void vaoThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_User);
            chooseExam.ShowDialog();
            this.Close();
        }

        private void KetQua_Load(object sender, EventArgs e)
        {
            List<Subject> subjects = examModify.GetSubjectNames();
            foreach (Subject subject in subjects)
            {
                MonHocOption.Items.Add(subject.NameExam);
            }

        }

        private void DisplayHistoryTests(List<History> historyTests)
        {       
            KetQuaTable.Rows.Clear();
            if (historyTests.Count > 0)
            {
                // Duyệt qua từng kết quả và thêm vào DataGridView
                for (int i = 0; i < historyTests.Count; i++)
                {
                    History historyTest = historyTests[i];
                    string[] row = new string[]
                    {
                (i + 1).ToString(), // Thêm STT vào hàng
                historyTest.Id.ToString(),
                historyTest.Id_user.ToString(),
                historyTest.Id_exam.ToString(),
                historyTest.NameExam,
                historyTest.NumberExam.ToString(),
                historyTest.TotalPoint.ToString(),
                historyTest.Time_Completed.ToString(),
                historyTest.Date_Time.ToString(),
                historyTest.Result
                    };

                    KetQuaTable.Rows.Add(row);
                }
            }
            else
            {
               
                MessageBox.Show("Không có kết quả nào cho môn học này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void rjButton2_Click(object sender, EventArgs e)
        {

            if (MonHocOption.SelectedIndex != -1)
            {
                
                string monHoc = MonHocOption.SelectedItem.ToString();              
                List<History> historyTests = examModify.GetHistoryTestBySubject(id_User, monHoc);
                DisplayHistoryTests(historyTests);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn môn học.");
            }

        }

        private void xepHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            BXH bXH = new BXH(id_User);
            bXH.ShowDialog();
            this.Close();
        }

        private void trangChu_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeUser homeUser = new HomeUser(id_User);
            homeUser.ShowDialog();
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            rjDropdownMenu1.Show(FullName, -1 / 2 * FullName.Width, FullName.Height);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void thayĐổiThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            InforUser inforUser = new InforUser(id_User);
            inforUser.ShowDialog();
            this.Close();
        }
        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(id_User);
            changePassword.ShowDialog();
            this.Close();
        }
        private void vàoThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChooseExam chooseExam = new ChooseExam(id_User);
            chooseExam.ShowDialog();
            this.Close();
        }

        private void MonHocOption_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void ExportToPDF()
        {
            DateTime currentTime = DateTime.Now;

            Document doc = new Document(PageSize.A4);

            try
            {

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveDialog.FileName = "";


                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveDialog.FileName;

                    PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                    doc.Open();

                    BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\times.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 11);
                    iTextSharp.text.Font boldFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font italicFont = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.ITALIC);
                    iTextSharp.text.Font boldBig = new iTextSharp.text.Font(bf, 15, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontNonal = new iTextSharp.text.Font(bf, 12);
                    iTextSharp.text.Font boldFont1 = new iTextSharp.text.Font(bf, 13, iTextSharp.text.Font.BOLD);
                    PdfPTable table = new PdfPTable(2);
                    table.WidthPercentage = 120;

                    Phrase leftPhrase = new Phrase();
                    leftPhrase.Add(new Phrase("BỘ XÂY DỰNG\n", fontNonal));
                    leftPhrase.Add(new Phrase("TRƯỜNG ĐH KIẾN TRÚC HÀ NỘI\n", boldFont));
                    leftPhrase.Add(new Phrase("-------------------", fontNonal));
                    leftPhrase.Add(new Phrase("\nKHOA CÔNG NGHỆ THÔNG TIN", boldFont));
                    PdfPCell leftCell = new PdfPCell(leftPhrase);
                    leftCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    leftCell.Border = PdfPCell.NO_BORDER;
                    table.AddCell(leftCell);

                    Phrase rightPhrase = new Phrase();
                    rightPhrase.Add(new Phrase("CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM\n", boldFont));
                    rightPhrase.Add(new Phrase("Độc lập - Tự do - Hạnh phúc\n", boldFont));
                    rightPhrase.Add(new Phrase("------------------", fontNonal));
                    rightPhrase.Add(new Phrase("\nHà Nội, " + "ngày " + currentTime.Day + " tháng " + currentTime.Month + " năm " + currentTime.Year, italicFont));
                    PdfPCell rightCell = new PdfPCell(rightPhrase);
                    rightCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    rightCell.Border = PdfPCell.NO_BORDER;
                    table.AddCell(rightCell);
                    doc.Add(table);

                    Paragraph paragraph4 = new Paragraph("\nBÁO CÁO KẾT QUẢ\n", boldBig);
                    paragraph4.Alignment = Element.ALIGN_CENTER;
                    doc.Add(paragraph4);

                    Paragraph paragraph5 = new Paragraph("Số lượng đề và số lượt làm bài thi\n năm học 2023 - 2024\n", boldFont);
                    paragraph5.Alignment = Element.ALIGN_CENTER;
                    doc.Add(paragraph5);

                    Paragraph paragraph6 = new Paragraph("------------\n", fontNonal);
                    paragraph6.Alignment = Element.ALIGN_CENTER;
                    doc.Add(paragraph6);

                    Paragraph paragraph7 = new Paragraph("Sinh viên: " + FullName.Text + "\n\n", font);
                    paragraph7.Alignment = Element.ALIGN_RIGHT;
                    doc.Add(paragraph7);

                    Paragraph paragraph8 = new Paragraph("BẢNG KẾT QUẢ THI THỬ\n\n", boldFont1);
                    paragraph8.Alignment = Element.ALIGN_CENTER;
                    doc.Add(paragraph8);

                    PdfPTable pdfTable = new PdfPTable(7);
                    pdfTable.SetWidths(new float[] { 30, 175, 50, 50, 75, 150, 75 });
                    pdfTable.WidthPercentage = 100;
                    pdfTable.AddCell(new PdfPCell(new Phrase(KetQuaTable.Columns[0].HeaderText, font)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_TOP }); // Cột 0
                    pdfTable.AddCell(new PdfPCell(new Phrase(KetQuaTable.Columns[4].HeaderText, font)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_TOP }); // Cột 4
                    pdfTable.AddCell(new PdfPCell(new Phrase(KetQuaTable.Columns[5].HeaderText, font)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_TOP }); // Cột 5
                    pdfTable.AddCell(new PdfPCell(new Phrase(KetQuaTable.Columns[6].HeaderText, font)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_TOP }); // Cột 6
                    pdfTable.AddCell(new PdfPCell(new Phrase(KetQuaTable.Columns[7].HeaderText, font)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_TOP }); // Cột 7
                    pdfTable.AddCell(new PdfPCell(new Phrase(KetQuaTable.Columns[8].HeaderText, font)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_TOP }); // Cột 8
                    pdfTable.AddCell(new PdfPCell(new Phrase(KetQuaTable.Columns[9].HeaderText, font)) { HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_TOP }); // Cột 9

                    for (int row = 0; row < KetQuaTable.Rows.Count; row++)
                    {
                        DataGridViewRow dataGridViewRow = KetQuaTable.Rows[row];
                        

                        for (int cell = 0; cell < 10; cell++) // Lặp qua 10 cột
                        {

                            if (cell == 0 || cell == 4 || (cell >= 5 && cell <= 9))
                            {

                                PdfPCell pdfCell = new PdfPCell();
                                if (dataGridViewRow.Cells[cell].Value != null)
                                {
                                    pdfCell.AddElement(new Phrase(dataGridViewRow.Cells[cell].Value.ToString(), font));
                                    
                                }
                                else
                                {
                                    pdfCell.AddElement(new Phrase(""));
                                }
                                pdfCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;


                                pdfTable.AddCell(pdfCell);
                            }
                        }
                    }



                    doc.Add(pdfTable);
                    Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

      
        private void XuatFile_Click(object sender, EventArgs e)
        {
            ExportToPDF();
        }
    }
}
