namespace GMedranda_ACT
{
    partial class Form1
    {
        /// Gabriel Medranda
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtcarrera = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnelmelim = new System.Windows.Forms.Button();
            this.btnelementos = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.miview = new System.Windows.Forms.ListView();
            this.colced = new System.Windows.Forms.ColumnHeader();
            this.colnom = new System.Windows.Forms.ColumnHeader();
            this.colape = new System.Windows.Forms.ColumnHeader();
            this.colcarr = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gabriel Medranda 15-06-22";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtcarrera);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(29, 241);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(275, 29);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar Alumno";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtcarrera
            // 
            this.txtcarrera.ForeColor = System.Drawing.Color.Black;
            this.txtcarrera.Location = new System.Drawing.Point(109, 194);
            this.txtcarrera.Name = "txtcarrera";
            this.txtcarrera.PlaceholderText = "Ingrese su carrera";
            this.txtcarrera.Size = new System.Drawing.Size(219, 27);
            this.txtcarrera.TabIndex = 7;
            // 
            // txtnombres
            // 
            this.txtnombres.ForeColor = System.Drawing.Color.Black;
            this.txtnombres.Location = new System.Drawing.Point(106, 146);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.PlaceholderText = "Ingrese sus nombres";
            this.txtnombres.Size = new System.Drawing.Size(222, 27);
            this.txtnombres.TabIndex = 6;
            // 
            // txtapellidos
            // 
            this.txtapellidos.ForeColor = System.Drawing.Color.Black;
            this.txtapellidos.Location = new System.Drawing.Point(106, 102);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.PlaceholderText = "Ingrese sus apellidos";
            this.txtapellidos.Size = new System.Drawing.Size(222, 27);
            this.txtapellidos.TabIndex = 5;
            this.txtapellidos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtcedula
            // 
            this.txtcedula.ForeColor = System.Drawing.Color.Black;
            this.txtcedula.Location = new System.Drawing.Point(106, 53);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.PlaceholderText = "Ingrese su cedula";
            this.txtcedula.Size = new System.Drawing.Size(222, 27);
            this.txtcedula.TabIndex = 4;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cédula";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnelmelim);
            this.groupBox2.Controls.Add(this.btnelementos);
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.miview);
            this.groupBox2.Location = new System.Drawing.Point(391, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 279);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // btnelmelim
            // 
            this.btnelmelim.Location = new System.Drawing.Point(432, 146);
            this.btnelmelim.Name = "btnelmelim";
            this.btnelmelim.Size = new System.Drawing.Size(216, 42);
            this.btnelmelim.TabIndex = 3;
            this.btnelmelim.Text = "Ver elementos eliminados";
            this.btnelmelim.UseVisualStyleBackColor = true;
            this.btnelmelim.Click += new System.EventHandler(this.btnelmelim_Click);
            // 
            // btnelementos
            // 
            this.btnelementos.Location = new System.Drawing.Point(429, 87);
            this.btnelementos.Name = "btnelementos";
            this.btnelementos.Size = new System.Drawing.Size(219, 42);
            this.btnelementos.TabIndex = 2;
            this.btnelementos.Text = "Ver elementos agregados";
            this.btnelementos.UseVisualStyleBackColor = true;
            this.btnelementos.Click += new System.EventHandler(this.btnelementos_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(429, 36);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(219, 37);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "Eliminar elemento";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // miview
            // 
            this.miview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colced,
            this.colnom,
            this.colape,
            this.colcarr});
            this.miview.Location = new System.Drawing.Point(6, 29);
            this.miview.Name = "miview";
            this.miview.Size = new System.Drawing.Size(405, 244);
            this.miview.TabIndex = 0;
            this.miview.UseCompatibleStateImageBehavior = false;
            this.miview.View = System.Windows.Forms.View.Details;
            this.miview.SelectedIndexChanged += new System.EventHandler(this.miview_SelectedIndexChanged);
            // 
            // colced
            // 
            this.colced.Text = "Cédula";
            this.colced.Width = 100;
            // 
            // colnom
            // 
            this.colnom.DisplayIndex = 2;
            this.colnom.Text = "Nombres";
            this.colnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colnom.Width = 100;
            // 
            // colape
            // 
            this.colape.DisplayIndex = 1;
            this.colape.Text = "Apellidos";
            this.colape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colape.Width = 100;
            // 
            // colcarr
            // 
            this.colcarr.Text = "Carrera";
            this.colcarr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colcarr.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtcarrera;
        private TextBox txtnombres;
        private TextBox txtapellidos;
        private TextBox txtcedula;
        private GroupBox groupBox2;
        private Button btnelementos;
        private Button btneliminar;
        private Button btnelmelim;
        private Button btnagregar;
        private ListView miview;
        private ColumnHeader colced;
        private ColumnHeader colape;
        private ColumnHeader colnom;
        private ColumnHeader colcarr;
    }
}