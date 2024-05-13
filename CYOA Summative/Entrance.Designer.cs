namespace CYOA_Summative
{
    partial class Entrance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrance));
            this.sword1 = new System.Windows.Forms.PictureBox();
            this.inventory = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.buttonpuz = new System.Windows.Forms.Button();
            this.keypad = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.narrative = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.Label();
            this.cluepic = new System.Windows.Forms.PictureBox();
            this.ok = new System.Windows.Forms.Button();
            this.keypadgood = new System.Windows.Forms.Timer(this.components);
            this.buttongood = new System.Windows.Forms.Timer(this.components);
            this.success = new System.Windows.Forms.Label();
            this.complete = new System.Windows.Forms.Timer(this.components);
            this.next = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sword1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cluepic)).BeginInit();
            this.SuspendLayout();
            // 
            // sword1
            // 
            this.sword1.BackColor = System.Drawing.Color.Transparent;
            this.sword1.Image = global::CYOA_Summative.Properties.Resources.sword;
            this.sword1.Location = new System.Drawing.Point(552, 336);
            this.sword1.Name = "sword1";
            this.sword1.Size = new System.Drawing.Size(102, 137);
            this.sword1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sword1.TabIndex = 41;
            this.sword1.TabStop = false;
            this.sword1.Click += new System.EventHandler(this.corn1_Click);
            // 
            // inventory
            // 
            this.inventory.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory.Location = new System.Drawing.Point(12, 533);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(104, 33);
            this.inventory.TabIndex = 50;
            this.inventory.Text = "INVENTORY";
            this.inventory.UseVisualStyleBackColor = true;
            this.inventory.Click += new System.EventHandler(this.inventory_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(524, 215);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 52);
            this.back.TabIndex = 57;
            this.back.Text = "GO BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(523, 143);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(131, 52);
            this.exit.TabIndex = 56;
            this.exit.Text = "EXIT TO MAIN MENU";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // buttonpuz
            // 
            this.buttonpuz.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonpuz.Location = new System.Drawing.Point(359, 143);
            this.buttonpuz.Name = "buttonpuz";
            this.buttonpuz.Size = new System.Drawing.Size(131, 52);
            this.buttonpuz.TabIndex = 55;
            this.buttonpuz.Text = "VIEW BUTTONS";
            this.buttonpuz.UseVisualStyleBackColor = true;
            this.buttonpuz.Click += new System.EventHandler(this.buttonpuz_Click);
            // 
            // keypad
            // 
            this.keypad.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keypad.Location = new System.Drawing.Point(196, 143);
            this.keypad.Name = "keypad";
            this.keypad.Size = new System.Drawing.Size(131, 52);
            this.keypad.TabIndex = 54;
            this.keypad.Text = "VIEW KEYPAD";
            this.keypad.UseVisualStyleBackColor = true;
            this.keypad.Click += new System.EventHandler(this.keypad_Click);
            // 
            // paper
            // 
            this.paper.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paper.Location = new System.Drawing.Point(32, 143);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(131, 52);
            this.paper.TabIndex = 53;
            this.paper.Text = "VIEW PAPER";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // narrative
            // 
            this.narrative.BackColor = System.Drawing.Color.PapayaWhip;
            this.narrative.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.narrative.Location = new System.Drawing.Point(46, 36);
            this.narrative.Name = "narrative";
            this.narrative.Size = new System.Drawing.Size(601, 79);
            this.narrative.TabIndex = 52;
            this.narrative.Text = resources.GetString("narrative.Text");
            this.narrative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Tan;
            this.background.Location = new System.Drawing.Point(29, 20);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(635, 112);
            this.background.TabIndex = 51;
            // 
            // cluepic
            // 
            this.cluepic.BackColor = System.Drawing.Color.Transparent;
            this.cluepic.Image = global::CYOA_Summative.Properties.Resources.clue1;
            this.cluepic.Location = new System.Drawing.Point(162, 52);
            this.cluepic.Name = "cluepic";
            this.cluepic.Size = new System.Drawing.Size(384, 492);
            this.cluepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cluepic.TabIndex = 58;
            this.cluepic.TabStop = false;
            this.cluepic.Visible = false;
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(445, 490);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(73, 27);
            this.ok.TabIndex = 59;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Visible = false;
            this.ok.Click += new System.EventHandler(this.next_Click);
            // 
            // keypadgood
            // 
            this.keypadgood.Enabled = true;
            this.keypadgood.Interval = 1;
            this.keypadgood.Tick += new System.EventHandler(this.keypadgood_Tick);
            // 
            // buttongood
            // 
            this.buttongood.Enabled = true;
            this.buttongood.Interval = 1;
            this.buttongood.Tick += new System.EventHandler(this.buttongood_Tick);
            // 
            // success
            // 
            this.success.BackColor = System.Drawing.Color.PapayaWhip;
            this.success.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.success.Location = new System.Drawing.Point(53, 36);
            this.success.Name = "success";
            this.success.Size = new System.Drawing.Size(601, 79);
            this.success.TabIndex = 60;
            this.success.Text = "A click! The door must be open...";
            this.success.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.success.Visible = false;
            // 
            // complete
            // 
            this.complete.Enabled = true;
            this.complete.Interval = 1;
            this.complete.Tick += new System.EventHandler(this.complete_Tick);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(43, 139);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(86, 29);
            this.next.TabIndex = 61;
            this.next.Text = "CONTINUE";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click_1);
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYOA_Summative.Properties.Resources.start4f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 578);
            this.Controls.Add(this.next);
            this.Controls.Add(this.success);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.buttonpuz);
            this.Controls.Add(this.keypad);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.narrative);
            this.Controls.Add(this.background);
            this.Controls.Add(this.inventory);
            this.Controls.Add(this.sword1);
            this.Controls.Add(this.cluepic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Entrance";
            ((System.ComponentModel.ISupportInitialize)(this.sword1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cluepic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sword1;
        private System.Windows.Forms.Button inventory;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button buttonpuz;
        private System.Windows.Forms.Button keypad;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Label narrative;
        private System.Windows.Forms.Label background;
        private System.Windows.Forms.PictureBox cluepic;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Timer keypadgood;
        private System.Windows.Forms.Timer buttongood;
        private System.Windows.Forms.Label success;
        private System.Windows.Forms.Timer complete;
        private System.Windows.Forms.Button next;
    }
}