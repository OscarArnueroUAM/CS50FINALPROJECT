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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.DgvRegUsuarios.Size = new System.Drawing.Size(1003, 730);
            this.DgvRegUsuarios.TabIndex = 0;
            // 
            // BtnCrearEmpleado
            // 
            this.BtnCrearEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCrearEmpleado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCrearEmpleado.Location = new System.Drawing.Point(856, 96);
            this.BtnCrearEmpleado.Name = "BtnCrearEmpleado";
            this.BtnCrearEmpleado.Size = new System.Drawing.Size(135, 61);
            this.BtnCrearEmpleado.TabIndex = 1;
            this.BtnCrearEmpleado.Text = "Crear Empleado";
            this.BtnCrearEmpleado.UseVisualStyleBackColor = false;
            this.BtnCrearEmpleado.Click += new System.EventHandler(this.BtnCrearEmpleado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BtnCrearEmpleado);
            this.panel1.Location = new System.Drawing.Point(215, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 176);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvRegUsuarios);
            this.panel2.Location = new System.Drawing.Point(230, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 730);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::OctagonHelpdesk.Properties.Resources.wavebckg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 921);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(130, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 28);
            this.comboBox1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Filtrar Por:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(644, 81);
            this.label6.TabIndex = 20;
            this.label6.Text = "Registro de Empleados";
            // 
            // RegEmpleadosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1245, 921);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "RegEmpleadosFrm";
            this.Text = "Registro de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRegUsuarios;
        private System.Windows.Forms.Button BtnCrearEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}