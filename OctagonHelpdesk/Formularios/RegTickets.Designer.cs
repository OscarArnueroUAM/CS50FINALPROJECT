namespace OctagonHelpdesk.Formularios
{
    partial class RegTickets
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
            this.pnlTitleRegistroTicket = new System.Windows.Forms.Panel();
            this.pnlBusquedaTicket = new System.Windows.Forms.Panel();
            this.pnlDgvRegTickets = new System.Windows.Forms.Panel();
            this.DgvRegTickets = new System.Windows.Forms.DataGridView();
            this.pnlDgvRegTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleRegistroTicket
            // 
            this.pnlTitleRegistroTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleRegistroTicket.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleRegistroTicket.Name = "pnlTitleRegistroTicket";
            this.pnlTitleRegistroTicket.Size = new System.Drawing.Size(1069, 77);
            this.pnlTitleRegistroTicket.TabIndex = 0;
            // 
            // pnlBusquedaTicket
            // 
            this.pnlBusquedaTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBusquedaTicket.Location = new System.Drawing.Point(0, 77);
            this.pnlBusquedaTicket.Name = "pnlBusquedaTicket";
            this.pnlBusquedaTicket.Size = new System.Drawing.Size(1069, 644);
            this.pnlBusquedaTicket.TabIndex = 1;
            // 
            // pnlDgvRegTickets
            // 
            this.pnlDgvRegTickets.Controls.Add(this.DgvRegTickets);
            this.pnlDgvRegTickets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDgvRegTickets.Location = new System.Drawing.Point(0, 186);
            this.pnlDgvRegTickets.Name = "pnlDgvRegTickets";
            this.pnlDgvRegTickets.Size = new System.Drawing.Size(1069, 535);
            this.pnlDgvRegTickets.TabIndex = 2;
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
            this.DgvRegTickets.Size = new System.Drawing.Size(1069, 535);
            this.DgvRegTickets.TabIndex = 0;
            // 
            // RegTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 721);
            this.Controls.Add(this.pnlDgvRegTickets);
            this.Controls.Add(this.pnlBusquedaTicket);
            this.Controls.Add(this.pnlTitleRegistroTicket);
            this.Name = "RegTickets";
            this.Text = "RegTickets";
            this.pnlDgvRegTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleRegistroTicket;
        private System.Windows.Forms.Panel pnlBusquedaTicket;
        private System.Windows.Forms.Panel pnlDgvRegTickets;
        private System.Windows.Forms.DataGridView DgvRegTickets;
    }
}