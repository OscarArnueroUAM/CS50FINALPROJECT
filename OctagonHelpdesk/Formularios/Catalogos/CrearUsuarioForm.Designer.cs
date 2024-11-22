﻿namespace OctagonHelpdesk.Formularios
{
    partial class CrearUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuarioForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.CheckBox();
            this.cbIT = new System.Windows.Forms.CheckBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.btnConfirmUserCreation = new System.Windows.Forms.Button();
            this.tbIDUser = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLastname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbDepartamento);
            this.groupBox1.Controls.Add(this.cbEmpleado);
            this.groupBox1.Controls.Add(this.cbIT);
            this.groupBox1.Controls.Add(this.cbAdmin);
            this.groupBox1.Controls.Add(this.btnConfirmUserCreation);
            this.groupBox1.Controls.Add(this.tbIDUser);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(66, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(525, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tbLastname
            // 
            this.tbLastname.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbLastname.Location = new System.Drawing.Point(188, 103);
            this.tbLastname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(224, 20);
            this.tbLastname.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Apellido:";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(188, 182);
            this.cmbDepartamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(91, 21);
            this.cmbDepartamento.TabIndex = 14;
            this.cmbDepartamento.Text = "...";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.AutoSize = true;
            this.cbEmpleado.Location = new System.Drawing.Point(339, 224);
            this.cbEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(80, 21);
            this.cbEmpleado.TabIndex = 13;
            this.cbEmpleado.Text = "Empleado";
            this.cbEmpleado.UseVisualStyleBackColor = true;
            // 
            // cbIT
            // 
            this.cbIT.AutoSize = true;
            this.cbIT.Location = new System.Drawing.Point(255, 224);
            this.cbIT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIT.Name = "cbIT";
            this.cbIT.Size = new System.Drawing.Size(85, 21);
            this.cbIT.TabIndex = 12;
            this.cbIT.Text = "Tecnico IT";
            this.cbIT.UseVisualStyleBackColor = true;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(188, 224);
            this.cbAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(62, 21);
            this.cbAdmin.TabIndex = 11;
            this.cbAdmin.Text = "Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnConfirmUserCreation
            // 
            this.btnConfirmUserCreation.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmUserCreation.Location = new System.Drawing.Point(202, 254);
            this.btnConfirmUserCreation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmUserCreation.Name = "btnConfirmUserCreation";
            this.btnConfirmUserCreation.Size = new System.Drawing.Size(112, 43);
            this.btnConfirmUserCreation.TabIndex = 10;
            this.btnConfirmUserCreation.Text = "Guardar";
            this.btnConfirmUserCreation.UseVisualStyleBackColor = false;
            this.btnConfirmUserCreation.Click += new System.EventHandler(this.btnConfirmUserCreation_Click);
            // 
            // tbIDUser
            // 
            this.tbIDUser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbIDUser.Location = new System.Drawing.Point(188, 24);
            this.tbIDUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIDUser.Name = "tbIDUser";
            this.tbIDUser.Size = new System.Drawing.Size(224, 20);
            this.tbIDUser.TabIndex = 0;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbName.Location = new System.Drawing.Point(188, 61);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbEmail.Location = new System.Drawing.Point(188, 139);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(224, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Permisos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID de empleado:";
            // 
            // CrearUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearUsuarioForm";
            this.Text = "Campos Usuario";
            this.Load += new System.EventHandler(this.CrearUsuarioForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmUserCreation;
        private System.Windows.Forms.TextBox tbIDUser;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.CheckBox cbEmpleado;
        private System.Windows.Forms.CheckBox cbIT;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Label label7;
    }
}