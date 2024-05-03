namespace ControleDeAcessos.View.AccessDataView
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            label4 = new Label();
            textBoxPlatform = new TextBox();
            buttonEdit = new Button();
            buttonCancel = new Button();
            buttonDisplayPassword = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDescription = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
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
            textBoxPlatform.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPlatform.Location = new Point(12, 145);
            textBoxPlatform.Name = "textBoxPlatform";
            textBoxPlatform.Size = new Size(337, 29);
            textBoxPlatform.TabIndex = 13;
            // 
            // buttonEdit
            // 
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(186, 332);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(163, 35);
            buttonEdit.TabIndex = 17;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(12, 332);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(163, 35);
            buttonCancel.TabIndex = 19;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDisplayPassword
            // 
            buttonDisplayPassword.BackgroundImage = (Image)resources.GetObject("buttonDisplayPassword.BackgroundImage");
            buttonDisplayPassword.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDisplayPassword.Location = new Point(318, 89);
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
            label2.Size = new Size(60, 21);
            label2.TabIndex = 15;
            label2.Text = "Senha*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 14;
            label1.Text = "Usuário*";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescription.Location = new Point(12, 201);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(337, 125);
            textBoxDescription.TabIndex = 16;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(12, 89);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(300, 29);
            textBoxPassword.TabIndex = 12;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(12, 33);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(337, 29);
            textBoxUsername.TabIndex = 11;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(360, 382);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(textBoxPlatform);
            Controls.Add(buttonEdit);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDisplayPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "Edit";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox textBoxPlatform;
        private Button buttonEdit;
        private Button buttonCancel;
        private Button buttonDisplayPassword;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDescription;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
    }
}