using System;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections.Generic;

namespace artikyap
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Globals.JsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "student.json");

        }
        public static class Globals
        {
            public static string JsonFilePath { get; set; }
        }
        private List<Student> students = new List<Student>();

        private void Button_Click_1(object sender, EventArgs e)
        {
            double maths, english, science, total, avg;
            string grade, des;

            if (!double.TryParse(txtMaths.Text, out maths) ||
                !double.TryParse(txtEnglish.Text, out english) ||
                !double.TryParse(txtScience.Text, out science))
            {
                // Hata durumunu işle
                MessageBox.Show("Geçerli sayısal değerler girin.");
                return;
            }

            maths = Math.Max(0, Math.Min(100, maths));
            english = Math.Max(0, Math.Min(100, english));
            science = Math.Max(0, Math.Min(100, science));


            total = maths + english + science;
            txtTotal.Text = total.ToString();

            avg = total / 3;
            txtAvg.Text = avg.ToString("0.00");

            if (avg >= 75)
            {
                grade = "A";
                des = $"Merhaba {txtStudentName.Text} Notun Süper..";
            }
            else if (avg >= 65)
            {
                grade = "B";
                des = $"Merhaba {txtStudentName.Text} Notun İyi..";
            }
            else if (avg >= 55)
            {
                grade = "C";
                des = $"Merhaba {txtStudentName.Text} Notun İdare Eder..";
            }
            else if (avg >= 45)
            {
                grade = "D";
                des = $"Merhaba {txtStudentName.Text} Notun Kötü..";
            }
            else
            {
                grade = "F";
                des = $"Merhaba {txtStudentName.Text} Malesef Kaldın..";
            }

            description.Text = des;
            txtGrade.Text = grade;

            // Yeni öğrenci oluştur
            var student = new Student()
            {
                Name = txtStudentName.Text,
                Maths = maths,
                English = english,
                Science = science,
                Total = total,
                Average = avg,
                Grade = grade,
                Description = des
            };

            // Koleksiyona ekle
            students.Add(student);

            // Alanları temizle
            txtStudentName.Text = "";
            txtMaths.Text = "";
            txtEnglish.Text = "";
            txtScience.Text = "";
            txtTotal.Text = "";
            txtAvg.Text = "";
            description.Text = "";
            txtGrade.Text = "";

            MessageBox.Show("Kullanıcı bilgileri başarıyla kaydedildi.");
            try
            {
                string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "student.json");
                List<Student> students = new List<Student>();

                if (File.Exists(jsonFilePath))
                {
                    string existingData = File.ReadAllText(jsonFilePath);
                    students = JsonSerializer.Deserialize<List<Student>>(existingData);
                }

                students.Add(student);
                string jsonData = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(jsonFilePath, jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("JSON dosyası kaydedilirken bir hata oluştu: " + ex.Message);
            }

        }

        public class Student
        {
            public string Name { get; set; }
            public double Maths { get; set; }
            public double English { get; set; }
            public double Science { get; set; }
            public double Total { get; set; }
            public double Average { get; set; }
            public string Grade { get; set; }
            public string Description { get; set; }


        }

        private void science_Click(object sender, EventArgs e)
        {

        }
    }
}
