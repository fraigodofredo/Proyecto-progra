/*
 * Created by SharpDevelop.
 * User: Vaio
 * Date: 24/06/2023
 * Time: 06:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class ListarCliente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtListarTextInicial;
		private System.Windows.Forms.TextBox txtClientes;
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
			this.txtListarTextInicial = new System.Windows.Forms.TextBox();
			this.txtClientes = new System.Windows.Forms.TextBox();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtListarTextInicial
			// 
			this.txtListarTextInicial.Enabled = false;
			this.txtListarTextInicial.Location = new System.Drawing.Point(28, 24);
			this.txtListarTextInicial.Name = "txtListarTextInicial";
			this.txtListarTextInicial.Size = new System.Drawing.Size(184, 20);
			this.txtListarTextInicial.TabIndex = 0;
			this.txtListarTextInicial.Text = "Listado de numeros de clientes: ";
			this.txtListarTextInicial.TextChanged += new System.EventHandler(this.TxtListarTextInicialTextChanged);
			// 
			// txtClientes
			// 
			this.txtClientes.Enabled = false;
			this.txtClientes.Location = new System.Drawing.Point(28, 64);
			this.txtClientes.Name = "txtClientes";
			this.txtClientes.Size = new System.Drawing.Size(184, 20);
			this.txtClientes.TabIndex = 1;
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(44, 116);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 2;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// ListarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.txtClientes);
			this.Controls.Add(this.txtListarTextInicial);
			this.Name = "ListarCliente";
			this.Text = "ListarCliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
