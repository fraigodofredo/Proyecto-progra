/*
 * Created by SharpDevelop.
 * User: Lab B
 * Date: 23/06/2023
 * Time: 09:15 p. m.
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
	/// Description of Ropa.
	/// </summary>
	public partial class Ropa : Form
	{
		public Ropa()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PictureBox2Click(object sender, EventArgs e)
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
