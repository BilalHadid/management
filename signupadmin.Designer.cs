namespace WindowsFormsApp1
{
    partial class signupadmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUSer = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtpassadm = new System.Windows.Forms.TextBox();
            this.txtconfauto = new System.Windows.Forms.TextBox();
            this.btnsignadmin = new System.Windows.Forms.Button();
            this.btnadmbck = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelauto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RDOMALE = new System.Windows.Forms.RadioButton();
            this.RDBFEMALE = new System.Windows.Forms.RadioButton();
            this.txtCNIC = new System.Windows.Forms.MaskedTextBox();
            this.lblmessage = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Signup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(198, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "CNIC NO.    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email          :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password    :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Retype Password :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtUSer
            // 
            this.txtUSer.Location = new System.Drawing.Point(358, 86);
            this.txtUSer.Multiline = true;
            this.txtUSer.Name = "txtUSer";
            this.txtUSer.Size = new System.Drawing.Size(204, 25);
            this.txtUSer.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(358, 160);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(204, 25);
            this.txtEmail.TabIndex = 2;
            // 
            // txtpassadm
            // 
            this.txtpassadm.Location = new System.Drawing.Point(358, 233);
            this.txtpassadm.Multiline = true;
            this.txtpassadm.Name = "txtpassadm";
            this.txtpassadm.PasswordChar = '*';
            this.txtpassadm.Size = new System.Drawing.Size(204, 25);
            this.txtpassadm.TabIndex = 5;
            this.txtpassadm.TextChanged += new System.EventHandler(this.txtpassadm_TextChanged);
            // 
            // txtconfauto
            // 
            this.txtconfauto.Location = new System.Drawing.Point(358, 270);
            this.txtconfauto.Multiline = true;
            this.txtconfauto.Name = "txtconfauto";
            this.txtconfauto.PasswordChar = '*';
            this.txtconfauto.Size = new System.Drawing.Size(204, 25);
            this.txtconfauto.TabIndex = 7;
            this.txtconfauto.TextChanged += new System.EventHandler(this.txtconfauto_TextChanged);
            // 
            // btnsignadmin
            // 
            this.btnsignadmin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnsignadmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsignadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignadmin.Location = new System.Drawing.Point(395, 322);
            this.btnsignadmin.Name = "btnsignadmin";
            this.btnsignadmin.Size = new System.Drawing.Size(121, 31);
            this.btnsignadmin.TabIndex = 8;
            this.btnsignadmin.Text = "Sign Up!";
            this.btnsignadmin.UseVisualStyleBackColor = false;
            this.btnsignadmin.Click += new System.EventHandler(this.btnsignadmin_Click);
            // 
            // btnadmbck
            // 
            this.btnadmbck.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnadmbck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadmbck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmbck.Location = new System.Drawing.Point(37, 430);
            this.btnadmbck.Name = "btnadmbck";
            this.btnadmbck.Size = new System.Drawing.Size(121, 31);
            this.btnadmbck.TabIndex = 9;
            this.btnadmbck.Text = "<<Back";
            this.btnadmbck.UseVisualStyleBackColor = false;
            this.btnadmbck.Click += new System.EventHandler(this.btnadmbck_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(767, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelauto
            // 
            this.labelauto.AutoSize = true;
            this.labelauto.Location = new System.Drawing.Point(626, 279);
            this.labelauto.Name = "labelauto";
            this.labelauto.Size = new System.Drawing.Size(0, 13);
            this.labelauto.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Auto generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gender       :";
            // 
            // RDOMALE
            // 
            this.RDOMALE.AutoSize = true;
            this.RDOMALE.BackColor = System.Drawing.Color.Transparent;
            this.RDOMALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDOMALE.Location = new System.Drawing.Point(358, 202);
            this.RDOMALE.Name = "RDOMALE";
            this.RDOMALE.Size = new System.Drawing.Size(60, 20);
            this.RDOMALE.TabIndex = 3;
            this.RDOMALE.TabStop = true;
            this.RDOMALE.Text = "Male";
            this.RDOMALE.UseVisualStyleBackColor = false;
            // 
            // RDBFEMALE
            // 
            this.RDBFEMALE.AutoSize = true;
            this.RDBFEMALE.BackColor = System.Drawing.Color.Transparent;
            this.RDBFEMALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBFEMALE.Location = new System.Drawing.Point(456, 200);
            this.RDBFEMALE.Name = "RDBFEMALE";
            this.RDBFEMALE.Size = new System.Drawing.Size(78, 20);
            this.RDBFEMALE.TabIndex = 4;
            this.RDBFEMALE.TabStop = true;
            this.RDBFEMALE.Text = "Female";
            this.RDBFEMALE.UseVisualStyleBackColor = false;
            // 
            // txtCNIC
            // 
            this.txtCNIC.Location = new System.Drawing.Point(358, 125);
            this.txtCNIC.Mask = "00000-0000000-0";
            this.txtCNIC.Name = "txtCNIC";
            this.txtCNIC.Size = new System.Drawing.Size(204, 20);
            this.txtCNIC.TabIndex = 1;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.BackColor = System.Drawing.Color.Transparent;
            this.lblmessage.Location = new System.Drawing.Point(420, 303);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 13);
            this.lblmessage.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(767, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Dlt Data User";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Dlt_Click);
            // 
            // signupadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.adminsign;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 487);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.txtCNIC);
            this.Controls.Add(this.RDBFEMALE);
            this.Controls.Add(this.RDOMALE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelauto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnadmbck);
            this.Controls.Add(this.btnsignadmin);
            this.Controls.Add(this.txtconfauto);
            this.Controls.Add(this.txtpassadm);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUSer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "signupadmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signupadmin";
            this.Load += new System.EventHandler(this.signupadmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUSer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtpassadm;
        private System.Windows.Forms.TextBox txtconfauto;
        private System.Windows.Forms.Button btnsignadmin;
        private System.Windows.Forms.Button btnadmbck;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelauto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RDOMALE;
        private System.Windows.Forms.RadioButton RDBFEMALE;
        private System.Windows.Forms.MaskedTextBox txtCNIC;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button button3;
    }
}