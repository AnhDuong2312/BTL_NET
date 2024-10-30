using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Login.User.Controller;
using WindowsFormsApp_Login.User.Model;

namespace WindowsFormsApp_Login.Admin.View
{
    public partial class AddOption : Form
    {
        int id_ex;
        string name_ex;
        int number_ex;
        int soCau;
        int time_ex;
        List<Exam> exams = new List<Exam>();
        public AddOption(int id, string s, int a, int b, int c)
        {
            InitializeComponent();
            name_ex = s;
            number_ex = a;
            soCau = b;
            time_ex = c;
        }

        private void btn_thucong_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuestion aq = new AddQuestion( name_ex, number_ex, soCau, time_ex);
            aq.ShowDialog();
            this.Close();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "File csv (*.csv)|*.csv";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                try
                {
                    int rowCount = CountRows(selectedFile);
                    Console.WriteLine(rowCount + ";" + soCau);

                    if (rowCount - 1 == soCau)
                    {
                        Exam exm = new Exam(name_ex, number_ex, soCau, time_ex);
                        ExamModify.InsertExam(exm);

                        ExamModify examModify = new ExamModify();


                        string query = "SELECT * FROM list_exam ";
                        exams = examModify.GetExams(query);

                        id_ex = exams[exams.Count - 1].Id_exam;

                        ImportExcel(selectedFile);
                        this.Hide();
                        EditImport editForm = new EditImport(id_ex, name_ex, number_ex, soCau, time_ex);
                        editForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Số hàng trong file không đúng quy định (" + soCau + " hàng)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        public void ImportExcel(string filePath)
        {
            using (StreamReader lineReader = new StreamReader(filePath))
            {
                lineReader.ReadLine(); 
                string lineText;
                while ((lineText = lineReader.ReadLine()) != null)
                {
                    string[] data = lineText.Split(';');
                    Question q = new Question(id_ex, data[0], data[1], data[2], data[3], data[4], int.Parse(data[5]), int.Parse(data[6]));
                    ExamModify.InsertQuestion(q);
                }
            }
        }
        int CountRows(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                int rowCount = 0;
                while (reader.ReadLine() != null)
                {
                    rowCount++;
                }
                return rowCount;
            }
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
