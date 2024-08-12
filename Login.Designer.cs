namespace Catedra1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_login = new Button();
            txt_user = new TextBox();
            mskTxtContra = new MaskedTextBox();
            btn_registerUser = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(78, 74);
            label1.Name = "label1";
            label1.Size = new Size(114, 44);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(178, 191);
            label2.Name = "label2";
            label2.Size = new Size(183, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(167, 322);
            label3.Name = "label3";
            label3.Size = new Size(216, 23);
            label3.TabIndex = 2;
            label3.Text = "Contraseña del Usuario";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(110, 117, 255);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(146, 449);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(252, 66);
            btn_login.TabIndex = 3;
            btn_login.Text = "Ingresar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(78, 232);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(390, 28);
            txt_user.TabIndex = 4;
            // 
            // mskTxtContra
            // 
            mskTxtContra.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            mskTxtContra.Location = new Point(78, 358);
            mskTxtContra.Name = "mskTxtContra";
            mskTxtContra.Size = new Size(390, 28);
            mskTxtContra.TabIndex = 5;
            // 
            // btn_registerUser
            // 
            btn_registerUser.AutoSize = true;
            btn_registerUser.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_registerUser.Location = new Point(194, 535);
            btn_registerUser.Name = "btn_registerUser";
            btn_registerUser.Size = new Size(144, 21);
            btn_registerUser.TabIndex = 6;
            btn_registerUser.TabStop = true;
            btn_registerUser.Text = "Crear un usuario";
            btn_registerUser.LinkClicked += btn_registerUser_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 46, 70);
            ClientSize = new Size(547, 653);
            Controls.Add(btn_registerUser);
            Controls.Add(mskTxtContra);
            Controls.Add(txt_user);
            Controls.Add(btn_login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_login;
        private TextBox txt_user;
        private MaskedTextBox mskTxtContra;
        private LinkLabel btn_registerUser;
    }
}
