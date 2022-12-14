namespace WinsowsApp
{
    partial class FormUjRecept
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonHozzaadas = new System.Windows.Forms.Button();
            this.labelMennyEgys = new System.Windows.Forms.Label();
            this.textBoxMennyiseg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxNyersanyag = new System.Windows.Forms.ListBox();
            this.textBoxNyersanyag = new System.Windows.Forms.TextBox();
            this.labelUjFogas = new System.Windows.Forms.Label();
            this.hozzavaloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.egysegNevDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzavaloBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(473, 330);
            this.dataGridView1.TabIndex = 18;
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(487, 184);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(42, 41);
            this.buttonTorles.TabIndex = 17;
            this.buttonTorles.Text = "-";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click_1);
            // 
            // buttonHozzaadas
            // 
            this.buttonHozzaadas.Location = new System.Drawing.Point(487, 128);
            this.buttonHozzaadas.Name = "buttonHozzaadas";
            this.buttonHozzaadas.Size = new System.Drawing.Size(42, 41);
            this.buttonHozzaadas.TabIndex = 16;
            this.buttonHozzaadas.Text = "+";
            this.buttonHozzaadas.UseVisualStyleBackColor = true;
            this.buttonHozzaadas.Click += new System.EventHandler(this.buttonHozzaadas_Click_1);
            // 
            // labelMennyEgys
            // 
            this.labelMennyEgys.AutoSize = true;
            this.labelMennyEgys.Location = new System.Drawing.Point(577, 382);
            this.labelMennyEgys.Name = "labelMennyEgys";
            this.labelMennyEgys.Size = new System.Drawing.Size(38, 15);
            this.labelMennyEgys.TabIndex = 15;
            this.labelMennyEgys.Text = "label2";
            // 
            // textBoxMennyiseg
            // 
            this.textBoxMennyiseg.Location = new System.Drawing.Point(535, 379);
            this.textBoxMennyiseg.Name = "textBoxMennyiseg";
            this.textBoxMennyiseg.Size = new System.Drawing.Size(36, 23);
            this.textBoxMennyiseg.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nyrsanyag:";
            // 
            // listBoxNyersanyag
            // 
            this.listBoxNyersanyag.FormattingEnabled = true;
            this.listBoxNyersanyag.ItemHeight = 15;
            this.listBoxNyersanyag.Location = new System.Drawing.Point(535, 84);
            this.listBoxNyersanyag.Name = "listBoxNyersanyag";
            this.listBoxNyersanyag.Size = new System.Drawing.Size(117, 289);
            this.listBoxNyersanyag.TabIndex = 12;
            this.listBoxNyersanyag.SelectedIndexChanged += new System.EventHandler(this.listBoxNyersanyag_SelectedIndexChanged_1);
            // 
            // textBoxNyersanyag
            // 
            this.textBoxNyersanyag.Location = new System.Drawing.Point(535, 33);
            this.textBoxNyersanyag.Name = "textBoxNyersanyag";
            this.textBoxNyersanyag.Size = new System.Drawing.Size(117, 23);
            this.textBoxNyersanyag.TabIndex = 11;
            this.textBoxNyersanyag.TextChanged += new System.EventHandler(this.textBoxNyersanyag_TextChanged_1);
            // 
            // labelUjFogas
            // 
            this.labelUjFogas.AutoSize = true;
            this.labelUjFogas.Location = new System.Drawing.Point(25, 11);
            this.labelUjFogas.Name = "labelUjFogas";
            this.labelUjFogas.Size = new System.Drawing.Size(38, 15);
            this.labelUjFogas.TabIndex = 19;
            this.labelUjFogas.Text = "label2";
            // 
            // hozzavaloBindingSource
            // 
            this.hozzavaloBindingSource.DataSource = typeof(WinsowsApp.Hozzavalo);
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            this.egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.HeaderText = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            // 
            // FormUjRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 415);
            this.Controls.Add(this.labelUjFogas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonHozzaadas);
            this.Controls.Add(this.labelMennyEgys);
            this.Controls.Add(this.textBoxMennyiseg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNyersanyag);
            this.Controls.Add(this.textBoxNyersanyag);
            this.Name = "FormUjRecept";
            this.Text = "FormUjRecept";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonTorles;
        private Button buttonHozzaadas;
        private Label labelMennyEgys;
        private TextBox textBoxMennyiseg;
        private Label label1;
        private ListBox listBoxNyersanyag;
        private TextBox textBoxNyersanyag;
        private Label labelUjFogas;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
        private BindingSource hozzavaloBindingSource;
    }
}