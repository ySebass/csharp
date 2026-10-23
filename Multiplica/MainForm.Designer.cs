/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 23/10/2026
 * Time: 07:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Multiplica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtnum1 = new System.Windows.Forms.TextBox();
			this.txtnum2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(63, 120);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(147, 48);
			this.btnMultiplicar.TabIndex = 0;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Numero 2:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(49, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numero 1:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// txtnum1
			// 
			this.txtnum1.Location = new System.Drawing.Point(119, 19);
			this.txtnum1.Multiline = true;
			this.txtnum1.Name = "txtnum1";
			this.txtnum1.Size = new System.Drawing.Size(122, 26);
			this.txtnum1.TabIndex = 3;
			// 
			// txtnum2
			// 
			this.txtnum2.Location = new System.Drawing.Point(119, 62);
			this.txtnum2.Multiline = true;
			this.txtnum2.Name = "txtnum2";
			this.txtnum2.Size = new System.Drawing.Size(122, 26);
			this.txtnum2.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 180);
			this.Controls.Add(this.txtnum2);
			this.Controls.Add(this.txtnum1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnMultiplicar);
			this.Name = "MainForm";
			this.Text = "Multiplica";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtnum2;
		private System.Windows.Forms.TextBox txtnum1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMultiplicar;
	}
}
