/*
 * Created by SharpDevelop.
 * User: CC2_PC14
 * Date: 23/10/2026
 * Time: 03:34 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace multiplica
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
			double n1,n2,r;
			n1=Convert.ToDouble(textBox1.Text);
			n2=Convert.ToDouble(textBox2.Text);
			r=n1*n2;
			MessageBox.Show("Multiplicacion "+r.ToString());
		}
	}
}
