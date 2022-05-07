using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cavalier2
{
    public partial class Form1 : Form
    {
        Button[,] grille;
        bool[,] etat_grille;
        int nb_case_libre = 0;

        int compteur = 0, x, y;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Jeu de cavalier";
            grille = new Button[8, 8];
            etat_grille = new bool[8, 8];
            label_fin_de_jeu.Text = "";
            bouton_rejouer.Enabled = false;

            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 8; c++)
                {
                    //Création d'un bouton
                    Button b;
                    b = new Button();
                    b.Location = new Point(1 + 50 * c, 40 + 50 * l);
                    b.Size = new Size(50, 50);
                    //b.Text = (l*8+c).ToString();
                    b.Enabled = true;
                    b.Click += new EventHandler(this.grille_click);
                    this.Controls.Add(b);

                    this.grille[l, c] = b;
                    etat_grille[l, c] = false;
                }
            }

        }

        private void bouton_rejouer_Click(object sender, EventArgs e)
        {
            initialisation();
            bouton_rejouer.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moi c'est hamza :)");
        }

        private void règleDuJeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les règles du jeu sont simples il faut parcourir l'ensemble de l'échequier sans passer 2 fois dans la même case. Bonne chance !");
            
        }

        private void initialisation()
        {
            label_fin_de_jeu.Text = "";
            compteur = 0;
            nb_case_libre = 0;
            progressBar_partie.Value = 0;

            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 8; c++)
                {
                    //Création d'un bouton
                 
                    
                    
                    grille[l,c].Text = "";
                    
                    
                    

                    this.grille[l, c].Enabled = true; ;
                    etat_grille[l, c] = false;
                }
            }

        }
        private void grille_click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            for(int l = 0; l < 8; l++)
            {
                for(int c = 0; c < 8; c++)
                {
                    if(grille[l, c] == button)
                    {
                        x = l;
                        y = c;
                        grille[l, c].Text = (++compteur).ToString();
                        
                        etat_grille[l, c] = true;
                        grille[l, c].Enabled = false;

                    }
                    else
                    {
                        grille[l, c].Enabled = false;
                    }
                }
            }

            if (x < 7 && y < 6)
            {

                if (etat_grille[x + 1, y + 2] == false)
                {
                    grille[x + 1, y + 2].Enabled = true;
                    nb_case_libre++;

                }
            }

            if(x < 7 && y > 1)
            {

                if (etat_grille[x + 1, y - 2] == false)
                {
                    grille[x + 1, y - 2].Enabled = true;
                    nb_case_libre++;

                }
            }

            if (x > 0 && y < 6)
            {

                if (etat_grille[x - 1, y + 2] == false)
                {
                    grille[x - 1, y + 2].Enabled = true;
                    nb_case_libre++;

                }
            }

            if(x > 0 && y > 1)
            {
                if (etat_grille[x - 1, y - 2] == false )
                {
                    grille[x - 1, y - 2].Enabled = true;
                    nb_case_libre++;

                }

            }


            if(x < 6 && y < 7)
            {

                if (etat_grille[x + 2, y + 1] == false)
                {
                    grille[x + 2, y + 1].Enabled = true;
                    nb_case_libre++;

                }
            }

            if(x < 6 && y > 0)
            {

                if (etat_grille[x + 2, y - 1] == false)
                {
                    grille[x + 2, y - 1].Enabled = true;
                    nb_case_libre++;

                }
            }

            if(x > 1 && y < 7)
            {

                if (etat_grille[x - 2, y + 1] == false )
                {
                    grille[x - 2, y + 1].Enabled = true;
                    nb_case_libre++;

                }
            }

            if(x > 1 && y > 0)
            {

                if (etat_grille[x - 2, y - 1] == false)
                {
                    grille[x - 2, y - 1].Enabled = true;
                    nb_case_libre++;

                }
            }

            if(nb_case_libre == 0 && compteur != 64)
            {
                label_fin_de_jeu.Text = "PERDU";
                label_fin_de_jeu.ForeColor = Color.IndianRed;
                

            }
            else
            {
                nb_case_libre = 0;
                label_score.Text = "Score : " + (compteur).ToString();
                progressBar_partie.Value = compteur;
            }

            if(compteur > 0) bouton_rejouer.Enabled = true;

        }

    }
}
