/*
 * Created by SharpDevelop.
 * User: Perla
 * Date: 23/06/2023
 * Time: 04:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto
{
	/// <summary>
	/// Description of Acerca.
	/// </summary>
	public partial class Acerca : Form
	{
		public Acerca()
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
			MainForm obj = new MainForm();
			obj.Show();
			this.Hide();
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{
	
		}
	}
}
