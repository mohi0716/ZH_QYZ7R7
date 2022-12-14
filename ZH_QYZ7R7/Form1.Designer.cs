namespace ZH_QYZ7R7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonReceptek = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReceptek
            // 
            this.buttonReceptek.Location = new System.Drawing.Point(105, 41);
            this.buttonReceptek.Name = "buttonReceptek";
            this.buttonReceptek.Size = new System.Drawing.Size(210, 137);
            this.buttonReceptek.TabIndex = 0;
            this.buttonReceptek.Text = "Receptek";
            this.buttonReceptek.UseVisualStyleBackColor = true;
            this.buttonReceptek.Click += new System.EventHandler(this.buttonReceptek_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(105, 215);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(210, 137);
            this.buttonExcel.TabIndex = 1;
            this.buttonExcel.Text = "Excelbe importálás";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonReceptek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonReceptek;
        private Button buttonExcel;
    }
}