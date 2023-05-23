using System.Drawing;
using System.Windows.Forms;

namespace artikyap
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button = new Button();
            ogrenciNotu = new GroupBox();
            txtTotal = new Label();
            txtAvg = new Label();
            txtGrade = new Label();
            description = new Label();
            science = new Label();
            english = new Label();
            Maths = new Label();
            studentName = new Label();
            txtStudentName = new TextBox();
            txtEnglish = new TextBox();
            txtMaths = new TextBox();
            txtScience = new TextBox();
            ogrenciNotu.SuspendLayout();
            SuspendLayout();
            // 
            // Button
            // 
            Button.Location = new Point(214, 375);
            Button.Name = "Button";
            Button.Size = new Size(299, 55);
            Button.TabIndex = 3;
            Button.Text = "Calc";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click_1;
            // 
            // ogrenciNotu
            // 
            ogrenciNotu.Controls.Add(txtTotal);
            ogrenciNotu.Controls.Add(txtAvg);
            ogrenciNotu.Controls.Add(txtGrade);
            ogrenciNotu.Controls.Add(description);
            ogrenciNotu.Controls.Add(science);
            ogrenciNotu.Controls.Add(english);
            ogrenciNotu.Controls.Add(Maths);
            ogrenciNotu.Controls.Add(studentName);
            ogrenciNotu.Controls.Add(txtStudentName);
            ogrenciNotu.Controls.Add(txtEnglish);
            ogrenciNotu.Controls.Add(txtMaths);
            ogrenciNotu.Controls.Add(txtScience);
            ogrenciNotu.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            ogrenciNotu.Location = new Point(25, 32);
            ogrenciNotu.Name = "ogrenciNotu";
            ogrenciNotu.Size = new Size(734, 321);
            ogrenciNotu.TabIndex = 4;
            ogrenciNotu.TabStop = false;
            ogrenciNotu.Text = "Ogrenci Notu";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(337, 284);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(0, 39);
            txtTotal.TabIndex = 41;
            // 
            // txtAvg
            // 
            txtAvg.AutoSize = true;
            txtAvg.Location = new Point(337, 335);
            txtAvg.Name = "txtAvg";
            txtAvg.Size = new Size(0, 39);
            txtAvg.TabIndex = 40;
            // 
            // txtGrade
            // 
            txtGrade.AutoSize = true;
            txtGrade.Location = new Point(337, 401);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(0, 39);
            txtGrade.TabIndex = 39;
            // 
            // description
            // 
            description.AutoSize = true;
            description.Location = new Point(10, 493);
            description.Name = "description";
            description.Size = new Size(0, 39);
            description.TabIndex = 38;
            // 
            // science
            // 
            science.AutoSize = true;
            science.Location = new Point(43, 174);
            science.Name = "science";
            science.Size = new Size(146, 39);
            science.TabIndex = 33;
            science.Text = "Science";
            science.Click += science_Click;
            // 
            // english
            // 
            english.AutoSize = true;
            english.Location = new Point(43, 232);
            english.Name = "english";
            english.Size = new Size(137, 39);
            english.TabIndex = 32;
            english.Text = "English";
            // 
            // Maths
            // 
            Maths.AutoSize = true;
            Maths.Location = new Point(43, 114);
            Maths.Name = "Maths";
            Maths.Size = new Size(114, 39);
            Maths.TabIndex = 31;
            Maths.Text = "Maths";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Location = new Point(43, 57);
            studentName.Name = "studentName";
            studentName.Size = new Size(246, 39);
            studentName.TabIndex = 30;
            studentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(337, 51);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(351, 45);
            txtStudentName.TabIndex = 29;
            txtStudentName.TabStop = false;
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(337, 232);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(351, 45);
            txtEnglish.TabIndex = 25;
            txtEnglish.TabStop = false;
            // 
            // txtMaths
            // 
            txtMaths.Location = new Point(337, 111);
            txtMaths.Name = "txtMaths";
            txtMaths.Size = new Size(351, 45);
            txtMaths.TabIndex = 24;
            txtMaths.TabStop = false;
            // 
            // txtScience
            // 
            txtScience.Location = new Point(337, 168);
            txtScience.Name = "txtScience";
            txtScience.Size = new Size(351, 45);
            txtScience.TabIndex = 37;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 500);
            Controls.Add(ogrenciNotu);
            Controls.Add(Button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            ogrenciNotu.ResumeLayout(false);
            ogrenciNotu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ogrenciAdı;
        private Button Button;
        private TextBox ogrenciAdi;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox ogrenciNotu;
        private Label description;
        private Label science;
        private Label english;
        private Label Maths;
        private Label studentName;
        private TextBox txtStudentName;
        private TextBox txtEnglish;
        private TextBox txtMaths;
        private TextBox txtScience;
        private Label txtGrade;
        private Label txtTotal;
        private Label txtAvg;
    }
}