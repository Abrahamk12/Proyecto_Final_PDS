namespace Proyecto_Final_PDS
{
    partial class registrar_alumno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cel_em = new System.Windows.Forms.TextBox();
            this.tutor = new System.Windows.Forms.TextBox();
            this.celular = new System.Windows.Forms.TextBox();
            this.correo = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.TextBox();
            this.registrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.cel_em);
            this.panel1.Controls.Add(this.tutor);
            this.panel1.Controls.Add(this.celular);
            this.panel1.Controls.Add(this.correo);
            this.panel1.Controls.Add(this.direccion);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.limpiar);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.registrar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 226);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cel_em
            // 
            this.cel_em.Location = new System.Drawing.Point(594, 83);
            this.cel_em.Name = "cel_em";
            this.cel_em.Size = new System.Drawing.Size(182, 26);
            this.cel_em.TabIndex = 17;
            this.cel_em.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cel_em.TextChanged += new System.EventHandler(this.cel_em_TextChanged);
            // 
            // tutor
            // 
            this.tutor.Location = new System.Drawing.Point(594, 46);
            this.tutor.Name = "tutor";
            this.tutor.Size = new System.Drawing.Size(182, 26);
            this.tutor.TabIndex = 16;
            this.tutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tutor.TextChanged += new System.EventHandler(this.tutor_TextChanged);
            // 
            // celular
            // 
            this.celular.Location = new System.Drawing.Point(594, 10);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(182, 26);
            this.celular.TabIndex = 15;
            this.celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.celular.TextChanged += new System.EventHandler(this.celular_TextChanged);
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(157, 147);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(193, 26);
            this.correo.TabIndex = 14;
            this.correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.correo.TextChanged += new System.EventHandler(this.correo_TextChanged);
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(157, 80);
            this.direccion.Multiline = true;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(193, 61);
            this.direccion.TabIndex = 13;
            this.direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.direccion.TextChanged += new System.EventHandler(this.direccion_TextChanged);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(157, 42);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(193, 26);
            this.usuario.TabIndex = 12;
            this.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(157, 10);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(193, 26);
            this.nombre.TabIndex = 11;
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre.TextChanged += new System.EventHandler(this.nombre_TextChanged);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(457, 179);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 35);
            this.limpiar.TabIndex = 10;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(594, 131);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(182, 26);
            this.fecha.TabIndex = 9;
            this.fecha.Text = "año-mes-día";
            this.fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fecha.TextChanged += new System.EventHandler(this.fecha_TextChanged);
            // 
            // registrar
            // 
            this.registrar.Location = new System.Drawing.Point(275, 179);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(75, 35);
            this.registrar.TabIndex = 8;
            this.registrar.Text = "Registrar";
            this.registrar.UseVisualStyleBackColor = true;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cell Emergencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tutor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 100);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // registrar_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 350);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "registrar_alumno";
            this.Text = "Registrar Alumno";
            this.Load += new System.EventHandler(this.registrar_alumno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cel_em;
        private System.Windows.Forms.TextBox tutor;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.Button registrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}