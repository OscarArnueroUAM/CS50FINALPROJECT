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
            this.pnlBusquedaTicket = new System.Windows.Forms.Panel();
            this.BtnCrearTicket = new System.Windows.Forms.Button();
            this.pnlDgvRegTickets = new System.Windows.Forms.Panel();
            this.DgvRegTickets = new System.Windows.Forms.DataGridView();
            this.pnlBusquedaTicket.SuspendLayout();
            this.pnlDgvRegTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBusquedaTicket
            // 
            this.pnlBusquedaTicket.Controls.Add(this.BtnCrearTicket);
            this.pnlBusquedaTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusquedaTicket.Location = new System.Drawing.Point(20, 60);
            this.pnlBusquedaTicket.Name = "pnlBusquedaTicket";
            this.pnlBusquedaTicket.Size = new System.Drawing.Size(1029, 1449);
            this.pnlBusquedaTicket.TabIndex = 1;
            // 
            // BtnCrearTicket
            // 
            this.BtnCrearTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BtnCrearTicket.Location = new System.Drawing.Point(830, 16);
            this.BtnCrearTicket.Name = "BtnCrearTicket";
            this.BtnCrearTicket.Size = new System.Drawing.Size(149, 71);
            this.BtnCrearTicket.TabIndex = 0;
            this.BtnCrearTicket.Text = "Crear Ticket";
            this.BtnCrearTicket.UseVisualStyleBackColor = true;
            this.BtnCrearTicket.Click += new System.EventHandler(this.BtnCrearTicket_Click);
            // 
            // pnlDgvRegTickets
            // 
            this.pnlDgvRegTickets.Controls.Add(this.DgvRegTickets);
            this.pnlDgvRegTickets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDgvRegTickets.Location = new System.Drawing.Point(20, 166);
            this.pnlDgvRegTickets.Name = "pnlDgvRegTickets";
            this.pnlDgvRegTickets.Size = new System.Drawing.Size(1029, 535);
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
            this.DgvRegTickets.Size = new System.Drawing.Size(1029, 535);
            this.DgvRegTickets.TabIndex = 0;
            // 
            // RegTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 721);
            this.Controls.Add(this.pnlDgvRegTickets);
            this.Controls.Add(this.pnlBusquedaTicket);
            this.Name = "RegTickets";
            this.Text = "Registro Tickets";
            this.pnlBusquedaTicket.ResumeLayout(false);
            this.pnlDgvRegTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBusquedaTicket;
        private System.Windows.Forms.Panel pnlDgvRegTickets;
        private System.Windows.Forms.DataGridView DgvRegTickets;
        private System.Windows.Forms.Button BtnCrearTicket;
    }
}