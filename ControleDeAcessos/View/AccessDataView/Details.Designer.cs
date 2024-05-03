namespace ControleDeAcessos.View.AccessDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details));
            label4 = new Label();
            textBoxPlatform = new TextBox();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonDisplayPassword = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDescription = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            buttonClose = new Button();
            buttonCopy = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 21;
            label4.Text = "Plataforma|Link";
            // 
            // textBoxPlatform
            // 
            textBoxPlatform.Enabled = false;
            textBoxPlatform.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlatform.Location = new Point(12, 145);
            textBoxPlatform.Name = "textBoxPlatform";
            textBoxPlatform.Size = new Size(337, 29);
            textBoxPlatform.TabIndex = 3;
            // 
            // buttonEdit
            // 
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(186, 332);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(163, 35);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(12, 332);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(163, 35);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Deletar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDisplayPassword
            // 
            buttonDisplayPassword.BackgroundImage = (Image)resources.GetObject("buttonDisplayPassword.BackgroundImage");
            buttonDisplayPassword.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDisplayPassword.Cursor = Cursors.Hand;
            buttonDisplayPassword.Location = new Point(281, 90);
            buttonDisplayPassword.Name = "buttonDisplayPassword";
            buttonDisplayPassword.Size = new Size(31, 29);
            buttonDisplayPassword.TabIndex = 20;
            buttonDisplayPassword.UseVisualStyleBackColor = true;
            buttonDisplayPassword.Click += buttonDisplayPassword_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 18;
            label3.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 15;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 14;
            label1.Text = "Usuário";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Enabled = false;
            textBoxDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.Location = new Point(12, 201);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(337, 125);
            textBoxDescription.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Enabled = false;
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(12, 89);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(263, 29);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Enabled = false;
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(12, 33);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(337, 29);
            textBoxUsername.TabIndex = 1;
            // 
            // buttonClose
            // 
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(12, 374);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(336, 35);
            buttonClose.TabIndex = 7;
            buttonClose.Text = "Fechar";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.BackgroundImage = (Image)resources.GetObject("buttonCopy.BackgroundImage");
            buttonCopy.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCopy.Cursor = Cursors.Hand;
            buttonCopy.Location = new Point(318, 90);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(31, 29);
            buttonCopy.TabIndex = 22;
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(360, 421);
            ControlBox = false;
            Controls.Add(buttonCopy);
            Controls.Add(buttonClose);
            Controls.Add(label4);
            Controls.Add(textBoxPlatform);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonDisplayPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "Details";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBoxPlatform;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonDisplayPassword;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDescription;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonClose;
        private Button buttonCopy;
    }
}