/*
 * Created by SharpDevelop.
 * User: Vaio
 * Date: 24/06/2023
 * Time: 06:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Proyecto
{
	/// <summary>
	/// Description of ListarCliente.
	/// </summary>
	public partial class ListarCliente : Form
	{
		public ListarCliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			int ban = 0, j;
			string lista_ids = "";
			if(MainForm.i<=0){
				txtClientes.Text ="No hay clientes aun para listar";
			} else{
				for (j=0; j<=MainForm.i; j++)
			{
				if (!"".Equals(MainForm.Agenda[j].CURP))
				{
					lista_ids= lista_ids +MainForm.Agenda[j].CURP + ",";					
					ban += 1;
				}
			}
			if (ban==0){
				lista_ids = "Ya no hay clientes para listar";
			}
			txtClientes.Text = lista_ids.Trim(',');
			}			
		}
		void TxtListarTextInicialTextChanged(object sender, EventArgs e)
		{

		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MainForm obj = new MainForm ();
			obj.Show();
			this.Hide();
		}
	}
}
