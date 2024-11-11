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
            this.DgvRegEmpleados = new System.Windows.Forms.DataGridView();
            this.BtnCrearEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRegEmpleados
            // 
            this.DgvRegEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegEmpleados.Location = new System.Drawing.Point(42, 137);
            this.DgvRegEmpleados.Name = "DgvRegEmpleados";
            this.DgvRegEmpleados.RowHeadersWidth = 62;
            this.DgvRegEmpleados.RowTemplate.Height = 28;
            this.DgvRegEmpleados.Size = new System.Drawing.Size(726, 294);
            this.DgvRegEmpleados.TabIndex = 0;
            // 
            // BtnCrearEmpleado
            // 
            this.BtnCrearEmpleado.Location = new System.Drawing.Point(633, 59);
            this.BtnCrearEmpleado.Name = "BtnCrearEmpleado";
            this.BtnCrearEmpleado.Size = new System.Drawing.Size(135, 61);
            this.BtnCrearEmpleado.TabIndex = 1;
            this.BtnCrearEmpleado.Text = "Crear Empleado";
            this.BtnCrearEmpleado.UseVisualStyleBackColor = true;
            // 
            // RegEmpleadosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCrearEmpleado);
            this.Controls.Add(this.DgvRegEmpleados);
            this.Name = "RegEmpleadosFrm";
            this.Text = "Registro de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRegEmpleados;
        private System.Windows.Forms.Button BtnCrearEmpleado;
    }
}