namespace CYOA_Summative
{
    partial class beginning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(beginning));
            this.backstory = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Label();
            this.whatdo = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.cry = new System.Windows.Forms.Button();
            this.venture = new System.Windows.Forms.Button();
            this.leave = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.Button();
            this.searchtext = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.PictureBox();
            this.cornobtain = new System.Windows.Forms.Label();
            this.crytext = new System.Windows.Forms.Label();
            this.rockobtain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.item)).BeginInit();
            this.SuspendLayout();
            // 
            // backstory
            // 
            this.backstory.BackColor = System.Drawing.Color.PapayaWhip;
            this.backstory.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backstory.Location = new System.Drawing.Point(45, 36);
            this.backstory.Name = "backstory";
            this.backstory.Size = new System.Drawing.Size(601, 67);
            this.backstory.TabIndex = 0;
            this.backstory.Text = resources.GetString("backstory.Text");
            this.backstory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Tan;
            this.background.Location = new System.Drawing.Point(28, 20);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(635, 101);
            this.background.TabIndex = 1;
            // 
            // whatdo
            // 
            this.whatdo.BackColor = System.Drawing.Color.PapayaWhip;
            this.whatdo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatdo.Location = new System.Drawing.Point(45, 36);
            this.whatdo.Name = "whatdo";
            this.whatdo.Size = new System.Drawing.Size(601, 67);
            this.whatdo.TabIndex = 2;
            this.whatdo.Text = "What would you like to do?";
            this.whatdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.whatdo.Visible = false;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(569, 126);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(86, 28);
            this.next.TabIndex = 3;
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
            this.search.TabIndex = 4;
            this.search.Text = "SEARCH THE AREA";
            this.search.UseVisualStyleBackColor = true;
            this.search.Visible = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // cry
            // 
            this.cry.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cry.Location = new System.Drawing.Point(200, 134);
            this.cry.Name = "cry";
            this.cry.Size = new System.Drawing.Size(131, 52);
            this.cry.TabIndex = 5;
            this.cry.Text = "CRY AND SCREAM FOR HELP";
            this.cry.UseVisualStyleBackColor = true;
            this.cry.Visible = false;
            this.cry.Click += new System.EventHandler(this.cry_Click);
            // 
            // venture
            // 
            this.venture.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venture.Location = new System.Drawing.Point(373, 134);
            this.venture.Name = "venture";
            this.venture.Size = new System.Drawing.Size(131, 52);
            this.venture.TabIndex = 6;
            this.venture.Text = "VENTURE FURTHER";
            this.venture.UseVisualStyleBackColor = true;
            this.venture.Visible = false;
            this.venture.Click += new System.EventHandler(this.venture_Click);
            // 
            // leave
            // 
            this.leave.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave.Location = new System.Drawing.Point(532, 134);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(131, 52);
            this.leave.TabIndex = 7;
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
            this.inventory.TabIndex = 8;
            this.inventory.Text = "INVENTORY";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // searchtext
            // 
            this.searchtext.BackColor = System.Drawing.Color.PapayaWhip;
            this.searchtext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtext.Location = new System.Drawing.Point(45, 36);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(601, 67);
            this.searchtext.TabIndex = 9;
            this.searchtext.Text = "You search around the surrounding area wildly. Fortunately, in your desperate sea" +
    "rch, you are able to find an ear of corn. Surprisingly ripe!";
            this.searchtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchtext.Visible = false;
            // 
            // item
            // 
            this.item.BackColor = System.Drawing.Color.Transparent;
            this.item.Location = new System.Drawing.Point(229, 201);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(235, 262);
            this.item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item.TabIndex = 10;
            this.item.TabStop = false;
            // 
            // cornobtain
            // 
            this.cornobtain.BackColor = System.Drawing.Color.PapayaWhip;
            this.cornobtain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cornobtain.Location = new System.Drawing.Point(250, 464);
            this.cornobtain.Name = "cornobtain";
            this.cornobtain.Size = new System.Drawing.Size(200, 36);
            this.cornobtain.TabIndex = 11;
            this.cornobtain.Text = "Ear of corn obtained!";
            this.cornobtain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cornobtain.Visible = false;
            // 
            // crytext
            // 
            this.crytext.BackColor = System.Drawing.Color.PapayaWhip;
            this.crytext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crytext.Location = new System.Drawing.Point(45, 36);
            this.crytext.Name = "crytext";
            this.crytext.Size = new System.Drawing.Size(601, 67);
            this.crytext.TabIndex = 12;
            this.crytext.Text = "Your aggressively loud wails of terror echo through the hallway. A rock comes loo" +
    "se from the ceiling and nearly bludgeons you to death. Lucky you! You pocket the" +
    " rock.";
            this.crytext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.crytext.Visible = false;
            // 
            // rockobtain
            // 
            this.rockobtain.BackColor = System.Drawing.Color.PapayaWhip;
            this.rockobtain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockobtain.Location = new System.Drawing.Point(250, 464);
            this.rockobtain.Name = "rockobtain";
            this.rockobtain.Size = new System.Drawing.Size(200, 36);
            this.rockobtain.TabIndex = 13;
            this.rockobtain.Text = "Large rock obtained!";
            this.rockobtain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rockobtain.Visible = false;
            // 
            // beginning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources._67732a5bc66b541c5d06e3b2281a262a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.rockobtain);
            this.Controls.Add(this.crytext);
            this.Controls.Add(this.cornobtain);
            this.Controls.Add(this.item);
            this.Controls.Add(this.searchtext);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.venture);
            this.Controls.Add(this.cry);
            this.Controls.Add(this.search);
            this.Controls.Add(this.next);
            this.Controls.Add(this.whatdo);
            this.Controls.Add(this.backstory);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "beginning";
            this.Text = "Start1";
            ((System.ComponentModel.ISupportInitialize)(this.item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label backstory;
        private System.Windows.Forms.Label background;
        private System.Windows.Forms.Label whatdo;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button cry;
        private System.Windows.Forms.Button venture;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Label searchtext;
        private System.Windows.Forms.PictureBox item;
        private System.Windows.Forms.Label cornobtain;
        private System.Windows.Forms.Label crytext;
        private System.Windows.Forms.Label rockobtain;
    }
}