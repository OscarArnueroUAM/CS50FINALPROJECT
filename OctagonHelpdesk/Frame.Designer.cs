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
            this.panelouter = new System.Windows.Forms.Panel();
            this.panelhome = new System.Windows.Forms.Panel();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelouter.SuspendLayout();
            this.panelhome.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelouter
            // 
            this.panelouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panelouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelouter.BackgroundImage")));
            this.panelouter.Controls.Add(this.panelmenu);
            this.panelouter.Controls.Add(this.panelhome);
            this.panelouter.Location = new System.Drawing.Point(0, -40);
            this.panelouter.MaximumSize = new System.Drawing.Size(143, 740);
            this.panelouter.MinimumSize = new System.Drawing.Size(50, 740);
            this.panelouter.Name = "panelouter";
            this.panelouter.Size = new System.Drawing.Size(143, 740);
            this.panelouter.TabIndex = 0;
            this.panelouter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelouter_Paint);
            // 
            // panelhome
            // 
            this.panelhome.Controls.Add(this.homebtn);
            this.panelhome.Location = new System.Drawing.Point(0, 93);
            this.panelhome.Name = "panelhome";
            this.panelhome.Size = new System.Drawing.Size(143, 39);
            this.panelhome.TabIndex = 1;
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.button1);
            this.panelmenu.Location = new System.Drawing.Point(0, 38);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(143, 49);
            this.panelmenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::OctagonHelpdesk.Properties.Resources.menu_1_;
            this.button1.Location = new System.Drawing.Point(-11, -17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "   Menu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // homebtn
            // 
            this.homebtn.BackColor = System.Drawing.Color.DarkGray;
            this.homebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.homebtn.Image = ((System.Drawing.Image)(resources.GetObject("homebtn.Image")));
            this.homebtn.Location = new System.Drawing.Point(-12, -17);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(166, 75);
            this.homebtn.TabIndex = 2;
            this.homebtn.Text = "  Home";
            this.homebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homebtn.UseVisualStyleBackColor = false;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // sidebartimer
            // 
            this.sidebartimer.Interval = 50;
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(52, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 682);
            this.panel1.TabIndex = 1;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelouter);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Frame";
            this.ShowIcon = false;
            this.Text = "Frame";
            this.panelouter.ResumeLayout(false);
            this.panelhome.ResumeLayout(false);
            this.panelmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelouter;
        private System.Windows.Forms.Panel panelhome;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Timer sidebartimer;
        private System.Windows.Forms.Panel panel1;
    }
}