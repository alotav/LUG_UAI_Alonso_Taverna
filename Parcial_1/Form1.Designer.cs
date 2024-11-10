namespace Parcial_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboDeportes = new ComboBox();
            label2 = new Label();
            tbEquipoLocal = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbEquipoVisitante = new TextBox();
            dtpFechaPartido = new DateTimePicker();
            label5 = new Label();
            btnGuardar = new Button();
            label6 = new Label();
            label7 = new Label();
            tbIdPartido = new TextBox();
            label8 = new Label();
            btnEliminar = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tbModif = new TextBox();
            btnModif = new Button();
            label12 = new Label();
            dgvPartidos = new DataGridView();
            tbMarcadorLocal = new TextBox();
            tbMarcadorVis = new TextBox();
            label13 = new Label();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "NUEVO PARTIDO";
            // 
            // comboDeportes
            // 
            comboDeportes.FormattingEnabled = true;
            comboDeportes.Location = new Point(27, 82);
            comboDeportes.Name = "comboDeportes";
            comboDeportes.Size = new Size(121, 23);
            comboDeportes.TabIndex = 2;
            comboDeportes.SelectedIndexChanged += comboDeportes_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 55);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "DEPORTE";
            // 
            // tbEquipoLocal
            // 
            tbEquipoLocal.Location = new Point(169, 82);
            tbEquipoLocal.Name = "tbEquipoLocal";
            tbEquipoLocal.Size = new Size(124, 23);
            tbEquipoLocal.TabIndex = 4;
            tbEquipoLocal.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 55);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 5;
            label3.Text = "EQUIPO VISITANTE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 55);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 6;
            label4.Text = "EQUIPO LOCAL";
            // 
            // tbEquipoVisitante
            // 
            tbEquipoVisitante.Location = new Point(314, 82);
            tbEquipoVisitante.Name = "tbEquipoVisitante";
            tbEquipoVisitante.Size = new Size(124, 23);
            tbEquipoVisitante.TabIndex = 7;
            // 
            // dtpFechaPartido
            // 
            dtpFechaPartido.Location = new Point(480, 82);
            dtpFechaPartido.Name = "dtpFechaPartido";
            dtpFechaPartido.Size = new Size(200, 23);
            dtpFechaPartido.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(521, 55);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 9;
            label5.Text = "FECHA PARTIDO";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 255);
            btnGuardar.Location = new Point(706, 82);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 24);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 127);
            label6.Name = "label6";
            label6.Size = new Size(717, 15);
            label6.TabIndex = 11;
            label6.Text = "______________________________________________________________________________________________________________________________________________";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(521, 156);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 12;
            label7.Text = "ELIMINAR PARTIDO";
            label7.Click += label7_Click;
            // 
            // tbIdPartido
            // 
            tbIdPartido.Location = new Point(443, 217);
            tbIdPartido.Name = "tbIdPartido";
            tbIdPartido.Size = new Size(124, 23);
            tbIdPartido.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(443, 191);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 14;
            label8.Text = "ID DE PARTIDO";
            label8.Click += label8_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 128, 128);
            btnEliminar.Location = new Point(618, 215);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 24);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(388, 142);
            label9.Name = "label9";
            label9.Size = new Size(10, 135);
            label9.TabIndex = 16;
            label9.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(136, 156);
            label10.Name = "label10";
            label10.Size = new Size(127, 15);
            label10.TabIndex = 17;
            label10.Text = "MODIFICAR PARTIDO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(85, 191);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 19;
            label11.Text = "ID DE PARTIDO";
            // 
            // tbModif
            // 
            tbModif.Location = new Point(85, 217);
            tbModif.Name = "tbModif";
            tbModif.Size = new Size(124, 23);
            tbModif.TabIndex = 18;
            // 
            // btnModif
            // 
            btnModif.BackColor = Color.FromArgb(192, 255, 255);
            btnModif.Location = new Point(261, 217);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(82, 24);
            btnModif.TabIndex = 20;
            btnModif.Text = "Modificar";
            btnModif.UseVisualStyleBackColor = false;
            btnModif.Click += btnModif_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(43, 295);
            label12.Name = "label12";
            label12.Size = new Size(717, 15);
            label12.TabIndex = 21;
            label12.Text = "______________________________________________________________________________________________________________________________________________";
            label12.Click += label12_Click;
            // 
            // dgvPartidos
            // 
            dgvPartidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidos.Location = new Point(51, 313);
            dgvPartidos.Name = "dgvPartidos";
            dgvPartidos.Size = new Size(701, 150);
            dgvPartidos.TabIndex = 22;
            // 
            // tbMarcadorLocal
            // 
            tbMarcadorLocal.Location = new Point(85, 269);
            tbMarcadorLocal.Name = "tbMarcadorLocal";
            tbMarcadorLocal.Size = new Size(52, 23);
            tbMarcadorLocal.TabIndex = 23;
            // 
            // tbMarcadorVis
            // 
            tbMarcadorVis.Location = new Point(180, 269);
            tbMarcadorVis.Name = "tbMarcadorVis";
            tbMarcadorVis.Size = new Size(52, 23);
            tbMarcadorVis.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(85, 251);
            label13.Name = "label13";
            label13.Size = new Size(35, 15);
            label13.TabIndex = 25;
            label13.Text = "Local";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(180, 251);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 26;
            label14.Text = "Visitante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 507);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(tbMarcadorVis);
            Controls.Add(tbMarcadorLocal);
            Controls.Add(dgvPartidos);
            Controls.Add(label12);
            Controls.Add(btnModif);
            Controls.Add(label11);
            Controls.Add(tbModif);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(label8);
            Controls.Add(tbIdPartido);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(dtpFechaPartido);
            Controls.Add(tbEquipoVisitante);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbEquipoLocal);
            Controls.Add(label2);
            Controls.Add(comboDeportes);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPartidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboDeportes;
        private Label label2;
        private TextBox tbEquipoLocal;
        private Label label3;
        private Label label4;
        private TextBox tbEquipoVisitante;
        private DateTimePicker dtpFechaPartido;
        private Label label5;
        private Button btnGuardar;
        private Label label6;
        private Label label7;
        private TextBox tbIdPartido;
        private Label label8;
        private Button btnEliminar;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tbModif;
        private Button btnModif;
        private Label label12;
        private DataGridView dgvPartidos;
        private TextBox tbMarcadorLocal;
        private TextBox tbMarcadorVis;
        private Label label13;
        private Label label14;
    }
}
