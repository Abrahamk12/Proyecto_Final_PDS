namespace Proyecto_Final_PDS
{
    partial class subir_calificaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parcial = new System.Windows.Forms.TextBox();
            this.SubirBT = new System.Windows.Forms.Button();
            this.LimpiarBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.califacion = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(76, 13);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(193, 26);
            this.usuario.TabIndex = 1;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parcial";
            // 
            // parcial
            // 
            this.parcial.Location = new System.Drawing.Point(76, 107);
            this.parcial.Name = "parcial";
            this.parcial.Size = new System.Drawing.Size(193, 26);
            this.parcial.TabIndex = 5;
            this.parcial.TextChanged += new System.EventHandler(this.parcial_TextChanged);
            // 
            // SubirBT
            // 
            this.SubirBT.Location = new System.Drawing.Point(12, 223);
            this.SubirBT.Name = "SubirBT";
            this.SubirBT.Size = new System.Drawing.Size(75, 32);
            this.SubirBT.TabIndex = 6;
            this.SubirBT.Text = "Subir";
            this.SubirBT.UseVisualStyleBackColor = true;
            this.SubirBT.Click += new System.EventHandler(this.SubirBT_Click);
            // 
            // LimpiarBT
            // 
            this.LimpiarBT.Location = new System.Drawing.Point(188, 223);
            this.LimpiarBT.Name = "LimpiarBT";
            this.LimpiarBT.Size = new System.Drawing.Size(75, 32);
            this.LimpiarBT.TabIndex = 7;
            this.LimpiarBT.Text = "Limpiar";
            this.LimpiarBT.UseVisualStyleBackColor = true;
            this.LimpiarBT.Click += new System.EventHandler(this.LimpiarBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calificacion";
            // 
            // califacion
            // 
            this.califacion.Location = new System.Drawing.Point(93, 155);
            this.califacion.Name = "califacion";
            this.califacion.Size = new System.Drawing.Size(176, 26);
            this.califacion.TabIndex = 10;
            this.califacion.TextChanged += new System.EventHandler(this.califacion_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 27);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // subir_calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 267);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.califacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LimpiarBT);
            this.Controls.Add(this.SubirBT);
            this.Controls.Add(this.parcial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "subir_calificaciones";
            this.Text = "Subir Calificaciones";
            this.Load += new System.EventHandler(this.subir_calificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parcial;
        private System.Windows.Forms.Button SubirBT;
        private System.Windows.Forms.Button LimpiarBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox califacion;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}