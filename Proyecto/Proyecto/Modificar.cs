/*
 * Created by SharpDevelop.
 * User: Lab B
 * Date: 23/06/2023
 * Time: 09:05 p. m.
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
	/// Description of Modificar.
	/// </summary>
	public partial class Modificar : Form
	{

		public Modificar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MainForm obj = new MainForm ();
			obj.Show();
			this.Hide();
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			string Cb;
			int ban = 0, j;
			Cb=txtNumCliente.Text;
			for (j=0; j<=MainForm.i; j++)
			{
				if (Cb.Equals(MainForm.Agenda[j].CURP))
				{

					ban = 1;
					break;
				}
			}
			if (ban==0)
				MessageBox.Show("El registro no existe, primero debe crearse");
			else{
				MainForm.Agenda[int.Parse(txtNumCliente.Text)].Nom=txtNom.Text;
				MainForm.Agenda[int.Parse(txtNumCliente.Text)].Tel=txtTel.Text;
				MainForm.Agenda[int.Parse(txtNumCliente.Text)].Dir=txtDir.Text;
				MainForm.Agenda[int.Parse(txtNumCliente.Text)].Email=txtEmail.Text;
				MessageBox.Show("El registro ha sido modificado exitosamente");
				BtnRegresarClick(sender,e);
			}
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{
			string Cb;
			int ban = 0, j;
			Cb=txtNumCliente.Text;
			for (j=0; j<=MainForm.i; j++)
			{
				if (Cb.Equals(MainForm.Agenda[j].CURP))
				{
					txtNumCliente.Text=MainForm.Agenda[j].CURP;
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
	}
}
