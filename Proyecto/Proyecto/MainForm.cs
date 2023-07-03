/*
 * Created by SharpDevelop.
 * User: THINKCENTRE
 * Date: 21/06/2023
 * Time: 01:05 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static int i = 0;
		public static Connection conexion;
		public struct Datos
		{
			public string CURP;
			public string Nom;
			public string Dir;
			public string Tel;
			public string Email;
			public string Carrera;
		}
		public static Datos [] Agenda = new Datos[120];
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			conexion=new Connection();
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AgregarToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Agregar obj = new Agregar();
			obj.Show();
			this.Hide();
		}
		void ListarToolStripMenuItemClick(object sender, EventArgs e)
		{
			ListarCliente obj = new ListarCliente();
			obj.Show();
			this.Hide();
		}
		void BuscarToolStripMenuItemClick(object sender, EventArgs e)
		{
			Buscar obj = new Buscar();
			obj.Show();
			this.Hide();
		}
		void RopaToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Ropa obj = new Ropa();
			obj.Show();
			this.Hide();
		}
		void ModificarToolStripMenuItemClick(object sender, EventArgs e)
		{
			Modificar obj = new Modificar();
			obj.Show();
			this.Hide();
		}
		void BorrarToolStripMenuItemClick(object sender, EventArgs e)
		{
			Borrar obj = new Borrar();
			obj.Show();
			this.Hide();
		}
		void ListarClienteToolStripMenuItemClick(object sender, EventArgs e)
		{
			ListarCliente obj = new ListarCliente();
			obj.Show();
			this.Hide();
		}
		
	}
}
