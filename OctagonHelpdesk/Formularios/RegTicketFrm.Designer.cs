namespace OctagonHelpdesk.Formularios
{
    partial class RegTicketFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCreateTicket = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvRegTickets = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCreateTicket);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 95);
            this.panel1.TabIndex = 0;
            // 
            // BtnCreateTicket
            // 
            this.BtnCreateTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateTicket.Location = new System.Drawing.Point(993, 12);
            this.BtnCreateTicket.Name = "BtnCreateTicket";
            this.BtnCreateTicket.Size = new System.Drawing.Size(152, 62);
            this.BtnCreateTicket.TabIndex = 0;
            this.BtnCreateTicket.Text = "Crear Ticket";
            this.BtnCreateTicket.UseVisualStyleBackColor = true;
            this.BtnCreateTicket.Click += new System.EventHandler(this.BtnCreateTicket_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvRegTickets);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 736);
            this.panel2.TabIndex = 1;
            // 
            // DgvRegTickets
            // 
            this.DgvRegTickets.AllowUserToAddRows = false;
            this.DgvRegTickets.AllowUserToDeleteRows = false;
            this.DgvRegTickets.AllowUserToOrderColumns = true;
            this.DgvRegTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRegTickets.Location = new System.Drawing.Point(0, 0);
            this.DgvRegTickets.Name = "DgvRegTickets";
            this.DgvRegTickets.ReadOnly = true;
            this.DgvRegTickets.RowHeadersWidth = 62;
            this.DgvRegTickets.RowTemplate.Height = 28;
            this.DgvRegTickets.Size = new System.Drawing.Size(1157, 736);
            this.DgvRegTickets.TabIndex = 0;
       
            // 
            // RegTicketFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 831);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegTicketFrm";
            this.Text = "Registro de Tickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCreateTicket;
        private System.Windows.Forms.DataGridView DgvRegTickets;
    }
}