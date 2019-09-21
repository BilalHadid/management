namespace WindowsFormsApp1
{
    partial class SignHR
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
            this.RDBFEMALE = new System.Windows.Forms.RadioButton();
            this.RDOMALE = new System.Windows.Forms.RadioButton();
            this.txtconfauto = new System.Windows.Forms.TextBox();
            this.txtpassadm = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSignHR = new WindowsFormsApp1.gol();
            this.lblMessageco = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblautopass = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "HR Signup";
            // 
            // RDBFEMALE
            // 
            this.RDBFEMALE.AutoSize = true;
            this.RDBFEMALE.BackColor = System.Drawing.Color.Transparent;
            this.RDBFEMALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDBFEMALE.Location = new System.Drawing.Point(478, 198);
            this.RDBFEMALE.Name = "RDBFEMALE";
            this.RDBFEMALE.Size = new System.Drawing.Size(78, 20);
            this.RDBFEMALE.TabIndex = 4;
            this.RDBFEMALE.TabStop = true;
            this.RDBFEMALE.Text = "Female";
            this.RDBFEMALE.UseVisualStyleBackColor = false;
            // 
            // RDOMALE
            // 
            this.RDOMALE.AutoSize = true;
            this.RDOMALE.BackColor = System.Drawing.Color.Transparent;
            this.RDOMALE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDOMALE.Location = new System.Drawing.Point(380, 200);
            this.RDOMALE.Name = "RDOMALE";
            this.RDOMALE.Size = new System.Drawing.Size(60, 20);
            this.RDOMALE.TabIndex = 3;
            this.RDOMALE.TabStop = true;
            this.RDOMALE.Text = "Male";
            this.RDOMALE.UseVisualStyleBackColor = false;
            // 
            // txtconfauto
            // 
            this.txtconfauto.Location = new System.Drawing.Point(380, 268);
            this.txtconfauto.Multiline = true;
            this.txtconfauto.Name = "txtconfauto";
            this.txtconfauto.PasswordChar = '*';
            this.txtconfauto.Size = new System.Drawing.Size(204, 25);
            this.txtconfauto.TabIndex = 6;
            this.txtconfauto.UseSystemPasswordChar = true;
            this.txtconfauto.TextChanged += new System.EventHandler(this.txtconfauto_TextChanged);
            // 
            // txtpassadm
            // 
            this.txtpassadm.Location = new System.Drawing.Point(380, 231);
            this.txtpassadm.Multiline = true;
            this.txtpassadm.Name = "txtpassadm";
            this.txtpassadm.PasswordChar = '*';
            this.txtpassadm.Size = new System.Drawing.Size(204, 25);
            this.txtpassadm.TabIndex = 5;
            this.txtpassadm.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(380, 158);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 25);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(380, 123);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 25);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 25);
            this.textBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Retype Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password    :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gender       :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email          :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "CNIC NO.    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Name  :";
            // 
            // btnSignHR
            // 
            this.btnSignHR.BackColor = System.Drawing.Color.Linen;
            this.btnSignHR.Enabled = false;
            this.btnSignHR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignHR.Location = new System.Drawing.Point(423, 348);
            this.btnSignHR.Name = "btnSignHR";
            this.btnSignHR.Size = new System.Drawing.Size(81, 79);
            this.btnSignHR.TabIndex = 8;
            this.btnSignHR.Text = "Sign Up";
            this.btnSignHR.UseVisualStyleBackColor = false;
            // 
            // lblMessageco
            // 
            this.lblMessageco.AutoSize = true;
            this.lblMessageco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageco.Location = new System.Drawing.Point(444, 300);
            this.lblMessageco.Name = "lblMessageco";
            this.lblMessageco.Size = new System.Drawing.Size(0, 16);
            this.lblMessageco.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(636, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Auto Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblautopass
            // 
            this.lblautopass.AutoSize = true;
            this.lblautopass.Location = new System.Drawing.Point(633, 271);
            this.lblautopass.Name = "lblautopass";
            this.lblautopass.Size = new System.Drawing.Size(0, 13);
            this.lblautopass.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(27, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "<<Back!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(764, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SignHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.HRS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 492);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblautopass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMessageco);
            this.Controls.Add(this.btnSignHR);
            this.Controls.Add(this.RDBFEMALE);
            this.Controls.Add(this.RDOMALE);
            this.Controls.Add(this.txtconfauto);
            this.Controls.Add(this.txtpassadm);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignHR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignHR";
            this.Load += new System.EventHandler(this.SignHR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RDBFEMALE;
        private System.Windows.Forms.RadioButton RDOMALE;
        private System.Windows.Forms.TextBox txtconfauto;
        private System.Windows.Forms.TextBox txtpassadm;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private gol btnSignHR;
        private System.Windows.Forms.Label lblMessageco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblautopass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}