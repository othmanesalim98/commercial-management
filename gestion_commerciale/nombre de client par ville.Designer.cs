namespace gestion_commerciale
{
    partial class nombre_de_client_par_ville
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
            this.comboBox_ville = new System.Windows.Forms.ComboBox();
            this.label_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ville:";
            // 
            // comboBox_ville
            // 
            this.comboBox_ville.FormattingEnabled = true;
            this.comboBox_ville.Location = new System.Drawing.Point(322, 166);
            this.comboBox_ville.Name = "comboBox_ville";
            this.comboBox_ville.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ville.TabIndex = 1;
            this.comboBox_ville.SelectedIndexChanged += new System.EventHandler(this.comboBox_ville_SelectedIndexChanged);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(355, 228);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(35, 13);
            this.label_count.TabIndex = 2;
            this.label_count.Text = "Count";
            this.label_count.Click += new System.EventHandler(this.label_count_Click);
            // 
            // nombre_de_client_par_ville
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.comboBox_ville);
            this.Controls.Add(this.label1);
            this.Name = "nombre_de_client_par_ville";
            this.Text = "nombre_de_client_par_ville";
            this.Load += new System.EventHandler(this.nombre_de_client_par_ville_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ville;
        private System.Windows.Forms.Label label_count;
    }
}