namespace Agenda_telefonica
{
    partial class Agenda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.txtN = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.txtEncabezado = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.AutoSize = true;
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.ForeColor = System.Drawing.Color.White;
            this.txtN.Location = new System.Drawing.Point(95, 169);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(76, 20);
            this.txtN.TabIndex = 0;
            this.txtN.Text = "Nombre:";
            this.txtN.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 171);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(177, 269);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(175, 20);
            this.txtEdad.TabIndex = 3;
            // 
            // txtE
            // 
            this.txtE.AutoSize = true;
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.ForeColor = System.Drawing.Color.White;
            this.txtE.Location = new System.Drawing.Point(115, 269);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(56, 20);
            this.txtE.TabIndex = 2;
            this.txtE.Text = "Edad:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(177, 221);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(175, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.AutoSize = true;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.White;
            this.txtA.Location = new System.Drawing.Point(93, 219);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(78, 20);
            this.txtA.TabIndex = 4;
            this.txtA.Text = "Apellido:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(499, 223);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(175, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtD
            // 
            this.txtD.AutoSize = true;
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.ForeColor = System.Drawing.Color.White;
            this.txtD.Location = new System.Drawing.Point(404, 223);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(89, 20);
            this.txtD.TabIndex = 6;
            this.txtD.Text = "Direccion:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(177, 307);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(175, 20);
            this.txtFecha.TabIndex = 9;
            // 
            // txtF
            // 
            this.txtF.AutoSize = true;
            this.txtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF.ForeColor = System.Drawing.Color.White;
            this.txtF.Location = new System.Drawing.Point(46, 305);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(125, 20);
            this.txtF.TabIndex = 8;
            this.txtF.Text = "Fecha de Nac:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(177, 348);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(175, 20);
            this.txtPais.TabIndex = 11;
            // 
            // txtP
            // 
            this.txtP.AutoSize = true;
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.ForeColor = System.Drawing.Color.White;
            this.txtP.Location = new System.Drawing.Point(123, 348);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(48, 20);
            this.txtP.TabIndex = 10;
            this.txtP.Text = "Pais:";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(499, 267);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(175, 20);
            this.txtProvincia.TabIndex = 13;
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.ForeColor = System.Drawing.Color.White;
            this.P.Location = new System.Drawing.Point(407, 267);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(86, 20);
            this.P.TabIndex = 12;
            this.P.Text = "Provincia:";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(499, 311);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(175, 20);
            this.txtCell.TabIndex = 15;
            // 
            // txtC
            // 
            this.txtC.AutoSize = true;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.Color.White;
            this.txtC.Location = new System.Drawing.Point(449, 311);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(44, 20);
            this.txtC.TabIndex = 14;
            this.txtC.Text = "Cell:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(499, 348);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(175, 20);
            this.txtTel.TabIndex = 17;
            // 
            // txtT
            // 
            this.txtT.AutoSize = true;
            this.txtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT.ForeColor = System.Drawing.Color.White;
            this.txtT.Location = new System.Drawing.Point(455, 346);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(38, 20);
            this.txtT.TabIndex = 16;
            this.txtT.Text = "Tel:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(50, 384);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(839, 229);
            this.dgvDatos.TabIndex = 18;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatos_CellContentClick);
            this.dgvDatos.DoubleClick += new System.EventHandler(this.DgvDatos_DoubleClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(789, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.BackColorChanged += new System.EventHandler(this.red);
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(789, 223);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 30);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(789, 171);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 30);
            this.btnExportar.TabIndex = 24;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(541, 171);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(895, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(746, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 30);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(746, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 30);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(746, 171);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 30);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(499, 171);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(37, 30);
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // txtEncabezado
            // 
            this.txtEncabezado.AutoSize = true;
            this.txtEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncabezado.ForeColor = System.Drawing.Color.White;
            this.txtEncabezado.Location = new System.Drawing.Point(978, 20);
            this.txtEncabezado.Name = "txtEncabezado";
            this.txtEncabezado.Size = new System.Drawing.Size(381, 42);
            this.txtEncabezado.TabIndex = 26;
            this.txtEncabezado.Text = "Agenda Telefónica...";
            this.txtEncabezado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtEncabezado.Click += new System.EventHandler(this.Label10_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(453, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(134, 129);
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(177, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "Sgt.Programa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1312, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEncabezado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.P);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Telefónica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtN;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label txtE;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label txtA;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label txtD;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label txtF;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label txtP;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Label txtC;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label txtT;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label txtEncabezado;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button1;
    }
}

