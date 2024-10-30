
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

using WindowsFormsApp_Login.User.Model;
using WindowsFormsApp_Login.User.Controller; //the WinForm wrappers
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class FormThongKe : UserControl
    {
        List<Subject> subjects = new List<Subject>();
        List<Exam> exams = new List<Exam>();
        List<History> history = new List<History>();
        List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
        public FormThongKe()
        {
            InitializeComponent();

            ExamModify examModify = new ExamModify();
            Modify modify = new Modify();
            string querry = "SELECT * FROM list_subject";
            subjects = examModify.Subjects(querry);

            querry = "SELECT * FROM list_exam";
            exams = examModify.GetExams(querry);

            querry = "SELECT * FROM history_test";
            history = examModify.histories(querry);

            List<string> monHocList = new List<string>();
            for (int i = 0; i < subjects.Count; i++)
            {
                monHocList.Add(subjects[i].NameExam);
            }

            List<int> soDeThi = new List<int>();
            for (int i = 0; i < monHocList.Count; i++)
            {
                int d = 0;
                for (int j = 0; j < exams.Count; j++)
                {
                    if (exams[j].Name_exam == monHocList[i])
                    {
                        d++;
                    }
                }
                soDeThi.Add(d);
            }
            int tongSoDeThi = 0;
            for (int i = 0; i < soDeThi.Count; i++)
            {
                tongSoDeThi = tongSoDeThi + soDeThi[i];
            }
            soDeThiTxt.Text = tongSoDeThi.ToString();

            List<int> soLuotThi = new List<int>();
            for (int i = 0; i < monHocList.Count; i++)
            {
                int d = 0;
                for (int j = 0; j < history.Count; j++)
                {
                    if (history[j].NameExam == monHocList[i])
                    {
                        d++;
                    }
                }
                soLuotThi.Add(d);
            }

            int tongSoLuotThi = 0;
            for (int i = 0; i < soLuotThi.Count; i++)
            {
                tongSoLuotThi = tongSoLuotThi + soLuotThi[i];
            }
            soLuotThiTxt.Text = tongSoLuotThi.ToString();


            querry = "SELECT * FROM Users";
            taiKhoans = modify.TaiKhoans(querry);
            int tongSoNguoiDung = 0;
            for (int i = 0; i < taiKhoans.Count; i++)
            {
                tongSoDeThi++;
            }
            soNguoiDungTxt.Text = tongSoDeThi.ToString();
            // Thêm dữ liệu vào biểu đồ
            for(int i = 0; i< subjects.Count; i++) {
                chart1.Series["Số đề thi"].Points.AddXY(subjects[i].NameExam, soDeThi[i]);
            }
            for( int i = 0;i < subjects.Count; i++)
            {
                chart1.Series["Số lượt thi"].Points.AddXY(subjects[i].NameExam, soLuotThi[i]);
            }    

        }
        private void ExportChartToPdf(Chart chart)
        {
            string filePath;
            DateTime currentTime = DateTime.Now;

            Document document = new Document(PageSize.A4);

            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveDialog.FileName = "";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveDialog.FileName;
                    PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                    document.Open();
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

                    document.Add(table);

                    Paragraph paragraph4 = new Paragraph("\nTHỐNG KÊ\n", boldBig);
                    paragraph4.Alignment = Element.ALIGN_CENTER;
                    document.Add(paragraph4);

                    Paragraph paragraph5 = new Paragraph("Số lượng đề và số lượt làm bài thi\n năm học 2023 - 2024\n", boldFont);
                    paragraph5.Alignment = Element.ALIGN_CENTER;
                    document.Add(paragraph5);

                    Paragraph paragraph6 = new Paragraph("------------\n", fontNonal);
                    paragraph6.Alignment = Element.ALIGN_CENTER;
                    document.Add(paragraph6);

                    Paragraph soDeThiParagraph = new Paragraph("Số đề thi: " + soDeThiTxt.Text, boldFont);
                    soDeThiParagraph.Alignment = Element.ALIGN_LEFT;
                    document.Add(soDeThiParagraph);


                    Paragraph soLuotThiParagraph = new Paragraph("Số lượt thi: " + soLuotThiTxt.Text, boldFont);
                    soLuotThiParagraph.Alignment = Element.ALIGN_LEFT;
                    document.Add(soLuotThiParagraph);


                    Paragraph soNguoiDungParagraph = new Paragraph("Số người dùng: " + soNguoiDungTxt.Text, boldFont);
                    soNguoiDungParagraph.Alignment = Element.ALIGN_LEFT;
                    document.Add(soNguoiDungParagraph);

                    Paragraph paragraph7 = new Paragraph("\nBIỂU ĐỒ BIỂU DIỄN SỐ ĐỀ THI VÀ SỐ LƯỢT THI CỦA TỪNG MÔN",boldFont1);
                    paragraph7.Alignment = Element.ALIGN_CENTER;
                    document.Add(paragraph7);

                    Bitmap bmp = new Bitmap(chart.Width, chart.Height);
                    chart.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));


                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bmp, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScalePercent(72f);
                    document.Add(img);

                    Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                
                document.Close();
            }
        }
        private void FormThongKe_Load(object sender, EventArgs e)
        {

        }

        private void XuatFile_Click(object sender, EventArgs e)
        {
            Chart Chart = chart1;
            ExportChartToPdf(Chart);
        }
    }
}
