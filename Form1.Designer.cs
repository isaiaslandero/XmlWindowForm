namespace XmlWindowForm
{
	partial class Form1
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nombres_text = new System.Windows.Forms.TextBox();
			this.sexo_combo = new System.Windows.Forms.ComboBox();
			this.telefono_text = new System.Windows.Forms.TextBox();
			this.compania_combo = new System.Windows.Forms.ComboBox();
			this.direccion_text = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tablaListado = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablaListado)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.tablaListado);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.direccion_text);
			this.panel1.Controls.Add(this.compania_combo);
			this.panel1.Controls.Add(this.telefono_text);
			this.panel1.Controls.Add(this.sexo_combo);
			this.panel1.Controls.Add(this.nombres_text);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 417);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label1.Location = new System.Drawing.Point(16, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOMBRES:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label2.Location = new System.Drawing.Point(16, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "SEXO:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label3.Location = new System.Drawing.Point(16, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "TELEFONO:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.Location = new System.Drawing.Point(16, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "DIRECCION:";
			// 
			// nombres_text
			// 
			this.nombres_text.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.nombres_text.Location = new System.Drawing.Point(16, 37);
			this.nombres_text.Name = "nombres_text";
			this.nombres_text.Size = new System.Drawing.Size(212, 29);
			this.nombres_text.TabIndex = 4;
			// 
			// sexo_combo
			// 
			this.sexo_combo.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.sexo_combo.FormattingEnabled = true;
			this.sexo_combo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
			this.sexo_combo.Location = new System.Drawing.Point(69, 79);
			this.sexo_combo.Name = "sexo_combo";
			this.sexo_combo.Size = new System.Drawing.Size(159, 29);
			this.sexo_combo.TabIndex = 5;
			// 
			// telefono_text
			// 
			this.telefono_text.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.telefono_text.Location = new System.Drawing.Point(16, 143);
			this.telefono_text.Name = "telefono_text";
			this.telefono_text.Size = new System.Drawing.Size(101, 29);
			this.telefono_text.TabIndex = 6;
			// 
			// compania_combo
			// 
			this.compania_combo.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.compania_combo.FormattingEnabled = true;
			this.compania_combo.Items.AddRange(new object[] {
            "CLARO",
            "TIGO",
            "FIJO"});
			this.compania_combo.Location = new System.Drawing.Point(124, 143);
			this.compania_combo.Name = "compania_combo";
			this.compania_combo.Size = new System.Drawing.Size(105, 29);
			this.compania_combo.TabIndex = 7;
			// 
			// direccion_text
			// 
			this.direccion_text.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.direccion_text.Location = new System.Drawing.Point(16, 209);
			this.direccion_text.Multiline = true;
			this.direccion_text.Name = "direccion_text";
			this.direccion_text.Size = new System.Drawing.Size(214, 76);
			this.direccion_text.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button1.Location = new System.Drawing.Point(20, 305);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(210, 39);
			this.button1.TabIndex = 9;
			this.button1.Text = "AGREGAR AL LISTADO";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tablaListado
			// 
			this.tablaListado.AllowUserToAddRows = false;
			this.tablaListado.AllowUserToDeleteRows = false;
			this.tablaListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tablaListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRES,
            this.SEXO,
            this.TELEFONO,
            this.EMPRESA,
            this.DIRECCION});
			this.tablaListado.Location = new System.Drawing.Point(238, 12);
			this.tablaListado.Name = "tablaListado";
			this.tablaListado.ReadOnly = true;
			this.tablaListado.Size = new System.Drawing.Size(550, 332);
			this.tablaListado.TabIndex = 10;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.button2.Location = new System.Drawing.Point(402, 366);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(210, 39);
			this.button2.TabIndex = 11;
			this.button2.Text = "GUARDAR";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// NOMBRES
			// 
			this.NOMBRES.HeaderText = "NOMBRES";
			this.NOMBRES.Name = "NOMBRES";
			this.NOMBRES.ReadOnly = true;
			// 
			// SEXO
			// 
			this.SEXO.HeaderText = "SEXO";
			this.SEXO.Name = "SEXO";
			this.SEXO.ReadOnly = true;
			// 
			// TELEFONO
			// 
			this.TELEFONO.HeaderText = "TELEFONO";
			this.TELEFONO.Name = "TELEFONO";
			this.TELEFONO.ReadOnly = true;
			// 
			// EMPRESA
			// 
			this.EMPRESA.HeaderText = "EMPRESA";
			this.EMPRESA.Name = "EMPRESA";
			this.EMPRESA.ReadOnly = true;
			// 
			// DIRECCION
			// 
			this.DIRECCION.HeaderText = "DIRECCION";
			this.DIRECCION.Name = "DIRECCION";
			this.DIRECCION.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 417);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tablaListado)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView tablaListado;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox direccion_text;
		private System.Windows.Forms.ComboBox compania_combo;
		private System.Windows.Forms.TextBox telefono_text;
		private System.Windows.Forms.ComboBox sexo_combo;
		private System.Windows.Forms.TextBox nombres_text;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
		private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
		private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
		private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
		private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
	}
}

