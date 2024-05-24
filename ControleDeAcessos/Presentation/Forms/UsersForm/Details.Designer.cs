namespace ControleDeAcessos.Presentation.Forms.UsersForm
{
    partial class Details
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
            buttonEdit = new Button();
            buttonCancel = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            textBoxUsername = new TextBox();
            buttonResetPassword = new Button();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(176, 180);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(153, 35);
            buttonEdit.TabIndex = 20;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(12, 180);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(153, 35);
            buttonCancel.TabIndex = 19;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 18;
            label4.Text = "E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 65);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 17;
            label3.Text = "Nome Completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 15;
            label1.Text = "Usuário";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(12, 145);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(317, 29);
            textBoxEmail.TabIndex = 14;
            // 
            // textBoxName
            // 
            textBoxName.Enabled = false;
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(12, 89);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(317, 29);
            textBoxName.TabIndex = 13;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Enabled = false;
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(12, 33);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(317, 29);
            textBoxUsername.TabIndex = 11;
            // 
            // buttonResetPassword
            // 
            buttonResetPassword.Cursor = Cursors.Hand;
            buttonResetPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonResetPassword.Location = new Point(12, 221);
            buttonResetPassword.Name = "buttonResetPassword";
            buttonResetPassword.Size = new Size(317, 35);
            buttonResetPassword.TabIndex = 21;
            buttonResetPassword.Text = "Trocar de Senha ";
            buttonResetPassword.UseVisualStyleBackColor = true;
            buttonResetPassword.Click += buttonResetPassword_Click;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(341, 265);
            ControlBox = false;
            Controls.Add(buttonResetPassword);
            Controls.Add(buttonEdit);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(textBoxUsername);
            Name = "Index";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minhas Informações";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonEdit;
        private Button buttonCancel;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private TextBox textBoxUsername;
        private Button buttonResetPassword;
    }
}