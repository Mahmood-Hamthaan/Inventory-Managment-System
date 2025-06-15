namespace Inventory_Managment_System.Forms
{
    partial class RegistrationUI
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelRegistrationName = new System.Windows.Forms.Label();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.labelRegistrationPassword = new System.Windows.Forms.Label();
            this.labelRegistrationUsername = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.labelRegistrationConPassword = new System.Windows.Forms.Label();
            this.buttonBacktoLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.textBoxRegistrationName_TextChanged);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonRegister.Location = new System.Drawing.Point(62, 322);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(85, 36);
            this.buttonRegister.TabIndex = 10;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelRegistrationName
            // 
            this.labelRegistrationName.AutoSize = true;
            this.labelRegistrationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationName.Location = new System.Drawing.Point(59, 105);
            this.labelRegistrationName.Name = "labelRegistrationName";
            this.labelRegistrationName.Size = new System.Drawing.Size(63, 20);
            this.labelRegistrationName.TabIndex = 8;
            this.labelRegistrationName.Text = "Name :";
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistration.Location = new System.Drawing.Point(124, 39);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(154, 29);
            this.labelRegistration.TabIndex = 7;
            this.labelRegistration.Text = "Registration";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(215, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 22);
            this.txtPassword.TabIndex = 16;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(215, 160);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 22);
            this.txtUsername.TabIndex = 15;
            // 
            // labelRegistrationPassword
            // 
            this.labelRegistrationPassword.AutoSize = true;
            this.labelRegistrationPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationPassword.Location = new System.Drawing.Point(58, 217);
            this.labelRegistrationPassword.Name = "labelRegistrationPassword";
            this.labelRegistrationPassword.Size = new System.Drawing.Size(93, 20);
            this.labelRegistrationPassword.TabIndex = 14;
            this.labelRegistrationPassword.Text = "Password :";
            // 
            // labelRegistrationUsername
            // 
            this.labelRegistrationUsername.AutoSize = true;
            this.labelRegistrationUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationUsername.Location = new System.Drawing.Point(59, 162);
            this.labelRegistrationUsername.Name = "labelRegistrationUsername";
            this.labelRegistrationUsername.Size = new System.Drawing.Size(96, 20);
            this.labelRegistrationUsername.TabIndex = 13;
            this.labelRegistrationUsername.Text = "Username :";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(215, 272);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(150, 22);
            this.txtContactNumber.TabIndex = 18;
            // 
            // labelRegistrationConPassword
            // 
            this.labelRegistrationConPassword.AutoSize = true;
            this.labelRegistrationConPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrationConPassword.Location = new System.Drawing.Point(58, 274);
            this.labelRegistrationConPassword.Name = "labelRegistrationConPassword";
            this.labelRegistrationConPassword.Size = new System.Drawing.Size(81, 20);
            this.labelRegistrationConPassword.TabIndex = 17;
            this.labelRegistrationConPassword.Text = "User No :";
            // 
            // buttonBacktoLogin
            // 
            this.buttonBacktoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonBacktoLogin.Location = new System.Drawing.Point(63, 390);
            this.buttonBacktoLogin.Name = "buttonBacktoLogin";
            this.buttonBacktoLogin.Size = new System.Drawing.Size(302, 36);
            this.buttonBacktoLogin.TabIndex = 19;
            this.buttonBacktoLogin.Text = "Back To LogIn";
            this.buttonBacktoLogin.UseVisualStyleBackColor = true;
            this.buttonBacktoLogin.Click += new System.EventHandler(this.buttonBacktoLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(153, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Role :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Supplier",
            "Customer"});
            this.cmbRole.Location = new System.Drawing.Point(215, 326);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(150, 24);
            this.cmbRole.TabIndex = 22;
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RegistrationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBacktoLogin);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.labelRegistrationConPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelRegistrationPassword);
            this.Controls.Add(this.labelRegistrationUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegistrationName);
            this.Controls.Add(this.labelRegistration);
            this.Name = "RegistrationUI";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelRegistrationName;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label labelRegistrationPassword;
        private System.Windows.Forms.Label labelRegistrationUsername;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label labelRegistrationConPassword;
        private System.Windows.Forms.Button buttonBacktoLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRole;
    }
}