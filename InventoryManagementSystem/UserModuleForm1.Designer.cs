namespace InventoryManagementSystem
{
    partial class UserModuleForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModuleForm1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBoxclose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBoxclose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Module ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(64, 169);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(118, 28);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "User Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 31);
            this.textBox2.TabIndex = 4;
            // 
            // txtFullName
            // 
            this.txtFullName.AutoSize = true;
            this.txtFullName.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(64, 247);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(110, 28);
            this.txtFullName.TabIndex = 3;
            this.txtFullName.Text = "Full Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(201, 333);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 31);
            this.textBox3.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(64, 331);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(102, 28);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(201, 415);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(400, 31);
            this.textBox4.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Font = new System.Drawing.Font("Perpetua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(64, 417);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(74, 28);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Text = "Phone:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(418, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(624, 501);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 38);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Olive;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(521, 501);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 38);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // pictureBoxclose
            // 
            this.pictureBoxclose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxclose.Image")));
            this.pictureBoxclose.Location = new System.Drawing.Point(758, 0);
            this.pictureBoxclose.Name = "pictureBoxclose";
            this.pictureBoxclose.Size = new System.Drawing.Size(30, 33);
            this.pictureBoxclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxclose.TabIndex = 14;
            this.pictureBoxclose.TabStop = false;
            this.pictureBoxclose.Click += new System.EventHandler(this.pictureBoxclose_Click);
            // 
            // UserModuleForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 579);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModuleForm1";
            this.Text = "UserModuleForm1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBoxclose;
    }
}