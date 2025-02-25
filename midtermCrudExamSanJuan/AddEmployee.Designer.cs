namespace midtermCrudExamSanJuan
{
    partial class AddEmployee
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
            this.database_DatagridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.employeeID_txtbox = new System.Windows.Forms.TextBox();
            this.employeeID = new System.Windows.Forms.Label();
            this.status_combobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gender_combobox = new System.Windows.Forms.ComboBox();
            this.position_txtbox = new System.Windows.Forms.ComboBox();
            this.addEmployee_clearBtn = new System.Windows.Forms.Button();
            this.addEmployee_deleteBtn = new System.Windows.Forms.Button();
            this.addEmployee_updateBtn = new System.Windows.Forms.Button();
            this.addEmployee_addBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.uploadImage_btn = new System.Windows.Forms.Button();
            this.addEmployee_pictureBox = new System.Windows.Forms.PictureBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastname_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_DatagridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.database_DatagridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 346);
            this.panel1.TabIndex = 0;
            // 
            // database_DatagridView
            // 
            this.database_DatagridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.database_DatagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.database_DatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.database_DatagridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.database_DatagridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.database_DatagridView.Location = new System.Drawing.Point(0, 0);
            this.database_DatagridView.Name = "database_DatagridView";
            this.database_DatagridView.RowHeadersVisible = false;
            this.database_DatagridView.RowHeadersWidth = 51;
            this.database_DatagridView.RowTemplate.Height = 24;
            this.database_DatagridView.Size = new System.Drawing.Size(869, 346);
            this.database_DatagridView.TabIndex = 1;
            this.database_DatagridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.database_DatagridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.employeeID_txtbox);
            this.panel2.Controls.Add(this.employeeID);
            this.panel2.Controls.Add(this.status_combobox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.gender_combobox);
            this.panel2.Controls.Add(this.position_txtbox);
            this.panel2.Controls.Add(this.addEmployee_clearBtn);
            this.panel2.Controls.Add(this.addEmployee_deleteBtn);
            this.panel2.Controls.Add(this.addEmployee_updateBtn);
            this.panel2.Controls.Add(this.addEmployee_addBtn);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.uploadImage_btn);
            this.panel2.Controls.Add(this.addEmployee_pictureBox);
            this.panel2.Controls.Add(this.email_textbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lastname_txtbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.firstName_txtbox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 384);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(869, 260);
            this.panel2.TabIndex = 1;
            // 
            // employeeID_txtbox
            // 
            this.employeeID_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeID_txtbox.Location = new System.Drawing.Point(191, 148);
            this.employeeID_txtbox.Multiline = true;
            this.employeeID_txtbox.Name = "employeeID_txtbox";
            this.employeeID_txtbox.Size = new System.Drawing.Size(137, 27);
            this.employeeID_txtbox.TabIndex = 22;
            // 
            // employeeID
            // 
            this.employeeID.AutoSize = true;
            this.employeeID.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeID.Location = new System.Drawing.Point(187, 123);
            this.employeeID.Name = "employeeID";
            this.employeeID.Size = new System.Drawing.Size(120, 22);
            this.employeeID.TabIndex = 21;
            this.employeeID.Text = "Employee ID";
            // 
            // status_combobox
            // 
            this.status_combobox.FormattingEnabled = true;
            this.status_combobox.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.status_combobox.Location = new System.Drawing.Point(363, 146);
            this.status_combobox.Name = "status_combobox";
            this.status_combobox.Size = new System.Drawing.Size(307, 24);
            this.status_combobox.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Status";
            // 
            // gender_combobox
            // 
            this.gender_combobox.FormattingEnabled = true;
            this.gender_combobox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others",
            "Alien"});
            this.gender_combobox.Location = new System.Drawing.Point(21, 146);
            this.gender_combobox.Name = "gender_combobox";
            this.gender_combobox.Size = new System.Drawing.Size(137, 24);
            this.gender_combobox.TabIndex = 18;
            // 
            // position_txtbox
            // 
            this.position_txtbox.FormattingEnabled = true;
            this.position_txtbox.Items.AddRange(new object[] {
            "Front End Developer",
            "Backend Developer",
            "Data Analyst",
            "Weed Farmer",
            "Cotton Farmer"});
            this.position_txtbox.Location = new System.Drawing.Point(363, 96);
            this.position_txtbox.Name = "position_txtbox";
            this.position_txtbox.Size = new System.Drawing.Size(307, 24);
            this.position_txtbox.TabIndex = 17;
            // 
            // addEmployee_clearBtn
            // 
            this.addEmployee_clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.addEmployee_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_clearBtn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_clearBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_clearBtn.Location = new System.Drawing.Point(533, 188);
            this.addEmployee_clearBtn.Name = "addEmployee_clearBtn";
            this.addEmployee_clearBtn.Size = new System.Drawing.Size(137, 56);
            this.addEmployee_clearBtn.TabIndex = 16;
            this.addEmployee_clearBtn.Text = "CLEAR";
            this.addEmployee_clearBtn.UseVisualStyleBackColor = false;
            this.addEmployee_clearBtn.Click += new System.EventHandler(this.addEmployee_clearBtn_Click);
            // 
            // addEmployee_deleteBtn
            // 
            this.addEmployee_deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.addEmployee_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_deleteBtn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_deleteBtn.Location = new System.Drawing.Point(363, 188);
            this.addEmployee_deleteBtn.Name = "addEmployee_deleteBtn";
            this.addEmployee_deleteBtn.Size = new System.Drawing.Size(137, 56);
            this.addEmployee_deleteBtn.TabIndex = 15;
            this.addEmployee_deleteBtn.Text = "DELETE";
            this.addEmployee_deleteBtn.UseVisualStyleBackColor = false;
            this.addEmployee_deleteBtn.Click += new System.EventHandler(this.addEmployee_deleteBtn_Click);
            // 
            // addEmployee_updateBtn
            // 
            this.addEmployee_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.addEmployee_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_updateBtn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_updateBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_updateBtn.Location = new System.Drawing.Point(191, 188);
            this.addEmployee_updateBtn.Name = "addEmployee_updateBtn";
            this.addEmployee_updateBtn.Size = new System.Drawing.Size(137, 56);
            this.addEmployee_updateBtn.TabIndex = 14;
            this.addEmployee_updateBtn.Text = "UPDATE";
            this.addEmployee_updateBtn.UseVisualStyleBackColor = false;
            this.addEmployee_updateBtn.Click += new System.EventHandler(this.addEmployee_updateBtn_Click);
            // 
            // addEmployee_addBtn
            // 
            this.addEmployee_addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.addEmployee_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_addBtn.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_addBtn.ForeColor = System.Drawing.Color.White;
            this.addEmployee_addBtn.Location = new System.Drawing.Point(21, 188);
            this.addEmployee_addBtn.Name = "addEmployee_addBtn";
            this.addEmployee_addBtn.Size = new System.Drawing.Size(137, 56);
            this.addEmployee_addBtn.TabIndex = 13;
            this.addEmployee_addBtn.Text = "ADD";
            this.addEmployee_addBtn.UseVisualStyleBackColor = false;
            this.addEmployee_addBtn.Click += new System.EventHandler(this.addEmployee_addBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Position";
            // 
            // uploadImage_btn
            // 
            this.uploadImage_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(89)))), ((int)(((byte)(65)))));
            this.uploadImage_btn.FlatAppearance.BorderSize = 0;
            this.uploadImage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadImage_btn.Font = new System.Drawing.Font("Cascadia Code", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadImage_btn.ForeColor = System.Drawing.Color.White;
            this.uploadImage_btn.Location = new System.Drawing.Point(733, 156);
            this.uploadImage_btn.Name = "uploadImage_btn";
            this.uploadImage_btn.Size = new System.Drawing.Size(117, 42);
            this.uploadImage_btn.TabIndex = 9;
            this.uploadImage_btn.Text = "Upload Image";
            this.uploadImage_btn.UseVisualStyleBackColor = false;
            this.uploadImage_btn.Click += new System.EventHandler(this.uploadImage_btn_Click);
            // 
            // addEmployee_pictureBox
            // 
            this.addEmployee_pictureBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addEmployee_pictureBox.Location = new System.Drawing.Point(733, 38);
            this.addEmployee_pictureBox.Name = "addEmployee_pictureBox";
            this.addEmployee_pictureBox.Size = new System.Drawing.Size(117, 132);
            this.addEmployee_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_pictureBox.TabIndex = 8;
            this.addEmployee_pictureBox.TabStop = false;
            // 
            // email_textbox
            // 
            this.email_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_textbox.Location = new System.Drawing.Point(363, 38);
            this.email_textbox.Multiline = true;
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(307, 27);
            this.email_textbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender";
            // 
            // lastname_txtbox
            // 
            this.lastname_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastname_txtbox.Location = new System.Drawing.Point(21, 93);
            this.lastname_txtbox.Multiline = true;
            this.lastname_txtbox.Name = "lastname_txtbox";
            this.lastname_txtbox.Size = new System.Drawing.Size(307, 27);
            this.lastname_txtbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // firstName_txtbox
            // 
            this.firstName_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstName_txtbox.Location = new System.Drawing.Point(21, 38);
            this.firstName_txtbox.Multiline = true;
            this.firstName_txtbox.Name = "firstName_txtbox";
            this.firstName_txtbox.Size = new System.Drawing.Size(307, 27);
            this.firstName_txtbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(910, 647);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_DatagridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView database_DatagridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastname_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstName_txtbox;
        private System.Windows.Forms.Button uploadImage_btn;
        private System.Windows.Forms.PictureBox addEmployee_pictureBox;
        private System.Windows.Forms.Button addEmployee_addBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addEmployee_clearBtn;
        private System.Windows.Forms.Button addEmployee_deleteBtn;
        private System.Windows.Forms.Button addEmployee_updateBtn;
        private System.Windows.Forms.ComboBox position_txtbox;
        private System.Windows.Forms.ComboBox gender_combobox;
        private System.Windows.Forms.ComboBox status_combobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox employeeID_txtbox;
        private System.Windows.Forms.Label employeeID;
    }
}
