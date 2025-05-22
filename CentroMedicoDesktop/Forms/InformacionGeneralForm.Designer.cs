namespace CentroMedicoDesktop.Forms
{
    partial class InformacionGeneralForm
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            dgvPacientes = new DataGridView();
            dgvTurnos = new DataGridView();
            dgvProfesionales = new DataGridView();
            dgvCentros = new DataGridView();
            btnActualizar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCentros).BeginInit();
            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(81, 86);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.Size = new Size(554, 100);
            dgvPacientes.TabIndex = 0;
            // 
            // dgvTurnos
            // 
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(721, 86);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.ReadOnly = true;
            dgvTurnos.Size = new Size(550, 100);
            dgvTurnos.TabIndex = 1;
            // 
            // dgvProfesionales
            // 
            dgvProfesionales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProfesionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesionales.Location = new Point(81, 366);
            dgvProfesionales.Name = "dgvProfesionales";
            dgvProfesionales.ReadOnly = true;
            dgvProfesionales.Size = new Size(554, 100);
            dgvProfesionales.TabIndex = 2;
            // 
            // dgvCentros
            // 
            dgvCentros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCentros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCentros.Location = new Point(721, 366);
            dgvCentros.Name = "dgvCentros";
            dgvCentros.ReadOnly = true;
            dgvCentros.Size = new Size(550, 100);
            dgvCentros.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(618, 258);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(115, 23);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar Datos";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 36);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 5;
            label1.Text = "PACIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(964, 36);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 6;
            label2.Text = "TURNOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 330);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 7;
            label3.Text = "PROFESIONALES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(941, 330);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 8;
            label4.Text = "CENTRO MEDICOS";
            // 
            // InformacionGeneralForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 634);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnActualizar);
            Controls.Add(dgvCentros);
            Controls.Add(dgvProfesionales);
            Controls.Add(dgvTurnos);
            Controls.Add(dgvPacientes);
            Name = "InformacionGeneralForm";
            Text = "InformacionGeneralForm";
            Load += InformacionGeneralForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCentros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPacientes;
        private DataGridView dgvTurnos;
        private DataGridView dgvProfesionales;
        private DataGridView dgvCentros;
        private Button btnActualizar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}