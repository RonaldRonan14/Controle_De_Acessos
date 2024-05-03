namespace ControleDeAcessos.View.UsersView
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonCancel = new Button();
            buttonCreate = new Button();
            buttonDisplayPassword = new Button();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(12, 33);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(317, 29);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(12, 89);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(280, 29);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(12, 145);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(317, 29);
            textBoxName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(12, 201);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(317, 29);
            textBoxEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 4;
            label1.Text = "Usuário*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 5;
            label2.Text = "Senha*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 6;
            label3.Text = "Nome Completo*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 7;
            label4.Text = "E-Mail*";
            // 
            // buttonCancel
            // 
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(12, 236);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(153, 35);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.Location = new Point(176, 236);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(153, 35);
            buttonCreate.TabIndex = 9;
            buttonCreate.Text = "Criar";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDisplayPassword
            // 
            buttonDisplayPassword.BackColor = Color.Transparent;
            buttonDisplayPassword.BackgroundImage = (Image)resources.GetObject("buttonDisplayPassword.BackgroundImage");
            buttonDisplayPassword.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDisplayPassword.Cursor = Cursors.Hand;
            buttonDisplayPassword.Location = new Point(298, 89);
            buttonDisplayPassword.Name = "buttonDisplayPassword";
            buttonDisplayPassword.Size = new Size(31, 29);
            buttonDisplayPassword.TabIndex = 10;
            buttonDisplayPassword.UseVisualStyleBackColor = false;
            buttonDisplayPassword.Click += buttonDisplayPassword_Click;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(340, 282);
            ControlBox = false;
            Controls.Add(buttonDisplayPassword);
            Controls.Add(buttonCreate);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Create";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criar Conta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonCancel;
        private Button buttonCreate;
        private Button buttonDisplayPassword;
    }
}