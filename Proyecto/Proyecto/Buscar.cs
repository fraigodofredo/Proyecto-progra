/*
 * Created by SharpDevelop.
 * User: THINKCENTRE
 * Date: 21/06/2023
 * Time: 01:59 a. m.
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
	/// Description of Buscar.
	/// </summary>
	public partial class Buscar : Form
	{
		public Buscar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{
			string Cb;
			int ban = 0, j;
			Cb=txtCURP.Text;
			for (j=0; j<=MainForm.i; j++)
			{
				if (Cb.Equals(MainForm.Agenda[j].CURP))
				{
					txtCURP.Text=MainForm.Agenda[j].CURP;
					txtNom.Text=MainForm.Agenda[j].Nom;
					txtDir.Text=MainForm.Agenda[j].Dir;
					txtTel.Text=MainForm.Agenda[j].Tel;
					txtEmail.Text=MainForm.Agenda[j].Email;
					ban = 1;
					break;
				}
			}
			if (ban==0)
				MessageBox.Show("El registro no existe");
		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MainForm obj = new MainForm ();
			obj.Show();
			this.Hide();
		}
	}
}
