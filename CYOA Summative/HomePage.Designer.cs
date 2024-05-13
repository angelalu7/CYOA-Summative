namespace CYOA_Summative
{
    partial class homeform
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
            this.title = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.q1 = new System.Windows.Forms.Label();
            this.q2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Mongolian Baiti", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.title.Location = new System.Drawing.Point(100, 60);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(486, 75);
            this.title.TabIndex = 1;
            this.title.Text = "THE LABYRINTH";
            this.title.Click += new System.EventHandler(this.title_Click_1);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Silver;
            this.start.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Black;
            this.start.Location = new System.Drawing.Point(56, 167);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(139, 57);
            this.start.TabIndex = 2;
            this.start.Text = "BEGIN YOUR ADVENTURE";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.Silver;
            this.instructions.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.ForeColor = System.Drawing.Color.Black;
            this.instructions.Location = new System.Drawing.Point(56, 247);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(139, 57);
            this.instructions.TabIndex = 3;
            this.instructions.Text = "INSTRUCTIONS";
            this.instructions.UseVisualStyleBackColor = false;
            this.instructions.Click += new System.EventHandler(this.instructions_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Silver;
            this.exit.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(56, 326);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(139, 57);
            this.exit.TabIndex = 4;
            this.exit.Text = "EXIT GAME";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.Location = new System.Drawing.Point(430, 213);
            this.namebox.Multiline = true;
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(135, 25);
            this.namebox.TabIndex = 5;
            this.namebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "FEMALE",
            "MALE",
            "RATHER NOT SAY",
            "OTHER"});
            this.gender.Location = new System.Drawing.Point(430, 314);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(135, 21);
            this.gender.TabIndex = 6;
            this.gender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // q1
            // 
            this.q1.BackColor = System.Drawing.Color.Transparent;
            this.q1.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.q1.Location = new System.Drawing.Point(360, 186);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(226, 24);
            this.q1.TabIndex = 7;
            this.q1.Text = "PLEASE ENTER YOUR NAME:";
            this.q1.Click += new System.EventHandler(this.label1_Click);
            // 
            // q2
            // 
            this.q2.BackColor = System.Drawing.Color.Transparent;
            this.q2.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.q2.Location = new System.Drawing.Point(343, 280);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(243, 24);
            this.q2.TabIndex = 8;
            this.q2.Text = "PLEASE SELECT YOUR GENDER:";
            // 
            // homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.e68f38dc14e7a7247fd05cbc34cd4870_copy1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 440);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.start);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homeform";
            this.Load += new System.EventHandler(this.homeform_Load);
            this.VisibleChanged += new System.EventHandler(this.homeform_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button instructions;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label q1;
        private System.Windows.Forms.Label q2;
    }
}

