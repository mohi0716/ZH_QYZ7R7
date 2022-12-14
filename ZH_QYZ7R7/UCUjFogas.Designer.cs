namespace WinsowsApp
{
    partial class UCUjFogas
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
            this.textBoxFogasNev = new System.Windows.Forms.TextBox();
            this.textBoxLeiras = new System.Windows.Forms.TextBox();
            this.buttonHozzaadas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFogasNev
            // 
            this.textBoxFogasNev.Location = new System.Drawing.Point(21, 58);
            this.textBoxFogasNev.Name = "textBoxFogasNev";
            this.textBoxFogasNev.Size = new System.Drawing.Size(100, 23);
            this.textBoxFogasNev.TabIndex = 0;
            this.textBoxFogasNev.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFogasNev_Validating_1);
            this.textBoxFogasNev.Validated += new System.EventHandler(this.textBoxFogasNev_Validated_1);
            // 
            // textBoxLeiras
            // 
            this.textBoxLeiras.Location = new System.Drawing.Point(21, 145);
            this.textBoxLeiras.Multiline = true;
            this.textBoxLeiras.Name = "textBoxLeiras";
            this.textBoxLeiras.Size = new System.Drawing.Size(386, 188);
            this.textBoxLeiras.TabIndex = 1;
            // 
            // buttonHozzaadas
            // 
            this.buttonHozzaadas.Location = new System.Drawing.Point(259, 28);
            this.buttonHozzaadas.Name = "buttonHozzaadas";
            this.buttonHozzaadas.Size = new System.Drawing.Size(148, 80);
            this.buttonHozzaadas.TabIndex = 2;
            this.buttonHozzaadas.Text = "button1";
            this.buttonHozzaadas.UseVisualStyleBackColor = true;
            this.buttonHozzaadas.Click += new System.EventHandler(this.buttonHozzaadas_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Új fogás neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Leírás";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCUjFogas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHozzaadas);
            this.Controls.Add(this.textBoxLeiras);
            this.Controls.Add(this.textBoxFogasNev);
            this.Name = "UCUjFogas";
            this.Size = new System.Drawing.Size(467, 358);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFogasNev;
        private TextBox textBoxLeiras;
        private Button buttonHozzaadas;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}
