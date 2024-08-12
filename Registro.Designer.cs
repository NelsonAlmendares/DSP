namespace Catedra1
{
    partial class Registro
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
            btn_agregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Txt_Nombre = new TextBox();
            Txt_User = new TextBox();
            Txt_Password = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(774, 451);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(264, 58);
            btn_agregar.TabIndex = 0;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 69);
            label1.Name = "label1";
            label1.Size = new Size(201, 26);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 304);
            label2.Name = "label2";
            label2.Size = new Size(138, 26);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(89, 180);
            label3.Name = "label3";
            label3.Size = new Size(98, 26);
            label3.TabIndex = 3;
            label3.Text = "Usuario:";
            // 
            // Txt_Nombre
            // 
            Txt_Nombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Nombre.Location = new Point(93, 111);
            Txt_Nombre.Name = "Txt_Nombre";
            Txt_Nombre.Size = new Size(417, 30);
            Txt_Nombre.TabIndex = 4;
            // 
            // Txt_User
            // 
            Txt_User.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_User.Location = new Point(93, 224);
            Txt_User.Name = "Txt_User";
            Txt_User.Size = new Size(417, 30);
            Txt_User.TabIndex = 5;
            // 
            // Txt_Password
            // 
            Txt_Password.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Password.Location = new Point(93, 348);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.Size = new Size(417, 30);
            Txt_Password.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(559, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(479, 340);
            dataGridView1.TabIndex = 7;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 548);
            Controls.Add(dataGridView1);
            Controls.Add(Txt_Password);
            Controls.Add(Txt_User);
            Controls.Add(Txt_Nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_agregar);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_agregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Txt_Nombre;
        private TextBox Txt_User;
        private TextBox Txt_Password;
        private DataGridView dataGridView1;
    }
}