/*
 * Created by SharpDevelop.
 * User: Vaio
 * Date: 24/06/2023
 * Time: 04:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Borrar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtCURP;
		private System.Windows.Forms.TextBox txtNumCliente;
		private System.Windows.Forms.Button btnEject;
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
			this.txtCURP = new System.Windows.Forms.TextBox();
			this.txtNumCliente = new System.Windows.Forms.TextBox();
			this.btnEject = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCURP
			// 
			this.txtCURP.Location = new System.Drawing.Point(0, 0);
			this.txtCURP.Name = "txtCURP";
			this.txtCURP.Size = new System.Drawing.Size(100, 20);
			this.txtCURP.TabIndex = 0;
			// 
			// txtNumCliente
			// 
			this.txtNumCliente.Location = new System.Drawing.Point(22, 25);
			this.txtNumCliente.Multiline = true;
			this.txtNumCliente.Name = "txtNumCliente";
			this.txtNumCliente.Size = new System.Drawing.Size(241, 21);
			this.txtNumCliente.TabIndex = 0;
			this.txtNumCliente.TextChanged += new System.EventHandler(this.TxtNumClienteTextChanged);
			// 
			// btnEject
			// 
			this.btnEject.Location = new System.Drawing.Point(38, 80);
			this.btnEject.Name = "btnEject";
			this.btnEject.Size = new System.Drawing.Size(75, 23);
			this.btnEject.TabIndex = 1;
			this.btnEject.Text = "Ejecutar";
			this.btnEject.UseVisualStyleBackColor = true;
			this.btnEject.Click += new System.EventHandler(this.BtnEjectClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(147, 80);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 2;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Borrar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnEject);
			this.Controls.Add(this.txtNumCliente);
			this.Name = "Borrar";
			this.Text = "Borrar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
