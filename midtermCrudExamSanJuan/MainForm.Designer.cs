namespace midtermCrudExamSanJuan
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainExit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.salary_btn = new System.Windows.Forms.Button();
            this.addEmployee_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new midtermCrudExamSanJuan.Dashboard();
            this.addEmployee1 = new midtermCrudExamSanJuan.AddEmployee();
            this.salary1 = new midtermCrudExamSanJuan.Salary();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainExit
            // 
            this.mainExit.AutoSize = true;
            this.mainExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainExit.Location = new System.Drawing.Point(1106, 8);
            this.mainExit.Name = "mainExit";
            this.mainExit.Size = new System.Drawing.Size(32, 34);
            this.mainExit.TabIndex = 11;
            this.mainExit.Text = "X";
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(49)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mainExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 53);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logoutBtn);
            this.panel2.Controls.Add(this.salary_btn);
            this.panel2.Controls.Add(this.addEmployee_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 647);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sign out";
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Image = global::midtermCrudExamSanJuan.Properties.Resources.logout__1_;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(3, 540);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(237, 48);
            this.logoutBtn.TabIndex = 12;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.salary_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salary_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.salary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.salary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.salary_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_btn.ForeColor = System.Drawing.Color.White;
            this.salary_btn.Image = global::midtermCrudExamSanJuan.Properties.Resources.capital;
            this.salary_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salary_btn.Location = new System.Drawing.Point(12, 403);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.Size = new System.Drawing.Size(208, 59);
            this.salary_btn.TabIndex = 11;
            this.salary_btn.Text = "SALARY";
            this.salary_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salary_btn.UseVisualStyleBackColor = false;
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click);
            // 
            // addEmployee_btn
            // 
            this.addEmployee_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.addEmployee_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addEmployee_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.addEmployee_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.addEmployee_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.addEmployee_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_btn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_btn.Image = global::midtermCrudExamSanJuan.Properties.Resources.employee;
            this.addEmployee_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployee_btn.Location = new System.Drawing.Point(12, 328);
            this.addEmployee_btn.Name = "addEmployee_btn";
            this.addEmployee_btn.Size = new System.Drawing.Size(208, 59);
            this.addEmployee_btn.TabIndex = 10;
            this.addEmployee_btn.Text = "EMPLOYEE";
            this.addEmployee_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addEmployee_btn.UseVisualStyleBackColor = false;
            this.addEmployee_btn.Click += new System.EventHandler(this.addEmployee_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.dashboard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dashboard_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.dashboard_btn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::midtermCrudExamSanJuan.Properties.Resources.dashboard__1_;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 249);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(208, 59);
            this.dashboard_btn.TabIndex = 9;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 8;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 171);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(240, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 647);
            this.panel3.TabIndex = 14;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.SystemColors.Control;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(910, 647);
            this.dashboard1.TabIndex = 2;
            this.dashboard1.Load += new System.EventHandler(this.dashboard1_Load);
            // 
            // addEmployee1
            // 
            this.addEmployee1.BackColor = System.Drawing.SystemColors.Control;
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(910, 647);
            this.addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            this.salary1.BackColor = System.Drawing.SystemColors.Control;
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(910, 647);
            this.salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button salary_btn;
        private System.Windows.Forms.Button addEmployee_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private Salary salary1;
    }
}