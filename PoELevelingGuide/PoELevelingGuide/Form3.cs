using System;
using System.Drawing;
using System.Windows.Forms;

namespace PoELevelingGuide
{
    public partial class formAdd : Form
    {
        public formAdd()
        {
            InitializeComponent();
        }

        private void formAdd_Load(object sender, EventArgs e)
        {
            // Design de la page
            BackColor = Color.FromArgb(40, 40, 40);
            btnValider.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnValider.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
        }

        /*
         * Module de controle
         * Recherche si le pseudo saisie existe déjà ou non
         */
        private bool controle()
        {
            foreach (Profile p in formProfil.profiles)
            {
                if (p.getName() == txtProfileName.Text)
                {
                    return false;
                }
            }
            return true;
        }
        /*
         * Ajout d'un nouveau profile dans la collection et la listbox de la formProfile
         * Affichage d'un message d'erreur et désactivation du boutton valider si le pseudo existe déjà
         */
        private void btnValider_Click(object sender, EventArgs e)
        {
            if ((txtProfileName.Text != "") && (controle() == true))
            {
                // Ajoute un nouveau profile dans la collection
                Profile p = new Profile(txtProfileName.Text, 0, 0, "", "");
                formProfil.profiles.Add(p);
                Close();
            }
            else
            {
                btnValider.Enabled = false;
                lblError.Text = "Nickname already exists";
            }
        }
        // Reactive le bouton valider et efface le message d'erreur quand l'utilisateur modifie la zone de saisie
        private void txtProfileName_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = "";
            btnValider.Enabled = true;
        }
    }
}
