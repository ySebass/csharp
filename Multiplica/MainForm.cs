/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 23/10/2026
 * Time: 07:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Multiplica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double num1, num2, multiplicacion;
			num1=Convert.ToDouble(txtnum1.Text);
			num2=Convert.ToDouble(txtnum2.Text);
			multiplicacion = num1*num2;
			MessageBox.Show("Multiplicacion: "+ multiplicacion);
		}
		
		void Label2Click(object sender, EventArgs e)
		{			
		}
	}
}
