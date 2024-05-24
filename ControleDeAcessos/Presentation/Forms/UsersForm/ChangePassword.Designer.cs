namespace ControleDeAcessos.Presentation.Forms.UsersForm
{
    partial class ChangePassword
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
            label1 = new Label();
            textBoxPassword = new TextBox();
            label2 = new Label();
            textBoxConfirmPassword = new TextBox();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 17;
            label1.Text = "Senha";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(12, 33);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(317, 29);
            textBoxPassword.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 19;
            label2.Text = "Senha Novamente";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConfirmPassword.Location = new Point(12, 89);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.Size = new Size(317, 29);
            textBoxConfirmPassword.TabIndex = 18;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Cursor = Cursors.Hand;
            buttonConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.Location = new Point(176, 124);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(153, 35);
            buttonConfirm.TabIndex = 22;
            buttonConfirm.Text = "Confirmar";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(12, 124);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(153, 35);
            buttonCancel.TabIndex = 21;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(341, 170);
            ControlBox = false;
            Controls.Add(buttonConfirm);
            Controls.Add(buttonCancel);
            Controls.Add(label2);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trocar de Senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPassword;
        private Label label2;
        private TextBox textBoxConfirmPassword;
        private Button buttonConfirm;
        private Button buttonCancel;
    }
}