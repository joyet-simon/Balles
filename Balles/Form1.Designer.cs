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
            this.balle1 = new Balles.Balle();
            ((System.ComponentModel.ISupportInitialize)(this.balle1)).BeginInit();
            this.SuspendLayout();
            // 
            // balle1
            // 
            this.balle1.Image = ((System.Drawing.Image)(resources.GetObject("balle1.Image")));
            this.balle1.Location = new System.Drawing.Point(535, 192);
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
            this.Controls.Add(this.balle1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.balle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Balle balle1;
    }
}

