using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OctagonHelpdesk.Formularios
{
    public partial class CmpTicketFrm : Form
    {
        public CmpTicketFrm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lblTicketId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCreatedBy = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cmbAsigned = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketId.Location = new System.Drawing.Point(235, 27);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(79, 29);
            this.lblTicketId.TabIndex = 0;
            this.lblTicketId.Text = "Ticket";
            this.lblTicketId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Creado Por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Asunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Asignado a:";
            // 
            // txtCreatedBy
            // 
            this.txtCreatedBy.Location = new System.Drawing.Point(192, 76);
            this.txtCreatedBy.Name = "txtCreatedBy";
            this.txtCreatedBy.Size = new System.Drawing.Size(247, 26);
            this.txtCreatedBy.TabIndex = 6;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(192, 122);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(247, 26);
            this.txtSubject.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(192, 164);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(247, 104);
            this.txtDescription.TabIndex = 8;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(192, 287);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(172, 28);
            this.cmbState.TabIndex = 9;
            // 
            // cmbAsigned
            // 
            this.cmbAsigned.FormattingEnabled = true;
            this.cmbAsigned.Location = new System.Drawing.Point(192, 339);
            this.cmbAsigned.Name = "cmbAsigned";
            this.cmbAsigned.Size = new System.Drawing.Size(172, 28);
            this.cmbAsigned.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(36, 448);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 79);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(202, 448);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(151, 79);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(391, 448);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 79);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // CmpTicketFrm
            // 
            this.ClientSize = new System.Drawing.Size(577, 560);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbAsigned);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtCreatedBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTicketId);
            this.Name = "CmpTicketFrm";
            this.Text = "Campos Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
