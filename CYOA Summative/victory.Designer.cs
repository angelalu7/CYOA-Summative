namespace CYOA_Summative
{
    partial class victory
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
            this.victorytct = new System.Windows.Forms.Label();
            this.victor = new System.Windows.Forms.Label();
            this.leave = new System.Windows.Forms.Button();
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
            // victorytct
            // 
            this.victorytct.BackColor = System.Drawing.Color.PapayaWhip;
            this.victorytct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victorytct.Location = new System.Drawing.Point(45, 36);
            this.victorytct.Name = "victorytct";
            this.victorytct.Size = new System.Drawing.Size(601, 67);
            this.victorytct.TabIndex = 53;
            this.victorytct.Text = "Congratulations! You beat the Labyrinth and you are now the almighty ruler of the" +
    " Labyrinth. You won!";
            this.victorytct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // victor
            // 
            this.victor.BackColor = System.Drawing.Color.Transparent;
            this.victor.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victor.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.victor.Location = new System.Drawing.Point(182, 304);
            this.victor.Name = "victor";
            this.victor.Size = new System.Drawing.Size(349, 170);
            this.victor.TabIndex = 54;
            this.victor.Text = "VICTORY!!";
            this.victor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.victor.Click += new System.EventHandler(this.youdied_Click);
            // 
            // leave
            // 
            this.leave.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave.Location = new System.Drawing.Point(532, 134);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(131, 52);
            this.leave.TabIndex = 55;
            this.leave.Text = "RETURN TO MAIN MENU";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.e68f38dc14e7a7247fd05cbc34cd4870_copy1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.victor);
            this.Controls.Add(this.victorytct);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "victory";
            this.Text = "victory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label victorytct;
        private System.Windows.Forms.Label victor;
        private System.Windows.Forms.Button leave;
    }
}