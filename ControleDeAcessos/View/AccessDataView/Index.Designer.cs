namespace ControleDeAcessos.View.AccessDataView
{
    partial class Index
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
            menuStrip1 = new MenuStrip();
            gruposToolStripMenuItem = new ToolStripMenuItem();
            criarNovoAcessoToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(0, 192, 192);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gruposToolStripMenuItem, criarNovoAcessoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gruposToolStripMenuItem
            // 
            gruposToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gruposToolStripMenuItem.ForeColor = Color.Black;
            gruposToolStripMenuItem.Margin = new Padding(0, 3, 0, 3);
            gruposToolStripMenuItem.Name = "gruposToolStripMenuItem";
            gruposToolStripMenuItem.Size = new Size(127, 19);
            gruposToolStripMenuItem.Text = "Minhas Informações";
            gruposToolStripMenuItem.Click += gruposToolStripMenuItem_Click;
            // 
            // criarNovoAcessoToolStripMenuItem
            // 
            criarNovoAcessoToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            criarNovoAcessoToolStripMenuItem.Name = "criarNovoAcessoToolStripMenuItem";
            criarNovoAcessoToolStripMenuItem.Size = new Size(116, 25);
            criarNovoAcessoToolStripMenuItem.Text = "Criar Novo Acesso";
            criarNovoAcessoToolStripMenuItem.Click += criarNovoAcessoToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 357);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellContentDoubleClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(12, 46);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Usuário ou Descrição";
            textBoxSearch.Size = new Size(776, 29);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.KeyPress += textBoxSearch_KeyPress;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Index";
            ShowIcon = false;
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gruposToolStripMenuItem;
        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private ToolStripMenuItem criarNovoAcessoToolStripMenuItem;
    }
}