namespace CYOA_Summative
{
    partial class Pit
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
            this.dietext = new System.Windows.Forms.Label();
            this.backblock = new System.Windows.Forms.Label();
            this.youdied = new System.Windows.Forms.Label();
            this.leave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dietext
            // 
            this.dietext.BackColor = System.Drawing.Color.PapayaWhip;
            this.dietext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dietext.Location = new System.Drawing.Point(45, 36);
            this.dietext.Name = "dietext";
            this.dietext.Size = new System.Drawing.Size(601, 67);
            this.dietext.TabIndex = 18;
            this.dietext.Text = "Unfortunately, as a result of the consuming darkness, you did not see the large p" +
    "it until it was too late. You died.";
            this.dietext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backblock
            // 
            this.backblock.BackColor = System.Drawing.Color.Tan;
            this.backblock.Location = new System.Drawing.Point(28, 20);
            this.backblock.Name = "backblock";
            this.backblock.Size = new System.Drawing.Size(635, 101);
            this.backblock.TabIndex = 16;
            // 
            // youdied
            // 
            this.youdied.BackColor = System.Drawing.Color.Transparent;
            this.youdied.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youdied.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.youdied.Location = new System.Drawing.Point(182, 304);
            this.youdied.Name = "youdied";
            this.youdied.Size = new System.Drawing.Size(349, 170);
            this.youdied.TabIndex = 19;
            this.youdied.Text = "YOU DIED";
            this.youdied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leave
            // 
            this.leave.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave.Location = new System.Drawing.Point(532, 134);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(131, 52);
            this.leave.TabIndex = 21;
            this.leave.Text = "RETURN TO MAIN MENU";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // Pit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.pit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.youdied);
            this.Controls.Add(this.dietext);
            this.Controls.Add(this.backblock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pit";
            this.Text = "Pit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dietext;
        private System.Windows.Forms.Label backblock;
        private System.Windows.Forms.Label youdied;
        private System.Windows.Forms.Button leave;
    }
}