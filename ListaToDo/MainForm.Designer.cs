namespace ListaToDo
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearSelectedButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClearFinishedButton = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.MenuStrip();
            this.Opts = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 52);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(214, 52);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 20);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearSelectedButton
            // 
            this.ClearSelectedButton.Location = new System.Drawing.Point(12, 467);
            this.ClearSelectedButton.Name = "ClearSelectedButton";
            this.ClearSelectedButton.Size = new System.Drawing.Size(75, 23);
            this.ClearSelectedButton.TabIndex = 4;
            this.ClearSelectedButton.Text = "Usuń";
            this.ClearSelectedButton.UseVisualStyleBackColor = true;
            this.ClearSelectedButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 383);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClearFinishedButton
            // 
            this.ClearFinishedButton.Location = new System.Drawing.Point(93, 467);
            this.ClearFinishedButton.Name = "ClearFinishedButton";
            this.ClearFinishedButton.Size = new System.Drawing.Size(131, 23);
            this.ClearFinishedButton.TabIndex = 6;
            this.ClearFinishedButton.Text = "Usuń ukończone";
            this.ClearFinishedButton.UseVisualStyleBackColor = true;
            this.ClearFinishedButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Options
            // 
            this.Options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Opts});
            this.Options.Location = new System.Drawing.Point(0, 0);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(587, 24);
            this.Options.TabIndex = 7;
            this.Options.Text = "Opcje";
            this.Options.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Opts
            // 
            this.Opts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaToolStripMenuItem,
            this.importujToolStripMenuItem,
            this.wyjdźToolStripMenuItem});
            this.Opts.Name = "Opts";
            this.Opts.Size = new System.Drawing.Size(50, 20);
            this.Opts.Text = "Opcje";
            this.Opts.Click += new System.EventHandler(this.Import_Click);
            // 
            // nowaToolStripMenuItem
            // 
            this.nowaToolStripMenuItem.Name = "nowaToolStripMenuItem";
            this.nowaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.nowaToolStripMenuItem.Text = "Nowa...";
            this.nowaToolStripMenuItem.Click += new System.EventHandler(this.nowaToolStripMenuItem_Click);
            // 
            // importujToolStripMenuItem
            // 
            this.importujToolStripMenuItem.Name = "importujToolStripMenuItem";
            this.importujToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.importujToolStripMenuItem.Text = "Importuj...";
            this.importujToolStripMenuItem.Click += new System.EventHandler(this.importujToolStripMenuItem_Click);
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            this.wyjdźToolStripMenuItem.Click += new System.EventHandler(this.wyjdźToolStripMenuItem_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(451, 467);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(114, 23);
            this.ClearListButton.TabIndex = 8;
            this.ClearListButton.Text = "Wyczyść listę";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 560);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.ClearFinishedButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ClearSelectedButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearSelectedButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearFinishedButton;
        private System.Windows.Forms.MenuStrip Options;
        private System.Windows.Forms.ToolStripMenuItem Opts;
        private System.Windows.Forms.ToolStripMenuItem importujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjdźToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaToolStripMenuItem;
        private System.Windows.Forms.Button ClearListButton;
    }
}

