namespace CYOA_Summative
{
    partial class doorway
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doorway));
            this.monster = new System.Windows.Forms.PictureBox();
            this.monsterright = new System.Windows.Forms.Timer(this.components);
            this.monsterleft = new System.Windows.Forms.Timer(this.components);
            this.background = new System.Windows.Forms.Label();
            this.narrative4 = new System.Windows.Forms.Label();
            this.inventory = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.distract = new System.Windows.Forms.Button();
            this.mercy = new System.Windows.Forms.Button();
            this.leave = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.mercytext = new System.Windows.Forms.Label();
            this.distracttext = new System.Windows.Forms.Label();
            this.searchtext = new System.Windows.Forms.Label();
            this.corntimer = new System.Windows.Forms.Timer(this.components);
            this.res = new System.Windows.Forms.Label();
            this.corn1 = new System.Windows.Forms.PictureBox();
            this.run = new System.Windows.Forms.Button();
            this.throwsmth = new System.Windows.Forms.Button();
            this.throwtxt = new System.Windows.Forms.Label();
            this.rockpic = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.Button();
            this.nothrow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockpic)).BeginInit();
            this.SuspendLayout();
            // 
            // monster
            // 
            this.monster.BackColor = System.Drawing.Color.Transparent;
            this.monster.Image = global::CYOA_Summative.Properties.Resources._5fa183f3dc0a2543091950;
            this.monster.Location = new System.Drawing.Point(-59, 266);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(364, 258);
            this.monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monster.TabIndex = 0;
            this.monster.TabStop = false;
            this.monster.Click += new System.EventHandler(this.monster_Click);
            // 
            // monsterright
            // 
            this.monsterright.Enabled = true;
            this.monsterright.Tick += new System.EventHandler(this.monsterright_Tick);
            // 
            // monsterleft
            // 
            this.monsterleft.Tick += new System.EventHandler(this.monsterleft_Tick);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Tan;
            this.background.Location = new System.Drawing.Point(28, 20);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(635, 101);
            this.background.TabIndex = 3;
            // 
            // narrative4
            // 
            this.narrative4.BackColor = System.Drawing.Color.PapayaWhip;
            this.narrative4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narrative4.Location = new System.Drawing.Point(45, 36);
            this.narrative4.Name = "narrative4";
            this.narrative4.Size = new System.Drawing.Size(601, 67);
            this.narrative4.TabIndex = 28;
            this.narrative4.Text = resources.GetString("narrative4.Text");
            this.narrative4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(12, 533);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(104, 33);
            this.inventory.TabIndex = 29;
            this.inventory.Text = "INVENTORY";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(31, 134);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(131, 52);
            this.search.TabIndex = 30;
            this.search.Text = "SEARCH THE AREA";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // distract
            // 
            this.distract.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distract.Location = new System.Drawing.Point(200, 134);
            this.distract.Name = "distract";
            this.distract.Size = new System.Drawing.Size(131, 52);
            this.distract.TabIndex = 31;
            this.distract.Text = "DISTRACT THE MONSTER";
            this.distract.UseVisualStyleBackColor = true;
            this.distract.Click += new System.EventHandler(this.distract_Click);
            // 
            // mercy
            // 
            this.mercy.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercy.Location = new System.Drawing.Point(373, 134);
            this.mercy.Name = "mercy";
            this.mercy.Size = new System.Drawing.Size(131, 52);
            this.mercy.TabIndex = 32;
            this.mercy.Text = "PLEAD FOR MERCY";
            this.mercy.UseVisualStyleBackColor = true;
            this.mercy.Click += new System.EventHandler(this.mercy_Click);
            // 
            // leave
            // 
            this.leave.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave.Location = new System.Drawing.Point(532, 134);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(131, 52);
            this.leave.TabIndex = 33;
            this.leave.Text = "EXIT TO MAIN MENU";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.leave_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(532, 209);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 52);
            this.back.TabIndex = 34;
            this.back.Text = "GO BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // mercytext
            // 
            this.mercytext.BackColor = System.Drawing.Color.PapayaWhip;
            this.mercytext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mercytext.Location = new System.Drawing.Point(45, 36);
            this.mercytext.Name = "mercytext";
            this.mercytext.Size = new System.Drawing.Size(601, 67);
            this.mercytext.TabIndex = 35;
            this.mercytext.Text = "Pleas for mercy spill from your mouth, imploring the monster to spare you. Unfort" +
    "unately, the monster does not understand what you are saying.";
            this.mercytext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mercytext.Visible = false;
            // 
            // distracttext
            // 
            this.distracttext.BackColor = System.Drawing.Color.PapayaWhip;
            this.distracttext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distracttext.Location = new System.Drawing.Point(45, 36);
            this.distracttext.Name = "distracttext";
            this.distracttext.Size = new System.Drawing.Size(601, 67);
            this.distracttext.TabIndex = 36;
            this.distracttext.Text = "You decide to distract the monster. Please select something from your inventory t" +
    "o use.";
            this.distracttext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.distracttext.Visible = false;
            // 
            // searchtext
            // 
            this.searchtext.BackColor = System.Drawing.Color.PapayaWhip;
            this.searchtext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtext.Location = new System.Drawing.Point(45, 36);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(601, 67);
            this.searchtext.TabIndex = 38;
            this.searchtext.Text = "You look around, barely daring to take your eyes off the monster before you. Behi" +
    "nd the monster, you see a large doorway.";
            this.searchtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchtext.Visible = false;
            // 
            // corntimer
            // 
            this.corntimer.Enabled = true;
            this.corntimer.Interval = 1;
            this.corntimer.Tick += new System.EventHandler(this.corntimer_Tick);
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.Color.PapayaWhip;
            this.res.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(45, 36);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(601, 67);
            this.res.TabIndex = 39;
            this.res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.res.Visible = false;
            // 
            // corn1
            // 
            this.corn1.BackColor = System.Drawing.Color.Transparent;
            this.corn1.Image = global::CYOA_Summative.Properties.Resources.corn;
            this.corn1.Location = new System.Drawing.Point(251, 451);
            this.corn1.Name = "corn1";
            this.corn1.Size = new System.Drawing.Size(45, 63);
            this.corn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.corn1.TabIndex = 40;
            this.corn1.TabStop = false;
            this.corn1.Visible = false;
            // 
            // run
            // 
            this.run.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run.Location = new System.Drawing.Point(200, 134);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(131, 52);
            this.run.TabIndex = 41;
            this.run.Text = "RUN PAST";
            this.run.UseVisualStyleBackColor = true;
            this.run.Visible = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // throwsmth
            // 
            this.throwsmth.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwsmth.Location = new System.Drawing.Point(373, 134);
            this.throwsmth.Name = "throwsmth";
            this.throwsmth.Size = new System.Drawing.Size(131, 52);
            this.throwsmth.TabIndex = 42;
            this.throwsmth.Text = "THROW SOMETHING AT IT";
            this.throwsmth.UseVisualStyleBackColor = true;
            this.throwsmth.Visible = false;
            this.throwsmth.Click += new System.EventHandler(this.throwsmth_Click);
            // 
            // throwtxt
            // 
            this.throwtxt.BackColor = System.Drawing.Color.PapayaWhip;
            this.throwtxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.throwtxt.Location = new System.Drawing.Point(45, 36);
            this.throwtxt.Name = "throwtxt";
            this.throwtxt.Size = new System.Drawing.Size(601, 67);
            this.throwtxt.TabIndex = 43;
            this.throwtxt.Text = "You reach into your pocket to grab the first thing you can find. You launch the r" +
    "ock at the monster. It immediately falls unconscious. Success!";
            this.throwtxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.throwtxt.Visible = false;
            // 
            // rockpic
            // 
            this.rockpic.BackColor = System.Drawing.Color.Transparent;
            this.rockpic.Image = global::CYOA_Summative.Properties.Resources.rock;
            this.rockpic.Location = new System.Drawing.Point(96, 468);
            this.rockpic.Name = "rockpic";
            this.rockpic.Size = new System.Drawing.Size(51, 46);
            this.rockpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rockpic.TabIndex = 44;
            this.rockpic.TabStop = false;
            this.rockpic.Visible = false;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(39, 129);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(86, 29);
            this.next.TabIndex = 46;
            this.next.Text = "CONTINUE";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // nothrow
            // 
            this.nothrow.BackColor = System.Drawing.Color.PapayaWhip;
            this.nothrow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nothrow.Location = new System.Drawing.Point(45, 36);
            this.nothrow.Name = "nothrow";
            this.nothrow.Size = new System.Drawing.Size(601, 67);
            this.nothrow.TabIndex = 47;
            this.nothrow.Text = "You don\'t have the right item to throw... Maybe something heavy, like a rock?";
            this.nothrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nothrow.Visible = false;
            // 
            // doorway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.start4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.throwtxt);
            this.Controls.Add(this.nothrow);
            this.Controls.Add(this.distracttext);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.mercytext);
            this.Controls.Add(this.res);
            this.Controls.Add(this.narrative4);
            this.Controls.Add(this.background);
            this.Controls.Add(this.next);
            this.Controls.Add(this.rockpic);
            this.Controls.Add(this.throwsmth);
            this.Controls.Add(this.run);
            this.Controls.Add(this.corn1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.mercy);
            this.Controls.Add(this.distract);
            this.Controls.Add(this.search);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.monster);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doorway";
            this.Text = "Start4";
            this.Load += new System.EventHandler(this.doorway_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rockpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.Timer monsterright;
        private System.Windows.Forms.Timer monsterleft;
        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label narrative4;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button distract;
        private System.Windows.Forms.Button mercy;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label mercytext;
        private System.Windows.Forms.Label distracttext;
        private System.Windows.Forms.Label searchtext;
        private System.Windows.Forms.Timer corntimer;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.PictureBox corn1;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Button throwsmth;
        private System.Windows.Forms.Label throwtxt;
        private System.Windows.Forms.PictureBox rockpic;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label nothrow;
    }
}