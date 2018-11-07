namespace Balles
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.balle3 = new Balles.Balle();
            this.balle2 = new Balles.Balle();
            this.balle1 = new Balles.Balle();
            ((System.ComponentModel.ISupportInitialize)(this.balle3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle1)).BeginInit();
            this.SuspendLayout();
            // 
            // balle3
            // 
            this.balle3.BackColor = System.Drawing.Color.Transparent;
            this.balle3.Image = ((System.Drawing.Image)(resources.GetObject("balle3.Image")));
            this.balle3.Location = new System.Drawing.Point(569, 184);
            this.balle3.Name = "balle3";
            this.balle3.Size = new System.Drawing.Size(100, 100);
            this.balle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balle3.TabIndex = 2;
            this.balle3.TabStop = false;
            this.balle3.vitesseX = 10;
            this.balle3.vitesseY = 10;
            // 
            // balle2
            // 
            this.balle2.BackColor = System.Drawing.Color.Transparent;
            this.balle2.Image = ((System.Drawing.Image)(resources.GetObject("balle2.Image")));
            this.balle2.Location = new System.Drawing.Point(357, 184);
            this.balle2.Name = "balle2";
            this.balle2.Size = new System.Drawing.Size(100, 100);
            this.balle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balle2.TabIndex = 1;
            this.balle2.TabStop = false;
            this.balle2.vitesseX = 15;
            this.balle2.vitesseY = 15;
            // 
            // balle1
            // 
            this.balle1.BackColor = System.Drawing.Color.Transparent;
            this.balle1.Image = ((System.Drawing.Image)(resources.GetObject("balle1.Image")));
            this.balle1.Location = new System.Drawing.Point(463, 184);
            this.balle1.Name = "balle1";
            this.balle1.Size = new System.Drawing.Size(100, 100);
            this.balle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.balle1.TabIndex = 0;
            this.balle1.TabStop = false;
            this.balle1.vitesseX = 5;
            this.balle1.vitesseY = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.balle3);
            this.Controls.Add(this.balle2);
            this.Controls.Add(this.balle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balle3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Balle balle1;
        private Balle balle2;
        private Balle balle3;
    }
}

