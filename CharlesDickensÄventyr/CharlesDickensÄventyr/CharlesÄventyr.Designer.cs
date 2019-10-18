namespace CharlesDickensÄventyr
{
    partial class CharlesÄventyr
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
            this.upButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.gameTextBox = new System.Windows.Forms.RichTextBox();
            this.gearCombo = new System.Windows.Forms.ComboBox();
            this.gearLabel = new System.Windows.Forms.Label();
            this.atkButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextLabel = new System.Windows.Forms.Label();
            this.healthTextLabel = new System.Windows.Forms.Label();
            this.levelTextLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.enemyHealthText = new System.Windows.Forms.Label();
            this.enemyHealth = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.cavePic = new System.Windows.Forms.PictureBox();
            this.cryptPic = new System.Windows.Forms.PictureBox();
            this.gravePic = new System.Windows.Forms.PictureBox();
            this.clearPic = new System.Windows.Forms.PictureBox();
            this.woodsPic = new System.Windows.Forms.PictureBox();
            this.grassPic = new System.Windows.Forms.PictureBox();
            this.gardenPic = new System.Windows.Forms.PictureBox();
            this.startPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cavePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gardenPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPic)).BeginInit();
            this.SuspendLayout();
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(101, 411);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 38);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.leftButton.Location = new System.Drawing.Point(12, 462);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(74, 37);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(101, 520);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 37);
            this.downButton.TabIndex = 2;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(197, 462);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(74, 37);
            this.rightButton.TabIndex = 3;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // gameTextBox
            // 
            this.gameTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTextBox.ForeColor = System.Drawing.Color.Red;
            this.gameTextBox.Location = new System.Drawing.Point(331, 252);
            this.gameTextBox.Name = "gameTextBox";
            this.gameTextBox.ReadOnly = true;
            this.gameTextBox.Size = new System.Drawing.Size(320, 358);
            this.gameTextBox.TabIndex = 4;
            this.gameTextBox.Text = "";
            // 
            // gearCombo
            // 
            this.gearCombo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gearCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gearCombo.ForeColor = System.Drawing.Color.Red;
            this.gearCombo.FormattingEnabled = true;
            this.gearCombo.Location = new System.Drawing.Point(90, 46);
            this.gearCombo.Name = "gearCombo";
            this.gearCombo.Size = new System.Drawing.Size(135, 24);
            this.gearCombo.TabIndex = 5;
            // 
            // gearLabel
            // 
            this.gearLabel.AutoSize = true;
            this.gearLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gearLabel.Location = new System.Drawing.Point(21, 49);
            this.gearLabel.Name = "gearLabel";
            this.gearLabel.Size = new System.Drawing.Size(51, 13);
            this.gearLabel.TabIndex = 7;
            this.gearLabel.Text = "Weapon:";
            // 
            // atkButton
            // 
            this.atkButton.Location = new System.Drawing.Point(101, 462);
            this.atkButton.Name = "atkButton";
            this.atkButton.Size = new System.Drawing.Size(75, 37);
            this.atkButton.TabIndex = 10;
            this.atkButton.Text = "Attack";
            this.atkButton.UseVisualStyleBackColor = true;
            this.atkButton.Click += new System.EventHandler(this.atkButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.Red;
            this.locationLabel.Location = new System.Drawing.Point(403, 198);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(121, 22);
            this.locationLabel.TabIndex = 11;
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationTextLabel
            // 
            this.locationTextLabel.AutoSize = true;
            this.locationTextLabel.ForeColor = System.Drawing.Color.Red;
            this.locationTextLabel.Location = new System.Drawing.Point(352, 207);
            this.locationTextLabel.Name = "locationTextLabel";
            this.locationTextLabel.Size = new System.Drawing.Size(51, 13);
            this.locationTextLabel.TabIndex = 13;
            this.locationTextLabel.Text = "Location:";
            // 
            // healthTextLabel
            // 
            this.healthTextLabel.AutoSize = true;
            this.healthTextLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.healthTextLabel.Location = new System.Drawing.Point(21, 101);
            this.healthTextLabel.Name = "healthTextLabel";
            this.healthTextLabel.Size = new System.Drawing.Size(41, 13);
            this.healthTextLabel.TabIndex = 15;
            this.healthTextLabel.Text = "Health:";
            // 
            // levelTextLabel
            // 
            this.levelTextLabel.AutoSize = true;
            this.levelTextLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.levelTextLabel.Location = new System.Drawing.Point(21, 133);
            this.levelTextLabel.Name = "levelTextLabel";
            this.levelTextLabel.Size = new System.Drawing.Size(36, 13);
            this.levelTextLabel.TabIndex = 16;
            this.levelTextLabel.Text = "Level:";
            // 
            // healthLabel
            // 
            this.healthLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.healthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.ForeColor = System.Drawing.Color.Red;
            this.healthLabel.Location = new System.Drawing.Point(90, 95);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(57, 24);
            this.healthLabel.TabIndex = 17;
            this.healthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelLabel
            // 
            this.levelLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.levelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.Red;
            this.levelLabel.Location = new System.Drawing.Point(90, 133);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(54, 23);
            this.levelLabel.TabIndex = 18;
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.Color.Red;
            this.descLabel.Location = new System.Drawing.Point(403, 229);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(0, 18);
            this.descLabel.TabIndex = 19;
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemyHealthText
            // 
            this.enemyHealthText.AutoSize = true;
            this.enemyHealthText.ForeColor = System.Drawing.Color.Red;
            this.enemyHealthText.Location = new System.Drawing.Point(131, 255);
            this.enemyHealthText.Name = "enemyHealthText";
            this.enemyHealthText.Size = new System.Drawing.Size(76, 13);
            this.enemyHealthText.TabIndex = 20;
            this.enemyHealthText.Text = "Enemy Health:";
            // 
            // enemyHealth
            // 
            this.enemyHealth.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.enemyHealth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyHealth.ForeColor = System.Drawing.Color.Red;
            this.enemyHealth.Location = new System.Drawing.Point(134, 289);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.Size = new System.Drawing.Size(59, 23);
            this.enemyHealth.TabIndex = 21;
            this.enemyHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.ForeColor = System.Drawing.Color.Red;
            this.keyLabel.Location = new System.Drawing.Point(94, 189);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(167, 37);
            this.keyLabel.TabIndex = 22;
            this.keyLabel.Text = "GOT KEY";
            this.keyLabel.Visible = false;
            // 
            // cavePic
            // 
            this.cavePic.Image = global::CharlesDickensÄventyr.Properties.Resources.Cave;
            this.cavePic.Location = new System.Drawing.Point(355, 12);
            this.cavePic.Name = "cavePic";
            this.cavePic.Size = new System.Drawing.Size(254, 172);
            this.cavePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cavePic.TabIndex = 30;
            this.cavePic.TabStop = false;
            this.cavePic.Visible = false;
            // 
            // cryptPic
            // 
            this.cryptPic.Image = global::CharlesDickensÄventyr.Properties.Resources.Crypt;
            this.cryptPic.Location = new System.Drawing.Point(355, 12);
            this.cryptPic.Name = "cryptPic";
            this.cryptPic.Size = new System.Drawing.Size(254, 172);
            this.cryptPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cryptPic.TabIndex = 29;
            this.cryptPic.TabStop = false;
            this.cryptPic.Visible = false;
            // 
            // gravePic
            // 
            this.gravePic.Image = global::CharlesDickensÄventyr.Properties.Resources.Graveyard;
            this.gravePic.Location = new System.Drawing.Point(355, 12);
            this.gravePic.Name = "gravePic";
            this.gravePic.Size = new System.Drawing.Size(254, 172);
            this.gravePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gravePic.TabIndex = 28;
            this.gravePic.TabStop = false;
            this.gravePic.Visible = false;
            // 
            // clearPic
            // 
            this.clearPic.Image = global::CharlesDickensÄventyr.Properties.Resources.Clearing;
            this.clearPic.Location = new System.Drawing.Point(355, 12);
            this.clearPic.Name = "clearPic";
            this.clearPic.Size = new System.Drawing.Size(254, 172);
            this.clearPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clearPic.TabIndex = 27;
            this.clearPic.TabStop = false;
            this.clearPic.Visible = false;
            // 
            // woodsPic
            // 
            this.woodsPic.Image = global::CharlesDickensÄventyr.Properties.Resources.Woods;
            this.woodsPic.Location = new System.Drawing.Point(355, 12);
            this.woodsPic.Name = "woodsPic";
            this.woodsPic.Size = new System.Drawing.Size(254, 172);
            this.woodsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woodsPic.TabIndex = 26;
            this.woodsPic.TabStop = false;
            this.woodsPic.Visible = false;
            // 
            // grassPic
            // 
            this.grassPic.Image = global::CharlesDickensÄventyr.Properties.Resources.Grassland;
            this.grassPic.Location = new System.Drawing.Point(355, 12);
            this.grassPic.Name = "grassPic";
            this.grassPic.Size = new System.Drawing.Size(254, 172);
            this.grassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grassPic.TabIndex = 25;
            this.grassPic.TabStop = false;
            this.grassPic.Visible = false;
            // 
            // gardenPic
            // 
            this.gardenPic.Image = global::CharlesDickensÄventyr.Properties.Resources.Garden;
            this.gardenPic.Location = new System.Drawing.Point(355, 12);
            this.gardenPic.Name = "gardenPic";
            this.gardenPic.Size = new System.Drawing.Size(254, 172);
            this.gardenPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gardenPic.TabIndex = 24;
            this.gardenPic.TabStop = false;
            this.gardenPic.Visible = false;
            // 
            // startPic
            // 
            this.startPic.Image = global::CharlesDickensÄventyr.Properties.Resources.Start;
            this.startPic.Location = new System.Drawing.Point(355, 12);
            this.startPic.Name = "startPic";
            this.startPic.Size = new System.Drawing.Size(254, 172);
            this.startPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPic.TabIndex = 23;
            this.startPic.TabStop = false;
            this.startPic.Visible = false;
            // 
            // CharlesÄventyr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(766, 647);
            this.Controls.Add(this.cavePic);
            this.Controls.Add(this.cryptPic);
            this.Controls.Add(this.gravePic);
            this.Controls.Add(this.clearPic);
            this.Controls.Add(this.woodsPic);
            this.Controls.Add(this.grassPic);
            this.Controls.Add(this.gardenPic);
            this.Controls.Add(this.startPic);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.enemyHealth);
            this.Controls.Add(this.enemyHealthText);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.levelTextLabel);
            this.Controls.Add(this.healthTextLabel);
            this.Controls.Add(this.locationTextLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.atkButton);
            this.Controls.Add(this.gearLabel);
            this.Controls.Add(this.gearCombo);
            this.Controls.Add(this.gameTextBox);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.upButton);
            this.Name = "CharlesÄventyr";
            this.ShowIcon = false;
            this.Text = "CharlesÄventyr";
            ((System.ComponentModel.ISupportInitialize)(this.cavePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gardenPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.RichTextBox gameTextBox;
        private System.Windows.Forms.ComboBox gearCombo;
        private System.Windows.Forms.Label gearLabel;
        private System.Windows.Forms.Button atkButton;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label locationTextLabel;
        private System.Windows.Forms.Label healthTextLabel;
        private System.Windows.Forms.Label levelTextLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label enemyHealthText;
        private System.Windows.Forms.Label enemyHealth;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.PictureBox startPic;
        private System.Windows.Forms.PictureBox gardenPic;
        private System.Windows.Forms.PictureBox grassPic;
        private System.Windows.Forms.PictureBox woodsPic;
        private System.Windows.Forms.PictureBox clearPic;
        private System.Windows.Forms.PictureBox gravePic;
        private System.Windows.Forms.PictureBox cryptPic;
        private System.Windows.Forms.PictureBox cavePic;
    }
}

