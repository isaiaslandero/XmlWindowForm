using JsonWindowForm.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlWindowForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void limpiar()
		{
			nombres_text.Text = string.Empty;
			sexo_combo.Text = string.Empty;
			telefono_text.Text = string.Empty;
			compania_combo.Text = string.Empty;
			direccion_text.Text = string.Empty;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Personal per = new Personal();
			per.nombres = nombres_text.Text.ToUpper();
			per.sexo = sexo_combo.Text.ToString();
			per.telefono = telefono_text.Text;
			per.empresa = compania_combo.Text.ToString();
			per.direccion = direccion_text.Text.ToUpper();
			per.CargarDatosAlaTabla(tablaListado);
			limpiar();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			List<Personal> coleccion = new List<Personal>();
			Personal per = new Personal();
			for (int i = 0; i < tablaListado.RowCount; i++)
			{
				per.nombres = tablaListado.Rows[i].Cells[0].Value.ToString();
				per.sexo = tablaListado.Rows[i].Cells[1].Value.ToString();
				per.telefono = tablaListado.Rows[i].Cells[2].Value.ToString();
				per.empresa = tablaListado.Rows[i].Cells[3].Value.ToString();
				per.direccion = tablaListado.Rows[i].Cells[4].Value.ToString();
				coleccion.Add(per);
			}
			per.ConvertirAXml(coleccion);
		}
	}
}
