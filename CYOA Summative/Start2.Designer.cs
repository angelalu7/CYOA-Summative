namespace CYOA_Summative
{
    partial class hallway2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hallway2));
            this.backblock = new System.Windows.Forms.Label();
            this.story2 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.whatdopt2 = new System.Windows.Forms.Label();
            this.leave = new System.Windows.Forms.Button();
            this.straight = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.searchtext = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backblock
            // 
            this.backblock.BackColor = System.Drawing.Color.Tan;
            this.backblock.Location = new System.Drawing.Point(28, 20);
            this.backblock.Name = "backblock";
            this.backblock.Size = new System.Drawing.Size(635, 101);
            this.backblock.TabIndex = 2;
            // 
            // story2
            // 
            this.story2.BackColor = System.Drawing.Color.PapayaWhip;
            this.story2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.story2.Location = new System.Drawing.Point(45, 36);
            this.story2.Name = "story2";
            this.story2.Size = new System.Drawing.Size(601, 67);
            this.story2.TabIndex = 13;
            this.story2.Text = resources.GetString("story2.Text");
            this.story2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(569, 126);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(86, 28);
            this.next.TabIndex = 14;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // whatdopt2
            // 
            this.whatdopt2.BackColor = System.Drawing.Color.PapayaWhip;
            this.whatdopt2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatdopt2.Location = new System.Drawing.Point(45, 36);
            this.whatdopt2.Name = "whatdopt2";
            this.whatdopt2.Size = new System.Drawing.Size(601, 67);
            this.whatdopt2.TabIndex = 15;
            this.whatdopt2.Text = "Straight ahead, there is a bright light source. To the right, you can barely see " +
    "two feet in. What would you like to do?";
            this.whatdopt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.whatdopt2.Visible = false;
            // 
            // leave
            // 
            this.leave.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave.Location = new System.Drawing.Point(532, 134);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(131, 52);
            this.leave.TabIndex = 20;
            this.leave.Text = "EXIT TO MAIN MENU";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Visible = false;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // straight
            // 
            this.straight.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.straight.Location = new System.Drawing.Point(373, 134);
            this.straight.Name = "straight";
            this.straight.Size = new System.Drawing.Size(131, 52);
            this.straight.TabIndex = 19;
            this.straight.Text = "CONTINUE GOING STRAIGHT";
            this.straight.UseVisualStyleBackColor = true;
            this.straight.Visible = false;
            this.straight.Click += new System.EventHandler(this.straight_Click);
            // 
            // right
            // 
            this.right.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.Location = new System.Drawing.Point(200, 134);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(131, 52);
            this.right.TabIndex = 18;
            this.right.Text = "GO RIGHT";
            this.right.UseVisualStyleBackColor = true;
            this.right.Visible = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(31, 134);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(131, 52);
            this.search.TabIndex = 17;
            this.search.Text = "SEARCH THE AREA";
            this.search.UseVisualStyleBackColor = true;
            this.search.Visible = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(12, 533);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(104, 33);
            this.inventory.TabIndex = 21;
            this.inventory.Text = "INVENTORY";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(532, 209);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 52);
            this.back.TabIndex = 22;
            this.back.Text = "GO BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Visible = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // searchtext
            // 
            this.searchtext.BackColor = System.Drawing.Color.PapayaWhip;
            this.searchtext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtext.Location = new System.Drawing.Point(45, 36);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(601, 67);
            this.searchtext.TabIndex = 23;
            this.searchtext.Text = "You look around, patting the ground in search of useful objects. You find nothing" +
    ", and your hands are now dirty. You do, however, notice some markings on the wal" +
    "l. Would you like to investigate?";
            this.searchtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchtext.Visible = false;
            this.searchtext.Click += new System.EventHandler(this.searchtext_Click);
            // 
            // yes
            // 
            this.yes.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes.Location = new System.Drawing.Point(200, 134);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(131, 52);
            this.yes.TabIndex = 24;
            this.yes.Text = "YES";
            this.yes.UseVisualStyleBackColor = true;
            this.yes.Visible = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(373, 134);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(131, 52);
            this.no.TabIndex = 25;
            this.no.Text = "NO";
            this.no.UseVisualStyleBackColor = true;
            this.no.Visible = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // hallway2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources._8f9c27de49366b1f19a3ef0418b320ac1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.back);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.straight);
            this.Controls.Add(this.right);
            this.Controls.Add(this.search);
            this.Controls.Add(this.whatdopt2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.story2);
            this.Controls.Add(this.backblock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hallway2";
            this.Text = "Start2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label backblock;
        private System.Windows.Forms.Label story2;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label whatdopt2;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Button straight;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label searchtext;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
    }
}