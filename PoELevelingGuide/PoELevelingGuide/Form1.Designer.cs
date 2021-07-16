namespace PoELevelingGuide
{
    partial class formQuete
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
            this.txtQuete = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbbAct = new System.Windows.Forms.ComboBox();
            this.imgQuete = new System.Windows.Forms.PictureBox();
            this.btnQuete = new System.Windows.Forms.Button();
            this.btnGem = new System.Windows.Forms.Button();
            this.txtGems = new System.Windows.Forms.TextBox();
            this.lblGems = new System.Windows.Forms.Label();
            this.lblTalents = new System.Windows.Forms.Label();
            this.btnChangerProfil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgTalentTree = new System.Windows.Forms.PictureBox();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.lblLoadTree = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuete)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTalentTree)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuete
            // 
            this.txtQuete.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuete.ForeColor = System.Drawing.Color.White;
            this.txtQuete.Location = new System.Drawing.Point(12, 44);
            this.txtQuete.Multiline = true;
            this.txtQuete.Name = "txtQuete";
            this.txtQuete.ReadOnly = true;
            this.txtQuete.Size = new System.Drawing.Size(368, 301);
            this.txtQuete.TabIndex = 0;
            this.txtQuete.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(232, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(353, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(29, 29);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbbAct
            // 
            this.cbbAct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbAct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAct.ForeColor = System.Drawing.Color.White;
            this.cbbAct.FormattingEnabled = true;
            this.cbbAct.Location = new System.Drawing.Point(267, 10);
            this.cbbAct.Name = "cbbAct";
            this.cbbAct.Size = new System.Drawing.Size(80, 27);
            this.cbbAct.TabIndex = 3;
            this.cbbAct.SelectionChangeCommitted += new System.EventHandler(this.cbbAct_SelectionChangeCommitted);
            // 
            // imgQuete
            // 
            this.imgQuete.Location = new System.Drawing.Point(384, 44);
            this.imgQuete.Name = "imgQuete";
            this.imgQuete.Size = new System.Drawing.Size(434, 301);
            this.imgQuete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgQuete.TabIndex = 4;
            this.imgQuete.TabStop = false;
            // 
            // btnQuete
            // 
            this.btnQuete.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuete.ForeColor = System.Drawing.Color.White;
            this.btnQuete.Location = new System.Drawing.Point(12, 15);
            this.btnQuete.Name = "btnQuete";
            this.btnQuete.Size = new System.Drawing.Size(75, 27);
            this.btnQuete.TabIndex = 5;
            this.btnQuete.Text = "Quêtes";
            this.btnQuete.UseVisualStyleBackColor = false;
            this.btnQuete.Click += new System.EventHandler(this.btnQuete_Click);
            // 
            // btnGem
            // 
            this.btnGem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGem.ForeColor = System.Drawing.Color.White;
            this.btnGem.Location = new System.Drawing.Point(93, 15);
            this.btnGem.Name = "btnGem";
            this.btnGem.Size = new System.Drawing.Size(75, 27);
            this.btnGem.TabIndex = 6;
            this.btnGem.Text = "Build";
            this.btnGem.UseVisualStyleBackColor = true;
            this.btnGem.Click += new System.EventHandler(this.btnGem_Click);
            // 
            // txtGems
            // 
            this.txtGems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGems.Font = new System.Drawing.Font("Arial", 12F);
            this.txtGems.Location = new System.Drawing.Point(12, 64);
            this.txtGems.Multiline = true;
            this.txtGems.Name = "txtGems";
            this.txtGems.Size = new System.Drawing.Size(400, 257);
            this.txtGems.TabIndex = 7;
            // 
            // lblGems
            // 
            this.lblGems.AutoSize = true;
            this.lblGems.Location = new System.Drawing.Point(12, 48);
            this.lblGems.Name = "lblGems";
            this.lblGems.Size = new System.Drawing.Size(34, 13);
            this.lblGems.TabIndex = 9;
            this.lblGems.Text = "Gems";
            // 
            // lblTalents
            // 
            this.lblTalents.AutoSize = true;
            this.lblTalents.Location = new System.Drawing.Point(418, 48);
            this.lblTalents.Name = "lblTalents";
            this.lblTalents.Size = new System.Drawing.Size(42, 13);
            this.lblTalents.TabIndex = 10;
            this.lblTalents.Text = "Talents";
            // 
            // btnChangerProfil
            // 
            this.btnChangerProfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChangerProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangerProfil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangerProfil.ForeColor = System.Drawing.Color.White;
            this.btnChangerProfil.Location = new System.Drawing.Point(645, 7);
            this.btnChangerProfil.Name = "btnChangerProfil";
            this.btnChangerProfil.Size = new System.Drawing.Size(173, 27);
            this.btnChangerProfil.TabIndex = 12;
            this.btnChangerProfil.Text = "Changer de profil";
            this.btnChangerProfil.UseVisualStyleBackColor = false;
            this.btnChangerProfil.Click += new System.EventHandler(this.btnChangerProfil_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imgTalentTree);
            this.panel1.Location = new System.Drawing.Point(421, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 257);
            this.panel1.TabIndex = 13;
            // 
            // imgTalentTree
            // 
            this.imgTalentTree.Location = new System.Drawing.Point(3, 3);
            this.imgTalentTree.Name = "imgTalentTree";
            this.imgTalentTree.Size = new System.Drawing.Size(386, 251);
            this.imgTalentTree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgTalentTree.TabIndex = 0;
            this.imgTalentTree.TabStop = false;
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadImg.ForeColor = System.Drawing.Color.White;
            this.btnLoadImg.Location = new System.Drawing.Point(421, 34);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(75, 27);
            this.btnLoadImg.TabIndex = 14;
            this.btnLoadImg.Text = "Load Tree";
            this.btnLoadImg.UseVisualStyleBackColor = false;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // lblLoadTree
            // 
            this.lblLoadTree.AutoSize = true;
            this.lblLoadTree.Location = new System.Drawing.Point(502, 42);
            this.lblLoadTree.Name = "lblLoadTree";
            this.lblLoadTree.Size = new System.Drawing.Size(209, 13);
            this.lblLoadTree.TabIndex = 15;
            this.lblLoadTree.Text = "Charger une image de votre arbre de talent";
            // 
            // formQuete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(825, 356);
            this.Controls.Add(this.lblLoadTree);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChangerProfil);
            this.Controls.Add(this.lblTalents);
            this.Controls.Add(this.lblGems);
            this.Controls.Add(this.txtGems);
            this.Controls.Add(this.btnGem);
            this.Controls.Add(this.btnQuete);
            this.Controls.Add(this.imgQuete);
            this.Controls.Add(this.cbbAct);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtQuete);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(841, 395);
            this.MinimumSize = new System.Drawing.Size(841, 395);
            this.Name = "formQuete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quests";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formQuete_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgQuete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTalentTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cbbAct;
        private System.Windows.Forms.PictureBox imgQuete;
        private System.Windows.Forms.Button btnQuete;
        private System.Windows.Forms.Button btnGem;
        private System.Windows.Forms.TextBox txtGems;
        private System.Windows.Forms.Label lblGems;
        private System.Windows.Forms.Label lblTalents;
        private System.Windows.Forms.Button btnChangerProfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgTalentTree;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.Label lblLoadTree;
    }
}

