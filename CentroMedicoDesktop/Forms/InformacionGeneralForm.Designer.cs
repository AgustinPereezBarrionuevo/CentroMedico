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
        /// the contents of this method with the code editor.|
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacionGeneralForm));
            dgvPacientes = new DataGridView();
            dgvTurnos = new DataGridView();
            dgvProfesionales = new DataGridView();
            dgvCentros = new DataGridView();
            btnActualizar = new Button();

            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();

            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();

            btnEliminarPaciente = new Button();
            btnActualizarPaciente = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCentros).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();

            menuStrip1.SuspendLayout();


            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.BorderStyle = BorderStyle.None;
            dgvPacientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.GridColor = Color.FromArgb(224, 224, 224);
            dgvPacientes.Location = new Point(6, 7);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(662, 306);
            dgvPacientes.TabIndex = 0;
            // 
            // dgvTurnos
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvTurnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.BorderStyle = BorderStyle.None;
            dgvTurnos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvTurnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.GridColor = Color.FromArgb(224, 224, 224);
            dgvTurnos.Location = new Point(6, 6);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.ReadOnly = true;
            dgvTurnos.Size = new Size(662, 360);
            dgvTurnos.TabIndex = 1;
            // 
            // dgvProfesionales
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvProfesionales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProfesionales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProfesionales.BorderStyle = BorderStyle.None;
            dgvProfesionales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvProfesionales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvProfesionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesionales.GridColor = Color.FromArgb(224, 224, 224);
            dgvProfesionales.Location = new Point(6, 6);
            dgvProfesionales.Name = "dgvProfesionales";
            dgvProfesionales.ReadOnly = true;
            dgvProfesionales.Size = new Size(662, 360);
            dgvProfesionales.TabIndex = 2;
            // 
            // dgvCentros
            // 
            dataGridViewCellStyle7.BackColor = Color.FromArgb(248, 248, 248);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dgvCentros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvCentros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCentros.BorderStyle = BorderStyle.None;
            dgvCentros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvCentros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvCentros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCentros.GridColor = Color.FromArgb(224, 224, 224);
            dgvCentros.Location = new Point(6, 6);
            dgvCentros.Name = "dgvCentros";
            dgvCentros.ReadOnly = true;
            dgvCentros.Size = new Size(662, 360);
            dgvCentros.TabIndex = 3;
            // 
            // tabControl1
            // 

            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(323, 126);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(682, 347);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvPacientes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(674, 319);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PACIENTES";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCentros);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(674, 319);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CENTRO MEDICOS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvProfesionales);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(674, 319);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PROFESIONALES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 

            btnActualizar.BackColor = Color.FromArgb(74, 144, 226);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(593, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(115, 23);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar Datos";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(337, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(682, 347);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvPacientes);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(674, 319);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PACIENTES";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCentros);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(674, 319);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "CENTRO MEDICOS";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvProfesionales);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(674, 319);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "PROFESIONALES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 

            tabPage4.Controls.Add(dgvTurnos);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(674, 319);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "TURNOS";
            tabPage4.UseVisualStyleBackColor = true;
            // 

            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1380, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(60, 20);
            toolStripMenuItem1.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem, eliminarToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(58, 20);
            toolStripMenuItem2.Text = "Edicion";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(180, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(180, 22);
            modificarToolStripMenuItem.Text = "Modificar";
            modificarToolStripMenuItem.Click += modificarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(180, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(87, 20);
            toolStripMenuItem3.Text = "Actualizar";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;

            // btnEliminarPaciente
            // 
            btnEliminarPaciente.BackColor = Color.FromArgb(74, 144, 226);
            btnEliminarPaciente.FlatAppearance.BorderSize = 0;
            btnEliminarPaciente.FlatStyle = FlatStyle.Flat;
            btnEliminarPaciente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPaciente.ForeColor = Color.White;
            btnEliminarPaciente.Location = new Point(895, 394);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(101, 39);
            btnEliminarPaciente.TabIndex = 2;
            btnEliminarPaciente.Text = "ELIMINAR";
            btnEliminarPaciente.UseVisualStyleBackColor = false;
            btnEliminarPaciente.Click += btnEliminarPaciente_Click;
            // 
            // btnActualizarPaciente
            // 
            btnActualizarPaciente.BackColor = Color.FromArgb(74, 144, 226);
            btnActualizarPaciente.FlatAppearance.BorderSize = 0;
            btnActualizarPaciente.FlatStyle = FlatStyle.Flat;
            btnActualizarPaciente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarPaciente.ForeColor = Color.White;
            btnActualizarPaciente.Location = new Point(377, 394);
            btnActualizarPaciente.Name = "btnActualizarPaciente";
            btnActualizarPaciente.Size = new Size(104, 39);
            btnActualizarPaciente.TabIndex = 1;
            btnActualizarPaciente.Text = "EDITAR";
            btnActualizarPaciente.UseVisualStyleBackColor = false;
            btnActualizarPaciente.Click += btnActualizarPaciente_Click;

            // 
            // InformacionGeneralForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1380, 634);

            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;

            Controls.Add(btnEliminarPaciente);
            Controls.Add(tabControl1);
            Controls.Add(btnActualizarPaciente);
            Controls.Add(btnActualizar);

            Name = "InformacionGeneralForm";
            Text = "InformacionGeneralForm";
            Load += InformacionGeneralForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfesionales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCentros).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);

            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();

            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPacientes;
        private DataGridView dgvTurnos;
        private DataGridView dgvProfesionales;
        private DataGridView dgvCentros;

        private Button btnActualizar;

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;

        private Button btnEliminarPaciente;
        private Button btnActualizarPaciente;

    }
}