using System.Windows.Forms;

namespace artikyap
{
    partial class Form1 : Form
    {
        private DataGridView dataGridView1;
        private Button addStudent;
        private Button refresh;
        private Button delete;


        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addStudent = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.txtStudentCount = new System.Windows.Forms.TextBox();
            this.studentCount = new System.Windows.Forms.Label();
            this.classAvg = new System.Windows.Forms.Label();
            this.txtClassAvg = new System.Windows.Forms.TextBox();
            this.failedStudent = new System.Windows.Forms.Label();
            this.txtFailedStudent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 373);
            this.dataGridView1.TabIndex = 6;
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(1121, 33);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(175, 36);
            this.addStudent.TabIndex = 3;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(1121, 88);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(175, 38);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click_1);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1121, 147);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(175, 38);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // txtStudentCount
            // 
            this.txtStudentCount.Location = new System.Drawing.Point(1221, 206);
            this.txtStudentCount.Multiline = true;
            this.txtStudentCount.Name = "txtStudentCount";
            this.txtStudentCount.Size = new System.Drawing.Size(75, 30);
            this.txtStudentCount.TabIndex = 9;
            // 
            // studentCount
            // 
            this.studentCount.AutoSize = true;
            this.studentCount.Location = new System.Drawing.Point(1121, 219);
            this.studentCount.Name = "studentCount";
            this.studentCount.Size = new System.Drawing.Size(89, 16);
            this.studentCount.TabIndex = 10;
            this.studentCount.Text = "Student Count";
            // 
            // classAvg
            // 
            this.classAvg.AutoSize = true;
            this.classAvg.Location = new System.Drawing.Point(1121, 276);
            this.classAvg.Name = "classAvg";
            this.classAvg.Size = new System.Drawing.Size(68, 16);
            this.classAvg.TabIndex = 11;
            this.classAvg.Text = "Class Avg";
            // 
            // txtClassAvg
            // 
            this.txtClassAvg.Location = new System.Drawing.Point(1221, 262);
            this.txtClassAvg.Multiline = true;
            this.txtClassAvg.Name = "txtClassAvg";
            this.txtClassAvg.Size = new System.Drawing.Size(75, 30);
            this.txtClassAvg.TabIndex = 12;
            // 
            // failedStudent
            // 
            this.failedStudent.AutoSize = true;
            this.failedStudent.Location = new System.Drawing.Point(1121, 332);
            this.failedStudent.Name = "failedStudent";
            this.failedStudent.Size = new System.Drawing.Size(93, 16);
            this.failedStudent.TabIndex = 13;
            this.failedStudent.Text = "Failed Student";
            // 
            // txtFailedStudent
            // 
            this.txtFailedStudent.Location = new System.Drawing.Point(1221, 318);
            this.txtFailedStudent.Multiline = true;
            this.txtFailedStudent.Name = "txtFailedStudent";
            this.txtFailedStudent.Size = new System.Drawing.Size(75, 30);
            this.txtFailedStudent.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 407);
            this.Controls.Add(this.txtFailedStudent);
            this.Controls.Add(this.failedStudent);
            this.Controls.Add(this.txtClassAvg);
            this.Controls.Add(this.classAvg);
            this.Controls.Add(this.studentCount);
            this.Controls.Add(this.txtStudentCount);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.delete);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Student Grade Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtStudentCount;
        private Label studentCount;
        private Label classAvg;
        private TextBox txtClassAvg;
        private Label failedStudent;
        private TextBox txtFailedStudent;
    }
}