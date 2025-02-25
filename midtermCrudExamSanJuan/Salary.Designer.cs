namespace midtermCrudExamSanJuan
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.empID_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.setSalary_btn = new System.Windows.Forms.Button();
            this.salary_txtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.position_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fullname_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagrid_salary = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.empID_txtbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.setSalary_btn);
            this.panel1.Controls.Add(this.salary_txtbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.position_txtbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fullname_txtbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ID_txtbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 597);
            this.panel1.TabIndex = 0;
            // 
            // empID_txtbox
            // 
            this.empID_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empID_txtbox.Location = new System.Drawing.Point(25, 123);
            this.empID_txtbox.Multiline = true;
            this.empID_txtbox.Name = "empID_txtbox";
            this.empID_txtbox.ReadOnly = true;
            this.empID_txtbox.Size = new System.Drawing.Size(253, 32);
            this.empID_txtbox.TabIndex = 16;
            this.empID_txtbox.TextChanged += new System.EventHandler(this.empID_txtbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Employee ID";
            // 
            // setSalary_btn
            // 
            this.setSalary_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.setSalary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setSalary_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSalary_btn.ForeColor = System.Drawing.Color.White;
            this.setSalary_btn.Location = new System.Drawing.Point(25, 379);
            this.setSalary_btn.Name = "setSalary_btn";
            this.setSalary_btn.Size = new System.Drawing.Size(253, 72);
            this.setSalary_btn.TabIndex = 14;
            this.setSalary_btn.Text = "SET SALARY";
            this.setSalary_btn.UseVisualStyleBackColor = false;
            this.setSalary_btn.Click += new System.EventHandler(this.setSalary_btn_Click);
            // 
            // salary_txtbox
            // 
            this.salary_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salary_txtbox.Location = new System.Drawing.Point(25, 307);
            this.salary_txtbox.Multiline = true;
            this.salary_txtbox.Name = "salary_txtbox";
            this.salary_txtbox.Size = new System.Drawing.Size(253, 32);
            this.salary_txtbox.TabIndex = 9;
            this.salary_txtbox.TextChanged += new System.EventHandler(this.salary_txtbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Salary";
            // 
            // position_txtbox
            // 
            this.position_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.position_txtbox.Location = new System.Drawing.Point(25, 249);
            this.position_txtbox.Multiline = true;
            this.position_txtbox.Name = "position_txtbox";
            this.position_txtbox.ReadOnly = true;
            this.position_txtbox.Size = new System.Drawing.Size(253, 32);
            this.position_txtbox.TabIndex = 7;
            this.position_txtbox.TextChanged += new System.EventHandler(this.position_txtbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Position";
            // 
            // fullname_txtbox
            // 
            this.fullname_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullname_txtbox.Location = new System.Drawing.Point(25, 190);
            this.fullname_txtbox.Multiline = true;
            this.fullname_txtbox.Name = "fullname_txtbox";
            this.fullname_txtbox.ReadOnly = true;
            this.fullname_txtbox.Size = new System.Drawing.Size(253, 32);
            this.fullname_txtbox.TabIndex = 3;
            this.fullname_txtbox.TextChanged += new System.EventHandler(this.fullname_txtbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name";
            // 
            // ID_txtbox
            // 
            this.ID_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID_txtbox.Location = new System.Drawing.Point(25, 66);
            this.ID_txtbox.Multiline = true;
            this.ID_txtbox.Name = "ID_txtbox";
            this.ID_txtbox.ReadOnly = true;
            this.ID_txtbox.Size = new System.Drawing.Size(253, 32);
            this.ID_txtbox.TabIndex = 1;
            this.ID_txtbox.TextChanged += new System.EventHandler(this.ID_txtbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.refresh_btn);
            this.panel2.Controls.Add(this.datagrid_salary);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(342, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 597);
            this.panel2.TabIndex = 1;
            // 
            // datagrid_salary
            // 
            this.datagrid_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_salary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_salary.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_salary.Location = new System.Drawing.Point(19, 42);
            this.datagrid_salary.Name = "datagrid_salary";
            this.datagrid_salary.RowHeadersWidth = 51;
            this.datagrid_salary.RowTemplate.Height = 24;
            this.datagrid_salary.Size = new System.Drawing.Size(515, 536);
            this.datagrid_salary.TabIndex = 1;
            this.datagrid_salary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_salary_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_btn.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Location = new System.Drawing.Point(423, 3);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(110, 35);
            this.refresh_btn.TabIndex = 2;
            this.refresh_btn.Text = "REFRESH";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(910, 647);
            this.Load += new System.EventHandler(this.Salary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_salary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datagrid_salary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salary_txtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox position_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fullname_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_txtbox;
        private System.Windows.Forms.Button setSalary_btn;
        private System.Windows.Forms.TextBox empID_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refresh_btn;
    }
}
