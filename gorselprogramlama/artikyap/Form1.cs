namespace artikyap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, EventArgs e)
        {

            double maths, english, science, total, avg;
            string grade, des;

            maths = int.Parse(txtMaths.Text);
            english = int.Parse(txtEnglish.Text);
            science = int.Parse(txtScience.Text);

            total = maths + english + science;
            txtTotal.Text = total.ToString();

            avg = total / 3;
            txtAvg.Text = avg.ToString("0.00");

            if (avg >= 75)
            {
                grade = "A";
                des = $"Merhaba {txtStudentName.Text} Notun Super..";
            }
            else if (avg >= 65)
            {
                grade = "B";
                des = $"Merhaba {txtStudentName.Text} Notun Iyi..";
            }
            else if (avg >= 55)
            {
                grade = "C";
                des = $"Merhaba {txtStudentName.Text} Notun Idare Eder..";
            }
            else if (avg >= 45)
            {
                grade = "D";
                des = $"Merhaba {txtStudentName.Text} Notun Kotu..";
            }
            else
            {
                grade = "F";
                des = $"Merhaba {txtStudentName.Text} Malesef Kaldin..";
            }
            description.Text = des.ToString();
            txtGrade.Text = grade.ToString();
            //zahahahahahah
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}