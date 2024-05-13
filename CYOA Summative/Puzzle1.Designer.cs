namespace CYOA_Summative
{
    partial class Puzzle1
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
            this.okleave = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.look = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okleave
            // 
            this.okleave.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okleave.Location = new System.Drawing.Point(445, 400);
            this.okleave.Name = "okleave";
            this.okleave.Size = new System.Drawing.Size(86, 28);
            this.okleave.TabIndex = 4;
            this.okleave.Text = "OK";
            this.okleave.UseVisualStyleBackColor = true;
            this.okleave.Click += new System.EventHandler(this.exit_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Peru;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(217, 91);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(25, 21);
            this.num1.TabIndex = 5;
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.RoyalBlue;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(327, 142);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(25, 21);
            this.num2.TabIndex = 6;
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.ForestGreen;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(227, 199);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(25, 21);
            this.num3.TabIndex = 7;
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.Gold;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(328, 270);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(25, 21);
            this.num4.TabIndex = 8;
            this.num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.Firebrick;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(170, 314);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(25, 21);
            this.num5.TabIndex = 9;
            this.num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Tan;
            this.background.Location = new System.Drawing.Point(17, 12);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(507, 57);
            this.background.TabIndex = 10;
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(32, 23);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(473, 33);
            this.txt.TabIndex = 40;
            this.txt.Text = "Hmmm. There seems to be something written there... Maybe look closer.";
            this.txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // look
            // 
            this.look.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.look.Location = new System.Drawing.Point(413, 74);
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(104, 24);
            this.look.TabIndex = 41;
            this.look.Text = "LOOK CLOSER";
            this.look.UseVisualStyleBackColor = true;
            this.look.Click += new System.EventHandler(this.look_Click);
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.PapayaWhip;
            this.txt2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(32, 23);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(473, 33);
            this.txt2.TabIndex = 42;
            this.txt2.Text = "You can see the text already! Read it.";
            this.txt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt2.Visible = false;
            // 
            // Puzzle1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.blank_wall1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(543, 440);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.look);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.background);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.okleave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Puzzle1";
            this.Text = "Puzzle1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okleave;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label num5;
        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Button look;
        private System.Windows.Forms.Label txt2;
    }
}