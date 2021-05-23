
namespace WinForms
    {
    partial class EmployeeForm
        {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
            {
            if ( disposing && ( components != null ) )
                {
                components.Dispose ();
                }
            base.Dispose (disposing);
            }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
            {
            this.employeeDataGridView = new System.Windows.Forms.DataGridView ();
            this.Insert = new System.Windows.Forms.Button ();
            this.Update = new System.Windows.Forms.Button ();
            this.Delete = new System.Windows.Forms.Button ();
            this.FirstName = new System.Windows.Forms.TextBox ();
            this.textBox2 = new System.Windows.Forms.TextBox ();
            this.textBox3 = new System.Windows.Forms.TextBox ();
            this.textBox4 = new System.Windows.Forms.TextBox ();
            this.label1 = new System.Windows.Forms.Label ();
            this.label2 = new System.Windows.Forms.Label ();
            this.label3 = new System.Windows.Forms.Label ();
            this.label4 = new System.Windows.Forms.Label ();
            ( ( System.ComponentModel.ISupportInitialize )( this.employeeDataGridView ) ).BeginInit ();
            this.SuspendLayout ();
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point (48, 140);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size (529, 269);
            this.employeeDataGridView.TabIndex = 0;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point (48, 81);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size (100, 28);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler (this.Insert_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point (177, 81);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size (100, 28);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler (this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point (313, 81);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size (100, 28);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler (this.Delete_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point (48, 39);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size (100, 20);
            this.FirstName.TabIndex = 4;
            this.FirstName.TextChanged += new System.EventHandler (this.FirstName_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point (177, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size (100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point (313, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size (100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point (447, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size (100, 20);
            this.textBox4.TabIndex = 7;
            // 
            //First Name Label
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (48, 20);
            this.label1.Name = "First Name";
            this.label1.Size = new System.Drawing.Size (35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // Last Name Label
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (177, 20);
            this.label2.Name = "Last Name";
            this.label2.Size = new System.Drawing.Size (35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // Age Label
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (313, 20);
            this.label3.Name = "Age";
            this.label3.Size = new System.Drawing.Size (35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Age";
            // 
            // Email Label
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point (447, 20);
            this.label4.Name = "Email";
            this.label4.Size = new System.Drawing.Size (35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (800, 450);
            this.Controls.Add (this.label4);
            this.Controls.Add (this.label3);
            this.Controls.Add (this.label2);
            this.Controls.Add (this.label1);
            this.Controls.Add (this.textBox4);
            this.Controls.Add (this.textBox3);
            this.Controls.Add (this.textBox2);
            this.Controls.Add (this.FirstName);
            this.Controls.Add (this.Delete);
            this.Controls.Add (this.Update);
            this.Controls.Add (this.Insert);
            this.Controls.Add (this.employeeDataGridView);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ( ( System.ComponentModel.ISupportInitialize )( this.employeeDataGridView ) ).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

            }

        #endregion
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button Insert;
#pragma warning disable CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
        private System.Windows.Forms.Button Update;
#pragma warning restore CS0108 // Член скрывает унаследованный член: отсутствует новое ключевое слово
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        }
    }

