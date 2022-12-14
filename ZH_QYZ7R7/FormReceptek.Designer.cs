namespace WinsowsApp
{
    partial class FormReceptek
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
            this.buttonReceptModositas = new System.Windows.Forms.Button();
            this.buttonUjFogasFelvetele = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonReceptModositas
            // 
            this.buttonReceptModositas.Location = new System.Drawing.Point(12, 74);
            this.buttonReceptModositas.Name = "buttonReceptModositas";
            this.buttonReceptModositas.Size = new System.Drawing.Size(118, 76);
            this.buttonReceptModositas.TabIndex = 0;
            this.buttonReceptModositas.Text = "Recept módosítása";
            this.buttonReceptModositas.UseVisualStyleBackColor = true;
            this.buttonReceptModositas.Click += new System.EventHandler(this.buttonReceptModositas_Click_1);
            // 
            // buttonUjFogasFelvetele
            // 
            this.buttonUjFogasFelvetele.Location = new System.Drawing.Point(12, 227);
            this.buttonUjFogasFelvetele.Name = "buttonUjFogasFelvetele";
            this.buttonUjFogasFelvetele.Size = new System.Drawing.Size(118, 74);
            this.buttonUjFogasFelvetele.TabIndex = 1;
            this.buttonUjFogasFelvetele.Text = "Új fogás felvétele";
            this.buttonUjFogasFelvetele.UseVisualStyleBackColor = true;
            this.buttonUjFogasFelvetele.Click += new System.EventHandler(this.buttonUjFogasFelvetele_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(175, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 500);
            this.panel1.TabIndex = 2;
            // 
            // FormReceptek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUjFogasFelvetele);
            this.Controls.Add(this.buttonReceptModositas);
            this.Name = "FormReceptek";
            this.Text = "FormReceptek";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonReceptModositas;
        private Button buttonUjFogasFelvetele;
        private Panel panel1;
    }
}