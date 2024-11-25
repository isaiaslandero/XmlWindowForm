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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.comboBox2);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.textBox1);
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
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBox1.Location = new System.Drawing.Point(16, 37);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(212, 29);
			this.textBox1.TabIndex = 4;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
			this.comboBox1.Location = new System.Drawing.Point(69, 79);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(159, 29);
			this.comboBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBox2.Location = new System.Drawing.Point(16, 143);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(101, 29);
			this.textBox2.TabIndex = 6;
			// 
			// comboBox2
			// 
			this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "CLARO",
            "TIGO",
            "FIJO"});
			this.comboBox2.Location = new System.Drawing.Point(124, 143);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(105, 29);
			this.comboBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.textBox3.Location = new System.Drawing.Point(16, 209);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(214, 76);
			this.textBox3.TabIndex = 8;
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
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(238, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(550, 332);
			this.dataGridView1.TabIndex = 10;
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}

