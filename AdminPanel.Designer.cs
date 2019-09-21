namespace WindowsFormsApp1
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnauto = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtonlycom = new System.Windows.Forms.TextBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.DTPADminPanel = new System.Windows.Forms.DateTimePicker();
            this.mtbContact = new System.Windows.Forms.MaskedTextBox();
            this.mtbcnic = new System.Windows.Forms.MaskedTextBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.mtbcnic);
            this.panel2.Controls.Add(this.mtbContact);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lblmessage);
            this.panel2.Controls.Add(this.btnauto);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.txtusername);
            this.panel2.Controls.Add(this.txtonlycom);
            this.panel2.Controls.Add(this.cmbUser);
            this.panel2.Controls.Add(this.DTPADminPanel);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 367);
            this.panel2.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::WindowsFormsApp1.Properties.Resources.Reset_icon;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(256, 392);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 37);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "       Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.buttonref_Click_1);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Image = global::WindowsFormsApp1.Properties.Resources.Science_Plus2_Math_icon;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(133, 392);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(112, 37);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "      Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(28, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 74);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "for Admin or Standard";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(194, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Standard User";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Admin";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(276, 187);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 13);
            this.lblmessage.TabIndex = 5;
            // 
            // btnauto
            // 
            this.btnauto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnauto.Location = new System.Drawing.Point(351, 163);
            this.btnauto.Name = "btnauto";
            this.btnauto.Size = new System.Drawing.Size(75, 23);
            this.btnauto.TabIndex = 5;
            this.btnauto.Text = "Auto pass";
            this.btnauto.UseVisualStyleBackColor = true;
            this.btnauto.Click += new System.EventHandler(this.btnauto_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 24);
            this.label16.TabIndex = 3;
            this.label16.Text = "User Name       :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 24);
            this.label15.TabIndex = 3;
            this.label15.Text = "User Password :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "Update User     :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 24);
            this.label12.TabIndex = 3;
            this.label12.Text = "User ID             :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "User CNIC        :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "User Contact    :";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(190, 164);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(157, 20);
            this.txtPass.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(190, 132);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(183, 20);
            this.txtusername.TabIndex = 3;
            // 
            // txtonlycom
            // 
            this.txtonlycom.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtonlycom.Location = new System.Drawing.Point(190, 100);
            this.txtonlycom.Name = "txtonlycom";
            this.txtonlycom.Size = new System.Drawing.Size(183, 20);
            this.txtonlycom.TabIndex = 2;
            this.txtonlycom.TextChanged += new System.EventHandler(this.txtonlycom_TextChanged);
            this.txtonlycom.Enter += new System.EventHandler(this.txtonlycom_Enter);
            this.txtonlycom.Leave += new System.EventHandler(this.txtonlycom_Leave);
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "HR",
            "Administrative",
            "Selling",
            "Product"});
            this.cmbUser.Location = new System.Drawing.Point(190, 61);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(183, 21);
            this.cmbUser.TabIndex = 1;
            // 
            // DTPADminPanel
            // 
            this.DTPADminPanel.Location = new System.Drawing.Point(167, 20);
            this.DTPADminPanel.Name = "DTPADminPanel";
            this.DTPADminPanel.Size = new System.Drawing.Size(206, 20);
            this.DTPADminPanel.TabIndex = 0;
            // 
            // mtbContact
            // 
            this.mtbContact.Location = new System.Drawing.Point(190, 208);
            this.mtbContact.Mask = "0000-0000000";
            this.mtbContact.Name = "mtbContact";
            this.mtbContact.Size = new System.Drawing.Size(183, 20);
            this.mtbContact.TabIndex = 6;
            // 
            // mtbcnic
            // 
            this.mtbcnic.Location = new System.Drawing.Point(190, 244);
            this.mtbcnic.Mask = "00000-0000000-0";
            this.mtbcnic.Name = "mtbcnic";
            this.mtbcnic.Size = new System.Drawing.Size(183, 20);
            this.mtbcnic.TabIndex = 7;
            // 
            // AdminPanel
            // 
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.form_background_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 451);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminArea";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIDcom;
        private System.Windows.Forms.ComboBox cmbUpdateuser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCnic;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnauto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtonlycom;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.DateTimePicker DTPADminPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MaskedTextBox mtbcnic;
        private System.Windows.Forms.MaskedTextBox mtbContact;
    }
}