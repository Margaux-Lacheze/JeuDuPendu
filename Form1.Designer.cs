
namespace Pendu
{
    partial class Pendu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pendu));
            this.imgPendu = new System.Windows.Forms.PictureBox();
            this.txtMot = new System.Windows.Forms.TextBox();
            this.lblMot = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLettre = new System.Windows.Forms.ComboBox();
            this.lblLettre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.imgRecommencer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecommencer)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPendu
            // 
            this.imgPendu.Image = ((System.Drawing.Image)(resources.GetObject("imgPendu.Image")));
            this.imgPendu.Location = new System.Drawing.Point(278, 11);
            this.imgPendu.Name = "imgPendu";
            this.imgPendu.Size = new System.Drawing.Size(250, 250);
            this.imgPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPendu.TabIndex = 0;
            this.imgPendu.TabStop = false;
            // 
            // txtMot
            // 
            this.txtMot.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMot.Location = new System.Drawing.Point(11, 28);
            this.txtMot.Name = "txtMot";
            this.txtMot.Size = new System.Drawing.Size(202, 23);
            this.txtMot.TabIndex = 1;
            // 
            // lblMot
            // 
            this.lblMot.AutoSize = true;
            this.lblMot.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMot.Location = new System.Drawing.Point(6, 0);
            this.lblMot.Name = "lblMot";
            this.lblMot.Size = new System.Drawing.Size(131, 18);
            this.lblMot.TabIndex = 2;
            this.lblMot.Text = "Mot à trouver :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMot);
            this.groupBox1.Controls.Add(this.txtMot);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cboLettre
            // 
            this.cboLettre.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLettre.FormattingEnabled = true;
            this.cboLettre.Location = new System.Drawing.Point(9, 21);
            this.cboLettre.Name = "cboLettre";
            this.cboLettre.Size = new System.Drawing.Size(60, 24);
            this.cboLettre.TabIndex = 4;
            // 
            // lblLettre
            // 
            this.lblLettre.AutoSize = true;
            this.lblLettre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettre.Location = new System.Drawing.Point(6, 0);
            this.lblLettre.Name = "lblLettre";
            this.lblLettre.Size = new System.Drawing.Size(70, 18);
            this.lblLettre.TabIndex = 5;
            this.lblLettre.Text = "Lettre :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnvoyer);
            this.groupBox2.Controls.Add(this.cboLettre);
            this.groupBox2.Controls.Add(this.lblLettre);
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.Location = new System.Drawing.Point(97, 22);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyer.TabIndex = 7;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            // 
            // imgRecommencer
            // 
            this.imgRecommencer.Image = ((System.Drawing.Image)(resources.GetObject("imgRecommencer.Image")));
            this.imgRecommencer.Location = new System.Drawing.Point(191, 197);
            this.imgRecommencer.Name = "imgRecommencer";
            this.imgRecommencer.Size = new System.Drawing.Size(48, 44);
            this.imgRecommencer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRecommencer.TabIndex = 7;
            this.imgRecommencer.TabStop = false;
            // 
            // Pendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 273);
            this.Controls.Add(this.imgRecommencer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imgPendu);
            this.Name = "Pendu";
            this.Text = "Jeu du Pendu";
            this.Load += new System.EventHandler(this.Pendu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPendu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRecommencer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPendu;
        private System.Windows.Forms.TextBox txtMot;
        private System.Windows.Forms.Label lblMot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLettre;
        private System.Windows.Forms.Label lblLettre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.PictureBox imgRecommencer;
    }
}

