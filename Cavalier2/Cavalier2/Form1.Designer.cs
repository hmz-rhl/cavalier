namespace Cavalier2
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
            this.label_fin_de_jeu = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.bouton_rejouer = new System.Windows.Forms.Button();
            this.progressBar_partie = new System.Windows.Forms.ProgressBar();
            this.label_progression = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.règleDuJeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_fin_de_jeu
            // 
            this.label_fin_de_jeu.AutoSize = true;
            this.label_fin_de_jeu.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fin_de_jeu.Location = new System.Drawing.Point(632, 219);
            this.label_fin_de_jeu.Name = "label_fin_de_jeu";
            this.label_fin_de_jeu.Size = new System.Drawing.Size(47, 20);
            this.label_fin_de_jeu.TabIndex = 0;
            this.label_fin_de_jeu.Text = "Perdu";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(647, 31);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(87, 25);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "Score :";
            // 
            // bouton_rejouer
            // 
            this.bouton_rejouer.Location = new System.Drawing.Point(652, 395);
            this.bouton_rejouer.Name = "bouton_rejouer";
            this.bouton_rejouer.Size = new System.Drawing.Size(75, 23);
            this.bouton_rejouer.TabIndex = 2;
            this.bouton_rejouer.Text = "Rejouer";
            this.bouton_rejouer.UseVisualStyleBackColor = true;
            this.bouton_rejouer.Click += new System.EventHandler(this.bouton_rejouer_Click);
            // 
            // progressBar_partie
            // 
            this.progressBar_partie.Location = new System.Drawing.Point(95, 464);
            this.progressBar_partie.Maximum = 63;
            this.progressBar_partie.Name = "progressBar_partie";
            this.progressBar_partie.Size = new System.Drawing.Size(100, 23);
            this.progressBar_partie.TabIndex = 3;
            // 
            // label_progression
            // 
            this.label_progression.AutoSize = true;
            this.label_progression.Location = new System.Drawing.Point(21, 474);
            this.label_progression.Name = "label_progression";
            this.label_progression.Size = new System.Drawing.Size(68, 13);
            this.label_progression.TabIndex = 4;
            this.label_progression.Text = "Progression :";
            this.label_progression.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.règleDuJeuToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.paramètresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // règleDuJeuToolStripMenuItem
            // 
            this.règleDuJeuToolStripMenuItem.Name = "règleDuJeuToolStripMenuItem";
            this.règleDuJeuToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.règleDuJeuToolStripMenuItem.Text = "Règle du Jeu";
            this.règleDuJeuToolStripMenuItem.Click += new System.EventHandler(this.règleDuJeuToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 499);
            this.Controls.Add(this.label_progression);
            this.Controls.Add(this.progressBar_partie);
            this.Controls.Add(this.bouton_rejouer);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_fin_de_jeu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_fin_de_jeu;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Button bouton_rejouer;
        private System.Windows.Forms.ProgressBar progressBar_partie;
        private System.Windows.Forms.Label label_progression;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem règleDuJeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

