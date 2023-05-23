using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using File = System.IO.File;

namespace artikyap
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            addStudent.Click += addStudent_Click;

            string jsonFilePath = Globals.JsonFilePath;
            string jsonString = File.ReadAllText(jsonFilePath);
            List<Student> studentList = JsonSerializer.Deserialize<List<Student>>(jsonString);

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeight = 30;

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = studentList;
            refresh_Click(this, EventArgs.Empty);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SortByAverage()
        {
            List<Student> studentList = dataGridView1.DataSource as List<Student>;

            if (studentList != null && studentList.Count > 0)
            {
                studentList = studentList.OrderByDescending(s => s.Average).ToList();
                dataGridView1.DataSource = studentList;
            }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        public static class Globals
        {
            public static string JsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "student.json");
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

        private void refresh_Click(object sender, EventArgs e)
        {
            string jsonFilePath = Globals.JsonFilePath;
            string jsonString = File.ReadAllText(jsonFilePath);
            List<Student> studentList = JsonSerializer.Deserialize<List<Student>>(jsonString);
            if (studentList != null && studentList.Count > 0)
            {
                // Öğrenci sayısını alarak txtStudentCount.Text'e ekleyin
                string studentCount = studentList.Count.ToString();
                txtStudentCount.Text = studentCount;

                // Eğer hiç öğrenci yoksa varsayılan olarak 0 olarak ayarlayın
                if (studentList.Count == 0)
                {
                    txtStudentCount.Text = "0";
                }
            }

            dataGridView1.DataSource = studentList;
            SortByAverage();
            // 'Average' alanının ortalamasını alarak txtClassAvg.Text'e ekleyin
            if ( studentList.Count > 0)
            {
                double classAverage = studentList.Average(s => s.Average);
                // student.json dosyasinda Average diye bir sey bulamadigi icin hata aliyorsun. bu kodla beraber eger dosyada hic oge yok ise 0 gosterecek
                // egere liste count 0 dan buyuk ise de buradaki kodlar calisacak deneyelim. neyse geri kalani sende grs
                txtClassAvg.Text = classAverage.ToString("0.00");
                int failedStudentCount = studentList.Count(s => s.Grade == "F");
                txtFailedStudent.Text = failedStudentCount.ToString();
            } else
            {
                txtClassAvg.Text = "0";
                txtFailedStudent.Text = "0";
            } 
            

            // 'Grade' i 'F' olan öğrencilerin sayısını alarak txtFailedStudent.Text'e ekleyin
            
        }


        private void delete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                string jsonFilePath = Globals.JsonFilePath;
                string jsonString = File.ReadAllText(jsonFilePath);
                List<Student> studentList = JsonSerializer.Deserialize<List<Student>>(jsonString);

                studentList.RemoveAt(selectedIndex);

                string updatedJsonString = JsonSerializer.Serialize(studentList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(jsonFilePath, updatedJsonString);
            }

            refresh_Click(sender, e);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
        refresh_Click(sender, e);
        }
    }
   

}


