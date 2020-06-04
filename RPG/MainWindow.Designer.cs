namespace RPG
{
    partial class RPG
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.historyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.critMultiplier = new System.Windows.Forms.NumericUpDown();
            this.defendButton = new System.Windows.Forms.Button();
            this.attackMagicButton = new System.Windows.Forms.Button();
            this.attackMeleeButton = new System.Windows.Forms.Button();
            this.battleLogFeed = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.critMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.historyButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.critMultiplier);
            this.groupBox1.Controls.Add(this.defendButton);
            this.groupBox1.Controls.Add(this.attackMagicButton);
            this.groupBox1.Controls.Add(this.attackMeleeButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 681);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zaklęcia";
            // 
            // historyButton
            // 
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.historyButton.Image = global::RPG.Properties.Resources.Scroll_Feather_icon;
            this.historyButton.Location = new System.Drawing.Point(21, 570);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(104, 95);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "Historia";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Krytyk:";
            // 
            // critMultiplier
            // 
            this.critMultiplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.critMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.critMultiplier.ForeColor = System.Drawing.SystemColors.Window;
            this.critMultiplier.Location = new System.Drawing.Point(22, 454);
            this.critMultiplier.Name = "critMultiplier";
            this.critMultiplier.Size = new System.Drawing.Size(103, 24);
            this.critMultiplier.TabIndex = 3;
            this.critMultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // defendButton
            // 
            this.defendButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.defendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defendButton.Image = global::RPG.Properties.Resources.shield_icon;
            this.defendButton.Location = new System.Drawing.Point(20, 287);
            this.defendButton.Name = "defendButton";
            this.defendButton.Size = new System.Drawing.Size(104, 95);
            this.defendButton.TabIndex = 2;
            this.defendButton.Text = "E";
            this.defendButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.defendButton.UseVisualStyleBackColor = true;
            this.defendButton.Click += new System.EventHandler(this.defendButton_Click);
            // 
            // attackMagicButton
            // 
            this.attackMagicButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attackMagicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackMagicButton.Image = global::RPG.Properties.Resources._42697_fire_icon;
            this.attackMagicButton.Location = new System.Drawing.Point(20, 156);
            this.attackMagicButton.Name = "attackMagicButton";
            this.attackMagicButton.Size = new System.Drawing.Size(104, 95);
            this.attackMagicButton.TabIndex = 1;
            this.attackMagicButton.Text = "W";
            this.attackMagicButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.attackMagicButton.UseVisualStyleBackColor = true;
            this.attackMagicButton.Click += new System.EventHandler(this.attackMagicButton_Click);
            // 
            // attackMeleeButton
            // 
            this.attackMeleeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.attackMeleeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.attackMeleeButton.ForeColor = System.Drawing.Color.White;
            this.attackMeleeButton.Image = global::RPG.Properties.Resources._62963_crossed_swords_icon;
            this.attackMeleeButton.Location = new System.Drawing.Point(21, 19);
            this.attackMeleeButton.Name = "attackMeleeButton";
            this.attackMeleeButton.Size = new System.Drawing.Size(103, 103);
            this.attackMeleeButton.TabIndex = 0;
            this.attackMeleeButton.Text = "Q";
            this.attackMeleeButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.attackMeleeButton.UseVisualStyleBackColor = true;
            this.attackMeleeButton.Click += new System.EventHandler(this.attackMeleeButton_Click);
            // 
            // battleLogFeed
            // 
            this.battleLogFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.battleLogFeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.battleLogFeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.battleLogFeed.ForeColor = System.Drawing.SystemColors.Window;
            this.battleLogFeed.Location = new System.Drawing.Point(141, 507);
            this.battleLogFeed.Multiline = true;
            this.battleLogFeed.Name = "battleLogFeed";
            this.battleLogFeed.ReadOnly = true;
            this.battleLogFeed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.battleLogFeed.Size = new System.Drawing.Size(909, 174);
            this.battleLogFeed.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::RPG.Properties.Resources.DUNGEONS_AND_DRAGONS_fantasy_adventure_board_rpg_dungeons_dragons_055_4_Size_Home_Decoration_Canvas_Poster_jpg_640x640;
            this.pictureBox1.Location = new System.Drawing.Point(141, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // RPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1051, 682);
            this.Controls.Add(this.battleLogFeed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "RPG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RPG_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RPG_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.critMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button defendButton;
        private System.Windows.Forms.Button attackMagicButton;
        private System.Windows.Forms.Button attackMeleeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown critMultiplier;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox battleLogFeed;
    }
}

