namespace CYOA_Summative
{
    partial class Dead
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
            this.background = new System.Windows.Forms.Label();
            this.narrative = new System.Windows.Forms.Label();
            this.leave = new System.Windows.Forms.Button();
            this.youdied = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Tan;
            this.background.Location = new System.Drawing.Point(28, 20);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(635, 101);
            this.background.TabIndex = 5;
            // 
            // narrative
            // 
            this.narrative.BackColor = System.Drawing.Color.PapayaWhip;
            this.narrative.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narrative.Location = new System.Drawing.Point(45, 36);
            this.narrative.Name = "narrative";
            this.narrative.Size = new System.Drawing.Size(601, 67);
            this.narrative.TabIndex = 45;
            this.narrative.Text = "Unfortunately, the minotaur did not care about your plea. You died.";
            this.narrative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leave
            // 
            this.leave.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave.Location = new System.Drawing.Point(532, 134);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(131, 52);
            this.leave.TabIndex = 46;
            this.leave.Text = "RETURN TO MAIN MENU";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // youdied
            // 
            this.youdied.BackColor = System.Drawing.Color.Transparent;
            this.youdied.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youdied.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.youdied.Location = new System.Drawing.Point(182, 304);
            this.youdied.Name = "youdied";
            this.youdied.Size = new System.Drawing.Size(349, 170);
            this.youdied.TabIndex = 47;
            this.youdied.Text = "YOU DIED";
            this.youdied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.final1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.youdied);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.narrative);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dead";
            this.Text = "Dead";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label narrative;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Label youdied;
    }
}