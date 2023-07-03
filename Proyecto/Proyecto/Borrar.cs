/*
 * Created by SharpDevelop.
 * User: Vaio
 * Date: 24/06/2023
 * Time: 04:02 p. m.
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
	/// Description of Borrar.
	/// </summary>
	public partial class Borrar : Form
	{
		public Borrar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}
		void TxtNumClienteTextChanged(object sender, EventArgs e)
		{
			
		}
		void BtnEjectClick(object sender, EventArgs e)
		{
			string Cb;
			int ban = 0, j;
			Cb=txtNumCliente.Text;
			for (j=0; j<=MainForm.i; j++)
			{
				if (Cb.Equals(MainForm.Agenda[j].CURP))
				{
					MainForm.Agenda[j].CURP="";
					MainForm.Agenda[j].Nom=""; 
					MainForm.Agenda[j].Dir="";
					MainForm.Agenda[j].Tel="";
					MainForm.Agenda[j].Email="";
					ban = 1;
					break;
				}
			}
			if (ban==0){
				MessageBox.Show("El registro no existe");
			}
			else{
				MessageBox.Show("El registro se ha borrado");
			}
			
			
		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MainForm obj = new MainForm ();
			obj.Show();
			this.Hide();
		}
	}
}
