namespace OctagonHelpdesk
{
    partial class Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.paneltickets = new System.Windows.Forms.Panel();
            this.homebtn = new System.Windows.Forms.Button();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panelcontent = new System.Windows.Forms.Panel();
            this.containerhome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnagregarticket = new System.Windows.Forms.Button();
            this.panelouter = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelhelp = new System.Windows.Forms.Panel();
            this.btnhelp = new System.Windows.Forms.Button();
            this.panelsalir = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.paneluser = new System.Windows.Forms.Panel();
            this.btnuser = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.btnmenu = new System.Windows.Forms.Button();
            this.containerstimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.paneltickets.SuspendLayout();
            this.containerhome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelouter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelhelp.SuspendLayout();
            this.panelsalir.SuspendLayout();
            this.paneluser.SuspendLayout();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // paneltickets
            // 
            this.paneltickets.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.paneltickets.Controls.Add(this.homebtn);
            this.paneltickets.Location = new System.Drawing.Point(0, 0);
            this.paneltickets.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.paneltickets.Name = "paneltickets";
            this.paneltickets.Size = new System.Drawing.Size(143, 39);
            this.paneltickets.TabIndex = 1;
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.DarkGray;
            this.homebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.homebtn.Image = ((System.Drawing.Image)(resources.GetObject("homebtn.Image")));
            this.homebtn.Location = new System.Drawing.Point(-12, -19);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(166, 75);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "  Tickets";
            this.homebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 25;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // panelcontent
            // 
            this.panelcontent.Location = new System.Drawing.Point(334, 263);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(1213, 682);
            this.panelcontent.TabIndex = 1;
            // 
            // containerhome
            // 
            this.containerhome.Controls.Add(this.pictureBox3);
            this.containerhome.Controls.Add(this.button3);
            this.containerhome.Controls.Add(this.pictureBox2);
            this.containerhome.Controls.Add(this.button1);
            this.containerhome.Controls.Add(this.paneltickets);
            this.containerhome.Controls.Add(this.pictureBox1);
            this.containerhome.Controls.Add(this.btnagregarticket);
            this.containerhome.Location = new System.Drawing.Point(0, 93);
            this.containerhome.MaximumSize = new System.Drawing.Size(143, 150);
            this.containerhome.MinimumSize = new System.Drawing.Size(143, 39);
            this.containerhome.Name = "containerhome";
            this.containerhome.Size = new System.Drawing.Size(143, 39);
            this.containerhome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.BackgroundImage = global::OctagonHelpdesk.Properties.Resources.plus;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnagregarticket
            // 
            this.btnagregarticket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnagregarticket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregarticket.Location = new System.Drawing.Point(30, 38);
            this.btnagregarticket.Margin = new System.Windows.Forms.Padding(0);
            this.btnagregarticket.Name = "btnagregarticket";
            this.btnagregarticket.Size = new System.Drawing.Size(113, 37);
            this.btnagregarticket.TabIndex = 0;
            this.btnagregarticket.Text = "btnaddticket";
            this.btnagregarticket.UseVisualStyleBackColor = false;
            this.btnagregarticket.Click += new System.EventHandler(this.btnagregarticket_Click);
            // 
            // panelouter
            // 
            this.panelouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelouter.BackgroundImage")));
            this.panelouter.Controls.Add(this.containerhome);
            this.panelouter.Controls.Add(this.panel1);
            this.panelouter.Controls.Add(this.panelhelp);
            this.panelouter.Controls.Add(this.panelsalir);
            this.panelouter.Controls.Add(this.panelmenu);
            this.panelouter.Controls.Add(this.paneluser);
            this.panelouter.Location = new System.Drawing.Point(0, -40);
            this.panelouter.MaximumSize = new System.Drawing.Size(143, 740);
            this.panelouter.MinimumSize = new System.Drawing.Size(50, 740);
            this.panelouter.Name = "panelouter";
            this.panelouter.Size = new System.Drawing.Size(143, 740);
            this.panelouter.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panel1.Size = new System.Drawing.Size(143, 39);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(-12, -17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "  Usuario";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelhelp
            // 
            this.panelhelp.Controls.Add(this.btnhelp);
            this.panelhelp.Location = new System.Drawing.Point(0, 642);
            this.panelhelp.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panelhelp.Name = "panelhelp";
            this.panelhelp.Size = new System.Drawing.Size(143, 39);
            this.panelhelp.TabIndex = 6;
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.Color.DarkGray;
            this.btnhelp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhelp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnhelp.Image = ((System.Drawing.Image)(resources.GetObject("btnhelp.Image")));
            this.btnhelp.Location = new System.Drawing.Point(-12, -17);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(166, 75);
            this.btnhelp.TabIndex = 2;
            this.btnhelp.Text = "  Help";
            this.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhelp.UseVisualStyleBackColor = false;
            // 
            // panelsalir
            // 
            this.panelsalir.Controls.Add(this.btnsalir);
            this.panelsalir.Location = new System.Drawing.Point(0, 681);
            this.panelsalir.Name = "panelsalir";
            this.panelsalir.Size = new System.Drawing.Size(143, 39);
            this.panelsalir.TabIndex = 5;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.DarkGray;
            this.btnsalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(-12, -17);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(166, 75);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "  Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // paneluser
            // 
            this.paneluser.Controls.Add(this.btnuser);
            this.paneluser.Location = new System.Drawing.Point(0, 132);
            this.paneluser.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.paneluser.Name = "paneluser";
            this.paneluser.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.paneluser.Size = new System.Drawing.Size(143, 39);
            this.paneluser.TabIndex = 4;
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.DarkGray;
            this.btnuser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.SystemColors.Control;
            this.btnuser.Image = ((System.Drawing.Image)(resources.GetObject("btnuser.Image")));
            this.btnuser.Location = new System.Drawing.Point(-12, -17);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(166, 75);
            this.btnuser.TabIndex = 2;
            this.btnuser.Text = "  Usuario";
            this.btnuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnuser.UseVisualStyleBackColor = false;
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.btnmenu);
            this.panelmenu.Location = new System.Drawing.Point(0, 38);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(143, 49);
            this.panelmenu.TabIndex = 2;
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.DarkGray;
            this.btnmenu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnmenu.Image = global::OctagonHelpdesk.Properties.Resources.menu_1_;
            this.btnmenu.Location = new System.Drawing.Point(-12, -15);
            this.btnmenu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(165, 82);
            this.btnmenu.TabIndex = 1;
            this.btnmenu.Text = "     Menu";
            this.btnmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmenu.UseVisualStyleBackColor = false;
            this.btnmenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // containerstimer
            // 
            this.containerstimer.Interval = 15;
            this.containerstimer.Tick += new System.EventHandler(this.containerstimer_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.BackgroundImage = global::OctagonHelpdesk.Properties.Resources.plus;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 37);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(30, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "btnaddticket";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox3.BackgroundImage = global::OctagonHelpdesk.Properties.Resources.plus;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(30, 112);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "btnaddticket";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelouter);
            this.Controls.Add(this.panelcontent);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Frame";
            this.ShowIcon = false;
            this.Text = "Frame";
            this.Load += new System.EventHandler(this.Frame_Load);
            this.paneltickets.ResumeLayout(false);
            this.containerhome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelouter.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelhelp.ResumeLayout(false);
            this.panelsalir.ResumeLayout(false);
            this.paneluser.ResumeLayout(false);
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelouter;
        private System.Windows.Forms.Panel paneltickets;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Panel paneluser;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Panel panelsalir;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panelhelp;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel containerhome;
        private System.Windows.Forms.Button btnagregarticket;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer containerstimer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}