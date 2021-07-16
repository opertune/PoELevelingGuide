using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace PoELevelingGuide
{
    public partial class formProfil : Form
    {
        // Déclaration collection de profile
        public static List<Profile> profiles;
        public static int index;
        public formProfil()
        {
            InitializeComponent();
            profiles = new List<Profile>();
        }

        /*
         * Controle du design des bouttons
         */
        private void design()
        {
            BackColor = Color.FromArgb(40, 40, 40);
            btnAdd.BackColor = Color.FromArgb(40, 40, 40);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 83, 83);
            btnDelete.BackColor = Color.FromArgb(40, 40, 40);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(83, 83, 83);
        }

        /*
         * Chargement de la fenetre
         */
        private void formProfil_Load(object sender, EventArgs e)
        {
            design();
            // Récupération des nom de profiles, num quete et num act
            Object deserialize = Save.Recup(formQuete.save);
            if(deserialize != null)
            {
                profiles = ((List<Profile>)deserialize);
            }
            foreach (Profile p in profiles)
            {
                lstProfiles.Items.Add(p.getName());
            }
        }

        /*
         * Si la page de choix de profil est fermé, l'application se ferme
         */
        private void formProfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lstProfiles.SelectedIndex == -1)
            {
                System.Environment.Exit(0);
            }
        }

        /*
         * Ajout d'un profile
         * Ouvre une page pour saisir un nom de profile
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Affichage de la fenetre pour saisir un nom de profil
            formAdd add = new formAdd();
            add.ShowDialog();
            // Ajout du nouveau profile dans la listbox
            Profile profile = new Profile(add.txtProfileName.Text, 0, 0, "", "");
            lstProfiles.Items.Add(profile.getName());
            // Serialize la list contenant les nom, num quete et num act
            Save.Sauve(formQuete.save, profiles);
        }

        /*
         * Supression d'un profile
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstProfiles.SelectedIndex != -1)
            {
                // Suppression de l'image de l'arbre de talent si elle existe
                string path = Application.StartupPath + "\\images\\" + formProfil.profiles[lstProfiles.SelectedIndex].getName() + ".jpeg";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                profiles.RemoveAt(lstProfiles.SelectedIndex);
                // Mise à jour de la sauvegarde
                Save.Sauve(formQuete.save, profiles);
                lstProfiles.Items.Remove(lstProfiles.SelectedItem);
            }
        }
        /*
         * Selection d'un profile
         */
        private void lstProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lstProfiles.SelectedIndex != -1)
            {
                index = lstProfiles.SelectedIndex;
                Close();
            }
        }
    }
}
