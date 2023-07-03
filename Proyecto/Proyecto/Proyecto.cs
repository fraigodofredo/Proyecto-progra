/*
 * Created by SharpDevelop.
 * User: THINKCENTRE
 * Date: 21/06/2023
 * Time: 01:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	/// <summary>
	/// Description of Agregar.
	/// </summary>
	public partial class Agregar : Form
	{
		public Agregar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			MainForm.Agenda[MainForm.i].CURP= Convert.ToString(MainForm.i);
			MainForm.Agenda[MainForm.i].Nom=txtNom.Text;
			MainForm.Agenda[MainForm.i].Tel=txtTel.Text;
			MainForm.Agenda[MainForm.i].Dir=txtDir.Text;
			MainForm.Agenda[MainForm.i].Email=txtEmail.Text;
			MessageBox.Show("Tu numero de cliente es: " + MainForm.Agenda[MainForm.i].CURP);
			MainForm.i++;
			BtnRegresarClick(sender,e);
		}
		void BtnRegresarClick(object sender, EventArgs e)
		{
			MainForm obj = new MainForm();
			obj.Show();
			this.Hide();
		}
	}
}
