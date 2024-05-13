namespace CYOA_Summative
{
    partial class hallway3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hallway3));
            this.background = new System.Windows.Forms.Label();
            this.narrative3 = new System.Windows.Forms.Label();
            this.whatdo = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.follow = new System.Windows.Forms.Button();
            this.away = new System.Windows.Forms.Button();
            this.leave = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.searchtext = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.PictureBox();
            this.chlorobtain = new System.Windows.Forms.Label();
            this.oppositetext = new System.Windows.Forms.Label();
            this.stand = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.item)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Tan;
            this.background.Location = new System.Drawing.Point(28, 20);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(635, 101);
            this.background.TabIndex = 2;
            // 
            // narrative3
            // 
            this.narrative3.BackColor = System.Drawing.Color.PapayaWhip;
            this.narrative3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narrative3.Location = new System.Drawing.Point(45, 36);
            this.narrative3.Name = "narrative3";
            this.narrative3.Size = new System.Drawing.Size(601, 67);
            this.narrative3.TabIndex = 13;
            this.narrative3.Text = resources.GetString("narrative3.Text");
            this.narrative3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whatdo
            // 
            this.whatdo.BackColor = System.Drawing.Color.PapayaWhip;
            this.whatdo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatdo.Location = new System.Drawing.Point(45, 36);
            this.whatdo.Name = "whatdo";
            this.whatdo.Size = new System.Drawing.Size(601, 67);
            this.whatdo.TabIndex = 14;
            this.whatdo.Text = "What would you like to do?";
            this.whatdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.whatdo.Visible = false;
            this.whatdo.Click += new System.EventHandler(this.label1_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(569, 126);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(86, 28);
            this.next.TabIndex = 15;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(31, 134);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(131, 52);
            this.search.TabIndex = 16;
            this.search.Text = "SEARCH THE AREA";
            this.search.UseVisualStyleBackColor = true;
            this.search.Visible = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // follow
            // 
            this.follow.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.follow.Location = new System.Drawing.Point(200, 134);
            this.follow.Name = "follow";
            this.follow.Size = new System.Drawing.Size(131, 52);
            this.follow.TabIndex = 17;
            this.follow.Text = "FOLLOW THE SOUND";
            this.follow.UseVisualStyleBackColor = true;
            this.follow.Visible = false;
            this.follow.Click += new System.EventHandler(this.follow_Click);
            // 
            // away
            // 
            this.away.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.away.Location = new System.Drawing.Point(373, 134);
            this.away.Name = "away";
            this.away.Size = new System.Drawing.Size(131, 52);
            this.away.TabIndex = 18;
            this.away.Text = "GO THE OPPOSITE WAY";
            this.away.UseVisualStyleBackColor = true;
            this.away.Visible = false;
            this.away.Click += new System.EventHandler(this.away_Click);
            // 
            // leave
            // 
            this.leave.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave.Location = new System.Drawing.Point(532, 134);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(131, 52);
            this.leave.TabIndex = 19;
            this.leave.Text = "EXIT TO MAIN MENU";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Visible = false;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(12, 533);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(104, 33);
            this.inventory.TabIndex = 20;
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
            this.back.TabIndex = 23;
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
            this.searchtext.TabIndex = 24;
            this.searchtext.Text = resources.GetString("searchtext.Text");
            this.searchtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchtext.Visible = false;
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.Transparent;
            this.item.Image = global::CYOA_Summative.Properties.Resources.chloroform;
            this.item.Location = new System.Drawing.Point(229, 201);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(235, 262);
            this.item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item.TabIndex = 25;
            this.item.TabStop = false;
            this.item.Visible = false;
            // 
            // chlorobtain
            // 
            this.chlorobtain.BackColor = System.Drawing.Color.PapayaWhip;
            this.chlorobtain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlorobtain.Location = new System.Drawing.Point(250, 464);
            this.chlorobtain.Name = "chlorobtain";
            this.chlorobtain.Size = new System.Drawing.Size(200, 36);
            this.chlorobtain.TabIndex = 26;
            this.chlorobtain.Text = "Bottle of chloroform obtained!";
            this.chlorobtain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chlorobtain.Visible = false;
            // 
            // oppositetext
            // 
            this.oppositetext.BackColor = System.Drawing.Color.PapayaWhip;
            this.oppositetext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oppositetext.Location = new System.Drawing.Point(45, 36);
            this.oppositetext.Name = "oppositetext";
            this.oppositetext.Size = new System.Drawing.Size(601, 67);
            this.oppositetext.TabIndex = 27;
            this.oppositetext.Text = "You turn around to walk the opposite way, but from behind you, you hear footsteps" +
    " following you. What would you like to do?";
            this.oppositetext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.oppositetext.Visible = false;
            // 
            // stand
            // 
            this.stand.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stand.Location = new System.Drawing.Point(200, 134);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(131, 52);
            this.stand.TabIndex = 28;
            this.stand.Text = "STAND YOUR GROUND";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Visible = false;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(373, 134);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(131, 52);
            this.run.TabIndex = 29;
            this.run.Text = "RUN AWAY";
            this.run.UseVisualStyleBackColor = true;
            this.run.Visible = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // hallway3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.hallway3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.run);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.oppositetext);
            this.Controls.Add(this.chlorobtain);
            this.Controls.Add(this.item);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.back);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.away);
            this.Controls.Add(this.follow);
            this.Controls.Add(this.search);
            this.Controls.Add(this.next);
            this.Controls.Add(this.whatdo);
            this.Controls.Add(this.narrative3);
            this.Controls.Add(this.background);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hallway3";
            this.Text = "Start3";
            ((System.ComponentModel.ISupportInitialize)(this.item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label narrative3;
        private System.Windows.Forms.Label whatdo;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button follow;
        private System.Windows.Forms.Button away;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label searchtext;
        private System.Windows.Forms.PictureBox item;
        private System.Windows.Forms.Label chlorobtain;
        private System.Windows.Forms.Label oppositetext;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Button run;
    }
}