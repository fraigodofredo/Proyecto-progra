/*
 * Created by SharpDevelop.
 * User: THINKCENTRE
 * Date: 21/06/2023
 * Time: 01:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto
{
	partial class Agregar
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
		private System.Windows.Forms.TextBox txtNumCliente;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.TextBox txtDir;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Button btnAgregar;
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
			//this.txtNumCliente = new System.Windows.Forms.TextBox();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.txtDir = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "NUMERO DEL CLIENTE";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOMBRE";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "DIRECCION";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "TELEFONO";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "EMAIL";
			// 
			// txtNumCliente
			// 
			//this.txtNumCliente.Location = new System.Drawing.Point(140, 18);
			//this.txtNumCliente.Name = "txtNumCliente";
			//this.txtNumCliente.Size = new System.Drawing.Size(100, 20);
			//this.txtNumCliente.TabIndex = 6;
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(140, 53);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(100, 20);
			this.txtNom.TabIndex = 7;
			// 
			// txtDir
			// 
			this.txtDir.Location = new System.Drawing.Point(140, 93);
			this.txtDir.Name = "txtDir";
			this.txtDir.Size = new System.Drawing.Size(100, 20);
			this.txtDir.TabIndex = 8;
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(140, 130);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(100, 20);
			this.txtTel.TabIndex = 9;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(140, 170);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(100, 20);
			this.txtEmail.TabIndex = 10;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(49, 230);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 12;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnRegresar
			// 
			this.btnRegresar.Location = new System.Drawing.Point(165, 230);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(75, 23);
			this.btnRegresar.TabIndex = 13;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = true;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// Agregar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 311);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.txtDir);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.txtNumCliente);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Agregar";
			this.Text = "Agregar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
