/*
 * Created by SharpDevelop.
 * User: THINKCENTRE
 * Date: 21/06/2023
 * Time: 01:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Buscar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCURP;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.TextBox txtDir;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnRegresar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCURP = new System.Windows.Forms.TextBox();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.txtDir = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "NUMERO DEL CLIENTE";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOMBRE";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "DIRECCION";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "TELEFONO";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "EMAIL";
			// 
			// txtCURP
			// 
			this.txtCURP.Location = new System.Drawing.Point(146, 10);
			this.txtCURP.Name = "txtCURP";
			this.txtCURP.Size = new System.Drawing.Size(100, 20);
			this.txtCURP.TabIndex = 6;
			// 
			// txtNom
			// 
			this.txtNom.Enabled = false;
			this.txtNom.Location = new System.Drawing.Point(146, 42);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(100, 20);
			this.txtNom.TabIndex = 7;
			// 
			// txtDir
			// 
			this.txtDir.Enabled = false;
			this.txtDir.Location = new System.Drawing.Point(146, 78);
			this.txtDir.Name = "txtDir";
			this.txtDir.Size = new System.Drawing.Size(100, 20);
			this.txtDir.TabIndex = 8;
			// 
			// txtTel
			// 
			this.txtTel.Enabled = false;
			this.txtTel.Location = new System.Drawing.Point(146, 110);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(100, 20);
			this.txtTel.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.Enabled = false;
			this.txtEmail.Location = new System.Drawing.Point(146, 148);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(100, 20);
			this.txtEmail.TabIndex = 10;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(38, 206);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 12;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.BtnBuscarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(162, 206);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 13;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Buscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 288);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtDir);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.txtCURP);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Buscar";
			this.Text = "Buscar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
