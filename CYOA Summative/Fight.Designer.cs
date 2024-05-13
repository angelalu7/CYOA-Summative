namespace CYOA_Summative
{
    partial class Fight
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
            this.minotaur = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.Label();
            this.fighttxt = new System.Windows.Forms.Label();
            this.sword = new System.Windows.Forms.Button();
            this.hand = new System.Windows.Forms.Button();
            this.swordtxt = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.nosword = new System.Windows.Forms.Label();
            this.handtxt = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.PictureBox();
            this.win = new System.Windows.Forms.Label();
            this.okk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minotaur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health)).BeginInit();
            this.SuspendLayout();
            // 
            // minotaur
            // 
            this.minotaur.BackColor = System.Drawing.Color.Transparent;
            this.minotaur.BackgroundImage = global::CYOA_Summative.Properties.Resources.minotaur;
            this.minotaur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minotaur.Location = new System.Drawing.Point(408, 176);
            this.minotaur.Name = "minotaur";
            this.minotaur.Size = new System.Drawing.Size(237, 373);
            this.minotaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minotaur.TabIndex = 1;
            this.minotaur.TabStop = false;
            this.minotaur.Click += new System.EventHandler(this.minotaur_Click);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Tan;
            this.background.Location = new System.Drawing.Point(28, 20);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(635, 101);
            this.background.TabIndex = 5;
            // 
            // fighttxt
            // 
            this.fighttxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.fighttxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fighttxt.Location = new System.Drawing.Point(44, 36);
            this.fighttxt.Name = "fighttxt";
            this.fighttxt.Size = new System.Drawing.Size(601, 67);
            this.fighttxt.TabIndex = 53;
            this.fighttxt.Text = "You get into your fighting stance. Would you like to use your sword or your bare " +
    "hands?";
            this.fighttxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sword
            // 
            this.sword.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sword.Location = new System.Drawing.Point(187, 134);
            this.sword.Name = "sword";
            this.sword.Size = new System.Drawing.Size(131, 52);
            this.sword.TabIndex = 55;
            this.sword.Text = "SWORD";
            this.sword.UseVisualStyleBackColor = true;
            this.sword.Click += new System.EventHandler(this.sword_Click);
            // 
            // hand
            // 
            this.hand.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hand.Location = new System.Drawing.Point(387, 134);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(131, 52);
            this.hand.TabIndex = 56;
            this.hand.Text = "BARE HANDS";
            this.hand.UseVisualStyleBackColor = true;
            this.hand.Click += new System.EventHandler(this.hand_Click);
            // 
            // swordtxt
            // 
            this.swordtxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.swordtxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swordtxt.Location = new System.Drawing.Point(44, 36);
            this.swordtxt.Name = "swordtxt";
            this.swordtxt.Size = new System.Drawing.Size(601, 67);
            this.swordtxt.TabIndex = 57;
            this.swordtxt.Text = "You decide to use your super cool sword. Click Ok to continue, then start tapping" +
    " on the Minotaur to damage him!";
            this.swordtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.swordtxt.Visible = false;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(37, 127);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(86, 29);
            this.next.TabIndex = 63;
            this.next.Text = "OK";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // nosword
            // 
            this.nosword.BackColor = System.Drawing.Color.PapayaWhip;
            this.nosword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nosword.Location = new System.Drawing.Point(44, 36);
            this.nosword.Name = "nosword";
            this.nosword.Size = new System.Drawing.Size(601, 67);
            this.nosword.TabIndex = 64;
            this.nosword.Text = "You don\'t have a sword! Hmm... if only you\'d clicked on the sword in that one roo" +
    "m...";
            this.nosword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nosword.Visible = false;
            // 
            // handtxt
            // 
            this.handtxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.handtxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handtxt.Location = new System.Drawing.Point(44, 36);
            this.handtxt.Name = "handtxt";
            this.handtxt.Size = new System.Drawing.Size(601, 67);
            this.handtxt.TabIndex = 65;
            this.handtxt.Text = "You decide to use your bare hands! Click OK, then start tapping on the Minotaur t" +
    "o damage him!";
            this.handtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.handtxt.Visible = false;
            // 
            // health
            // 
            this.health.Image = global::CYOA_Summative.Properties.Resources._10;
            this.health.Location = new System.Drawing.Point(508, 204);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(125, 24);
            this.health.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.health.TabIndex = 66;
            this.health.TabStop = false;
            this.health.Visible = false;
            // 
            // win
            // 
            this.win.BackColor = System.Drawing.Color.PapayaWhip;
            this.win.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.Location = new System.Drawing.Point(44, 36);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(601, 67);
            this.win.TabIndex = 67;
            this.win.Text = "Congratulations! You beat the Minotaur!";
            this.win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.win.Visible = false;
            // 
            // okk
            // 
            this.okk.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okk.Location = new System.Drawing.Point(577, 126);
            this.okk.Name = "okk";
            this.okk.Size = new System.Drawing.Size(86, 29);
            this.okk.TabIndex = 68;
            this.okk.Text = "CONTINUE";
            this.okk.UseVisualStyleBackColor = true;
            this.okk.Visible = false;
            this.okk.Click += new System.EventHandler(this.okk_Click);
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.final1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.okk);
            this.Controls.Add(this.win);
            this.Controls.Add(this.health);
            this.Controls.Add(this.handtxt);
            this.Controls.Add(this.nosword);
            this.Controls.Add(this.next);
            this.Controls.Add(this.swordtxt);
            this.Controls.Add(this.hand);
            this.Controls.Add(this.sword);
            this.Controls.Add(this.fighttxt);
            this.Controls.Add(this.background);
            this.Controls.Add(this.minotaur);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fight";
            this.Text = "Fight";
            ((System.ComponentModel.ISupportInitialize)(this.minotaur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minotaur;
        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label fighttxt;
        private System.Windows.Forms.Button sword;
        private System.Windows.Forms.Button hand;
        private System.Windows.Forms.Label swordtxt;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label nosword;
        private System.Windows.Forms.Label handtxt;
        private System.Windows.Forms.PictureBox health;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Button okk;
    }
}