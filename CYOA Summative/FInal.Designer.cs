namespace CYOA_Summative
{
    partial class FInal
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
            this.txtbubble = new System.Windows.Forms.PictureBox();
            this.mintxt = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Label();
            this.narrative = new System.Windows.Forms.Label();
            this.txtbub2 = new System.Windows.Forms.PictureBox();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.inventory = new System.Windows.Forms.Button();
            this.fighttxt = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.nametell = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minotaur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbubble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbub2)).BeginInit();
            this.SuspendLayout();
            // 
            // minotaur
            // 
            this.minotaur.BackColor = System.Drawing.Color.Transparent;
            this.minotaur.BackgroundImage = global::CYOA_Summative.Properties.Resources.minotaur;
            this.minotaur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minotaur.Location = new System.Drawing.Point(422, 127);
            this.minotaur.Name = "minotaur";
            this.minotaur.Size = new System.Drawing.Size(237, 373);
            this.minotaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minotaur.TabIndex = 0;
            this.minotaur.TabStop = false;
            // 
            // txtbubble
            // 
            this.txtbubble.BackColor = System.Drawing.Color.Transparent;
            this.txtbubble.Image = global::CYOA_Summative.Properties.Resources.speech3;
            this.txtbubble.Location = new System.Drawing.Point(82, 151);
            this.txtbubble.Name = "txtbubble";
            this.txtbubble.Size = new System.Drawing.Size(378, 113);
            this.txtbubble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtbubble.TabIndex = 1;
            this.txtbubble.TabStop = false;
            // 
            // mintxt
            // 
            this.mintxt.AutoSize = true;
            this.mintxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mintxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mintxt.Location = new System.Drawing.Point(194, 184);
            this.mintxt.Name = "mintxt";
            this.mintxt.Size = new System.Drawing.Size(170, 21);
            this.mintxt.TabIndex = 2;
            this.mintxt.Text = "Who dares go there? ";
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Tan;
            this.background.Location = new System.Drawing.Point(28, 20);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(635, 101);
            this.background.TabIndex = 4;
            // 
            // narrative
            // 
            this.narrative.BackColor = System.Drawing.Color.PapayaWhip;
            this.narrative.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narrative.Location = new System.Drawing.Point(45, 36);
            this.narrative.Name = "narrative";
            this.narrative.Size = new System.Drawing.Size(601, 67);
            this.narrative.TabIndex = 44;
            this.narrative.Text = "Pushing through the towering doors, you are shocked to see what appears to be the" +
    " minotaur himself! Angered, he declares:";
            this.narrative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbub2
            // 
            this.txtbub2.BackColor = System.Drawing.Color.Transparent;
            this.txtbub2.Image = global::CYOA_Summative.Properties.Resources.speech4;
            this.txtbub2.Location = new System.Drawing.Point(-14, 250);
            this.txtbub2.Name = "txtbub2";
            this.txtbub2.Size = new System.Drawing.Size(444, 196);
            this.txtbub2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtbub2.TabIndex = 45;
            this.txtbub2.TabStop = false;
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(69, 280);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(263, 43);
            this.option1.TabIndex = 46;
            this.option1.Text = "It is I! I have come to challenge you to a battle!";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.CheckedChanged += new System.EventHandler(this.option1_CheckedChanged);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.option2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(69, 329);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(263, 31);
            this.option2.TabIndex = 47;
            this.option2.TabStop = true;
            this.option2.Text = "Please don\'t hurt me.";
            this.option2.UseVisualStyleBackColor = false;
            this.option2.CheckedChanged += new System.EventHandler(this.option2_CheckedChanged);
            // 
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(12, 533);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(104, 33);
            this.inventory.TabIndex = 51;
            this.inventory.Text = "INVENTORY";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // fighttxt
            // 
            this.fighttxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.fighttxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fighttxt.Location = new System.Drawing.Point(45, 36);
            this.fighttxt.Name = "fighttxt";
            this.fighttxt.Size = new System.Drawing.Size(601, 67);
            this.fighttxt.TabIndex = 52;
            this.fighttxt.Text = "Shocked, he agrees. Before beginning, he asks you for your name. Do you tell him?" +
    "";
            this.fighttxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fighttxt.Visible = false;
            // 
            // yes
            // 
            this.yes.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.Location = new System.Drawing.Point(201, 129);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(131, 52);
            this.yes.TabIndex = 54;
            this.yes.Text = "TELL HIM";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Visible = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(388, 129);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(131, 52);
            this.no.TabIndex = 55;
            this.no.Text = "DON\'T TELL HIM";
            this.no.UseVisualStyleBackColor = true;
            this.no.Visible = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // nametell
            // 
            this.nametell.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nametell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametell.Location = new System.Drawing.Point(65, 284);
            this.nametell.Name = "nametell";
            this.nametell.Size = new System.Drawing.Size(267, 95);
            this.nametell.TabIndex = 56;
            this.nametell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nametell.Visible = false;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(40, 129);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(86, 29);
            this.next.TabIndex = 62;
            this.next.Text = "CONTINUE";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(247, 357);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(85, 22);
            this.enter.TabIndex = 63;
            this.enter.Text = "CONTINUE";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // FInal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.final1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.nametell);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.next);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.fighttxt);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.minotaur);
            this.Controls.Add(this.txtbub2);
            this.Controls.Add(this.narrative);
            this.Controls.Add(this.background);
            this.Controls.Add(this.mintxt);
            this.Controls.Add(this.txtbubble);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FInal";
            this.Text = "FInal";
            ((System.ComponentModel.ISupportInitialize)(this.minotaur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbubble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbub2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minotaur;
        private System.Windows.Forms.PictureBox txtbubble;
        private System.Windows.Forms.Label mintxt;
        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label narrative;
        private System.Windows.Forms.PictureBox txtbub2;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Label fighttxt;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Label nametell;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button enter;
    }
}