namespace WinsowsApp
{
    partial class UCReceptModositas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxFogas = new System.Windows.Forms.TextBox();
            this.labelFogas = new System.Windows.Forms.Label();
            this.listBoxFogas = new System.Windows.Forms.ListBox();
            this.textBoxNyersanyag = new System.Windows.Forms.TextBox();
            this.listBoxNyersanyag = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMennyiseg = new System.Windows.Forms.TextBox();
            this.labelMennyEgys = new System.Windows.Forms.Label();
            this.buttonHozzaadas = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hozzavaloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hozzavaloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nyersanyagokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mennyiseg_4fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EgysegNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ár = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFogas
            // 
            this.textBoxFogas.Location = new System.Drawing.Point(33, 52);
            this.textBoxFogas.Name = "textBoxFogas";
            this.textBoxFogas.Size = new System.Drawing.Size(104, 23);
            this.textBoxFogas.TabIndex = 0;
            this.textBoxFogas.TextChanged += new System.EventHandler(this.textBoxFogas_TextChanged_1);
            // 
            // labelFogas
            // 
            this.labelFogas.AutoSize = true;
            this.labelFogas.Location = new System.Drawing.Point(42, 28);
            this.labelFogas.Name = "labelFogas";
            this.labelFogas.Size = new System.Drawing.Size(41, 15);
            this.labelFogas.TabIndex = 1;
            this.labelFogas.Text = "Fogás:";
            // 
            // listBoxFogas
            // 
            this.listBoxFogas.FormattingEnabled = true;
            this.listBoxFogas.ItemHeight = 15;
            this.listBoxFogas.Location = new System.Drawing.Point(33, 108);
            this.listBoxFogas.Name = "listBoxFogas";
            this.listBoxFogas.Size = new System.Drawing.Size(104, 274);
            this.listBoxFogas.TabIndex = 2;
            this.listBoxFogas.SelectedIndexChanged += new System.EventHandler(this.listBoxFogas_SelectedIndexChanged_1);
            // 
            // textBoxNyersanyag
            // 
            this.textBoxNyersanyag.Location = new System.Drawing.Point(702, 57);
            this.textBoxNyersanyag.Name = "textBoxNyersanyag";
            this.textBoxNyersanyag.Size = new System.Drawing.Size(117, 23);
            this.textBoxNyersanyag.TabIndex = 3;
            this.textBoxNyersanyag.TextChanged += new System.EventHandler(this.textBoxNyersanyag_TextChanged_1);
            // 
            // listBoxNyersanyag
            // 
            this.listBoxNyersanyag.FormattingEnabled = true;
            this.listBoxNyersanyag.ItemHeight = 15;
            this.listBoxNyersanyag.Location = new System.Drawing.Point(702, 108);
            this.listBoxNyersanyag.Name = "listBoxNyersanyag";
            this.listBoxNyersanyag.Size = new System.Drawing.Size(117, 289);
            this.listBoxNyersanyag.TabIndex = 4;
            this.listBoxNyersanyag.SelectedIndexChanged += new System.EventHandler(this.listBoxNyersanyag_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nyrsanyag:";
            // 
            // textBoxMennyiseg
            // 
            this.textBoxMennyiseg.Location = new System.Drawing.Point(708, 420);
            this.textBoxMennyiseg.Name = "textBoxMennyiseg";
            this.textBoxMennyiseg.Size = new System.Drawing.Size(36, 23);
            this.textBoxMennyiseg.TabIndex = 6;
            // 
            // labelMennyEgys
            // 
            this.labelMennyEgys.AutoSize = true;
            this.labelMennyEgys.Location = new System.Drawing.Point(758, 428);
            this.labelMennyEgys.Name = "labelMennyEgys";
            this.labelMennyEgys.Size = new System.Drawing.Size(38, 15);
            this.labelMennyEgys.TabIndex = 7;
            this.labelMennyEgys.Text = "label2";
            // 
            // buttonHozzaadas
            // 
            this.buttonHozzaadas.Location = new System.Drawing.Point(654, 152);
            this.buttonHozzaadas.Name = "buttonHozzaadas";
            this.buttonHozzaadas.Size = new System.Drawing.Size(42, 41);
            this.buttonHozzaadas.TabIndex = 8;
            this.buttonHozzaadas.Text = "+";
            this.buttonHozzaadas.UseVisualStyleBackColor = true;
            this.buttonHozzaadas.Click += new System.EventHandler(this.buttonHozzaadas_Click_1);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(654, 208);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(42, 41);
            this.buttonTorles.TabIndex = 9;
            this.buttonTorles.Text = "-";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.Mennyiseg_4fo,
            this.EgysegNev,
            this.Ár});
            this.dataGridView1.DataSource = this.hozzavaloBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(175, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(473, 330);
            this.dataGridView1.TabIndex = 10;
            // 
            // hozzavaloBindingSource1
            // 
            this.hozzavaloBindingSource1.DataSource = typeof(WinsowsApp.Hozzavalo);
            // 
            // hozzavaloBindingSource
            // 
            this.hozzavaloBindingSource.DataSource = typeof(WinsowsApp.Hozzavalo);
            // 
            // nyersanyagokBindingSource
            // 
            this.nyersanyagokBindingSource.DataSource = typeof(ZH_QYZ7R7.Models.Nyersanyagok);
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            // 
            // Mennyiseg_4fo
            // 
            this.Mennyiseg_4fo.DataPropertyName = "Mennyiseg_4fo";
            this.Mennyiseg_4fo.HeaderText = "Mennyiseg_4fo";
            this.Mennyiseg_4fo.Name = "Mennyiseg_4fo";
            // 
            // EgysegNev
            // 
            this.EgysegNev.DataPropertyName = "EgysegNev";
            this.EgysegNev.HeaderText = "EgysegNev";
            this.EgysegNev.Name = "EgysegNev";
            // 
            // Ár
            // 
            this.Ár.DataPropertyName = "Ár";
            this.Ár.HeaderText = "Ár";
            this.Ár.Name = "Ár";
            // 
            // UCReceptModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonHozzaadas);
            this.Controls.Add(this.labelMennyEgys);
            this.Controls.Add(this.textBoxMennyiseg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNyersanyag);
            this.Controls.Add(this.textBoxNyersanyag);
            this.Controls.Add(this.listBoxFogas);
            this.Controls.Add(this.labelFogas);
            this.Controls.Add(this.textBoxFogas);
            this.Name = "UCReceptModositas";
            this.Size = new System.Drawing.Size(862, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzavaloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFogas;
        private Label labelFogas;
        private ListBox listBoxFogas;
        private TextBox textBoxNyersanyag;
        private ListBox listBoxNyersanyag;
        private Label label1;
        private TextBox textBoxMennyiseg;
        private Label labelMennyEgys;
        private Button buttonHozzaadas;
        private Button buttonTorles;
        private DataGridView dataGridView1;
        private BindingSource hozzavaloBindingSource;
        private BindingSource nyersanyagokBindingSource;
        private BindingSource hozzavaloBindingSource1;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Mennyiseg_4fo;
        private DataGridViewTextBoxColumn EgysegNev;
        private DataGridViewTextBoxColumn Ár;
    }
}
