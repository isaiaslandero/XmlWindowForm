using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JsonWindowForm.Modelo
{
	public class Personal
	{
		private string nombres_;
		private string sexo_;
		private string telefono_;
		private string empresa_;
		private string direccion_;

		public string nombres {
			get { return nombres_; }
			set { nombres_ = value; }
		}

		public string sexo
		{
			get { return sexo_; }
			set { sexo_ = value; }	
		}

		public string telefono
		{
			get { return telefono_; }
			set { telefono_ = value; }
		}

		public string empresa
		{
			get { return empresa_; }
			set { empresa_ = value; }
		}

		public string direccion
		{
			get { return direccion_; }
			set { direccion_ = value; }
		}
		public Personal() { }

		public void CargarDatosAlaTabla(DataGridView tabla)
		{
			tabla.Rows.Insert(0, nombres_, sexo_, telefono_, empresa_, direccion_);
		}

		public void ConvertirAXml(List<Personal> personal_c) 
		{
			string path_direcctorio = @"C:\Isaias";
			string path_archivo = @"C:\Isaias\isaiasJONSON.json";

			XmlSerializer serializador = new XmlSerializer(typeof(List<Personal>));
			TextWriter escriborio = new StreamWriter("IsaiasXML.xml");
			serializador.Serialize(escriborio, personal_c);

			//if (!Directory.Exists(path_direcctorio))
			//{
			//	DirectoryInfo di = Directory.CreateDirectory(path_direcctorio);		
			//	File.WriteAllText(path_archivo, convertir);
			//	MessageBox.Show("Archivo Creado.... ");
			//}
			//else
			//{
			//	File.WriteAllText(path_archivo, convertir);
			//	MessageBox.Show("Archivo Creado.... ");
			//}			
		}

	}
}
