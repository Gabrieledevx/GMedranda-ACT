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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colced = new System.Windows.Forms.ColumnHeader();
            this.colape = new System.Windows.Forms.ColumnHeader();
            this.colnom = new System.Windows.Forms.ColumnHeader();
            this.colcarr = new System.Windows.Forms.ColumnHeader();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnelementos = new System.Windows.Forms.Button();
            this.btnelmelim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gabriel Medranda 15-06-22";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtcedula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(26, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // textBox3
            // 
            this.textBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(109, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 27);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Ingrese su carrera";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(106, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 27);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Ingrese sus nombres";
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(106, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Ingrese sus apellidos";
            // 
            // txtcedula
            // 
            this.txtcedula.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtcedula.Location = new System.Drawing.Point(106, 53);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(222, 27);
            this.txtcedula.TabIndex = 4;
            this.txtcedula.Text = "Ingrese su cedula";
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
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(391, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colced,
            this.colape,
            this.colnom,
            this.colcarr});
            this.listView1.Location = new System.Drawing.Point(4, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(405, 192);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colced
            // 
            this.colced.Text = "Cédula";
            this.colced.Width = 100;
            // 
            // colape
            // 
            this.colape.Text = "Apellidos";
            this.colape.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colape.Width = 100;
            // 
            // colnom
            // 
            this.colnom.Text = "Nombres";
            this.colnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colnom.Width = 100;
            // 
            // colcarr
            // 
            this.colcarr.Text = "Carrera";
            this.colcarr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colcarr.Width = 100;
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
            // btnelementos
            // 
            this.btnelementos.Location = new System.Drawing.Point(429, 87);
            this.btnelementos.Name = "btnelementos";
            this.btnelementos.Size = new System.Drawing.Size(219, 42);
            this.btnelementos.TabIndex = 2;
            this.btnelementos.Text = "Elementos agregados";
            this.btnelementos.UseVisualStyleBackColor = true;
            // 
            // btnelmelim
            // 
            this.btnelmelim.Location = new System.Drawing.Point(432, 146);
            this.btnelmelim.Name = "btnelmelim";
            this.btnelmelim.Size = new System.Drawing.Size(216, 42);
            this.btnelmelim.TabIndex = 3;
            this.btnelmelim.Text = "Ver elementos eliminados";
            this.btnelmelim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 348);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
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
        private TextBox textBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtcedula;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader colced;
        private ColumnHeader colape;
        private ColumnHeader colnom;
        private ColumnHeader colcarr;
        private Button btnelementos;
        private Button btneliminar;
        private Button btnelmelim;
    }
}