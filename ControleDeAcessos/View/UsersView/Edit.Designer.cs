namespace ControleDeAcessos.View.UsersView
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
            buttonEdit = new Button();
            buttonCancel = new Button();
            label4 = new Label();
            label3 = new Label();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Cursor = Cursors.Hand;
            buttonEdit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(176, 124);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(153, 35);
            buttonEdit.TabIndex = 29;
            buttonEdit.Text = "Editar";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_ClickAsync;
            // 
            // buttonCancel
            // 
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(12, 124);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(153, 35);
            buttonCancel.TabIndex = 28;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 65);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 27;
            label4.Text = "E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 26;
            label3.Text = "Nome Completo*";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(12, 89);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(317, 29);
            textBoxEmail.TabIndex = 24;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(12, 33);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(317, 29);
            textBoxName.TabIndex = 23;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(341, 169);
            ControlBox = false;
            Controls.Add(buttonEdit);
            Controls.Add(buttonCancel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private Button buttonCancel;
        private Label label4;
        private Label label3;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
    }
}