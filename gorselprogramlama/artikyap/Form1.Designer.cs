namespace artikyap
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ogrenciAdi = new TextBox();
            Button = new Button();
            txtMaths = new TextBox();
            ogrenciNotu = new GroupBox();
            grade = new Label();
            avg = new Label();
            total = new Label();
            science = new Label();
            english = new Label();
            Maths = new Label();
            studentName = new Label();
            txtStudentName = new TextBox();
            txtGrade = new TextBox();
            txtAvg = new TextBox();
            txtTotal = new TextBox();
            txtEnglish = new TextBox();
            txtScience = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            description = new Label();
            ogrenciNotu.SuspendLayout();
            SuspendLayout();
            // 
            // ogrenciAdi
            // 
            ogrenciAdi.Location = new Point(0, 0);
            ogrenciAdi.Name = "ogrenciAdi";
            ogrenciAdi.Size = new Size(100, 27);
            ogrenciAdi.TabIndex = 0;
            // 
            // Button
            // 
            Button.Location = new Point(282, 609);
            Button.Name = "Button";
            Button.Size = new Size(299, 55);
            Button.TabIndex = 2;
            Button.Text = "Hesapla";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // txtMaths
            // 
            txtMaths.Location = new Point(465, 105);
            txtMaths.Name = "txtMaths";
            txtMaths.Size = new Size(352, 45);
            txtMaths.TabIndex = 24;
            txtMaths.TabStop = false;
            // 
            // ogrenciNotu
            // 
            ogrenciNotu.Controls.Add(description);
            ogrenciNotu.Controls.Add(grade);
            ogrenciNotu.Controls.Add(avg);
            ogrenciNotu.Controls.Add(total);
            ogrenciNotu.Controls.Add(science);
            ogrenciNotu.Controls.Add(english);
            ogrenciNotu.Controls.Add(Maths);
            ogrenciNotu.Controls.Add(studentName);
            ogrenciNotu.Controls.Add(txtStudentName);
            ogrenciNotu.Controls.Add(txtGrade);
            ogrenciNotu.Controls.Add(txtAvg);
            ogrenciNotu.Controls.Add(txtTotal);
            ogrenciNotu.Controls.Add(txtEnglish);
            ogrenciNotu.Controls.Add(txtMaths);
            ogrenciNotu.Controls.Add(txtScience);
            ogrenciNotu.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ogrenciNotu.Location = new Point(12, 26);
            ogrenciNotu.Name = "ogrenciNotu";
            ogrenciNotu.Size = new Size(867, 560);
            ogrenciNotu.TabIndex = 1;
            ogrenciNotu.TabStop = false;
            ogrenciNotu.Text = "Ogrenci Notu";
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Location = new Point(44, 403);
            grade.Name = "grade";
            grade.Size = new Size(116, 39);
            grade.TabIndex = 36;
            grade.Text = "Grade";
            // 
            // avg
            // 
            avg.AutoSize = true;
            avg.Location = new Point(44, 334);
            avg.Name = "avg";
            avg.Size = new Size(79, 39);
            avg.TabIndex = 35;
            avg.Text = "Avg";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Location = new Point(44, 283);
            total.Name = "total";
            total.Size = new Size(98, 39);
            total.TabIndex = 34;
            total.Text = "Total";
            // 
            // science
            // 
            science.AutoSize = true;
            science.Location = new Point(44, 162);
            science.Name = "science";
            science.Size = new Size(146, 39);
            science.TabIndex = 33;
            science.Text = "Science";
            // 
            // english
            // 
            english.AutoSize = true;
            english.Location = new Point(44, 226);
            english.Name = "english";
            english.Size = new Size(137, 39);
            english.TabIndex = 32;
            english.Text = "English";
            // 
            // Maths
            // 
            Maths.AutoSize = true;
            Maths.Location = new Point(44, 111);
            Maths.Name = "Maths";
            Maths.Size = new Size(114, 39);
            Maths.TabIndex = 31;
            Maths.Text = "Maths";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Location = new Point(44, 68);
            studentName.Name = "studentName";
            studentName.Size = new Size(246, 39);
            studentName.TabIndex = 30;
            studentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(465, 44);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(352, 45);
            txtStudentName.TabIndex = 29;
            txtStudentName.TabStop = false;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(465, 397);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(352, 45);
            txtGrade.TabIndex = 28;
            txtGrade.TabStop = false;
            // 
            // txtAvg
            // 
            txtAvg.Location = new Point(465, 328);
            txtAvg.Name = "txtAvg";
            txtAvg.Size = new Size(352, 45);
            txtAvg.TabIndex = 27;
            txtAvg.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(465, 277);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(352, 45);
            txtTotal.TabIndex = 26;
            txtTotal.TabStop = false;
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(465, 226);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(352, 45);
            txtEnglish.TabIndex = 25;
            txtEnglish.TabStop = false;
            // 
            // txtScience
            // 
            txtScience.Location = new Point(465, 162);
            txtScience.Name = "txtScience";
            txtScience.Size = new Size(352, 45);
            txtScience.TabIndex = 37;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(10, 495);
            description.Name = "description";
            description.Height = 39;
            description.TabIndex = 38;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 695);
            Controls.Add(ogrenciNotu);
            Controls.Add(Button);
            Name = "Form1";
            Text = "Form1";
            ogrenciNotu.ResumeLayout(false);
            ogrenciNotu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox ogrenciAdı;
        private Button Button;
        private TextBox ogrenciAdi;
        private TextBox textBox1;
        private GroupBox ogrenciNotu;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label studentName;
        private ContextMenuStrip contextMenuStrip1;
        private Label grade;
        private Label avg;
        private Label total;
        private Label science;
        private Label english;
        private Label Maths;
        private TextBox txtTurkce;
        private TextBox txtMaths;
        private TextBox txtStudentName;
        private TextBox txtGrade;
        private TextBox txtAvg;
        private TextBox txtTotal;
        private TextBox txtEnglish;
        private TextBox txtScience;
        private Label label1;
        private Label description;
    }
}