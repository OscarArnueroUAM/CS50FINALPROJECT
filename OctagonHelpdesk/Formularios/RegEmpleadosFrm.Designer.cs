namespace OctagonHelpdesk.Formularios
{
    partial class RegEmpleadosFrm
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
            this.DgvRegUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnCrearEmpleado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvRegUsuarios
            // 
            this.DgvRegUsuarios.AllowUserToAddRows = false;
            this.DgvRegUsuarios.AllowUserToDeleteRows = false;
            this.DgvRegUsuarios.AllowUserToOrderColumns = true;
            this.DgvRegUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRegUsuarios.Location = new System.Drawing.Point(0, 0);
            this.DgvRegUsuarios.Name = "DgvRegUsuarios";
            this.DgvRegUsuarios.ReadOnly = true;
            this.DgvRegUsuarios.RowHeadersWidth = 62;
            this.DgvRegUsuarios.RowTemplate.Height = 28;
            this.DgvRegUsuarios.Size = new System.Drawing.Size(838, 454);
            this.DgvRegUsuarios.TabIndex = 0;
            // 
            // BtnCrearEmpleado
            // 
            this.BtnCrearEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearEmpleado.Location = new System.Drawing.Point(680, 23);
            this.BtnCrearEmpleado.Name = "BtnCrearEmpleado";
            this.BtnCrearEmpleado.Size = new System.Drawing.Size(135, 61);
            this.BtnCrearEmpleado.TabIndex = 1;
            this.BtnCrearEmpleado.Text = "Crear Empleado";
            this.BtnCrearEmpleado.UseVisualStyleBackColor = true;
            this.BtnCrearEmpleado.Click += new System.EventHandler(this.BtnCrearEmpleado_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCrearEmpleado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 105);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvRegUsuarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 454);
            this.panel2.TabIndex = 3;
            // 
            // RegEmpleadosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RegEmpleadosFrm";
            this.Text = "Registro de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRegUsuarios;
        private System.Windows.Forms.Button BtnCrearEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}