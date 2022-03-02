/*
 * Created by SharpDevelop.
 * User: User
 * Date: 02/03/2022
 * Time: 15.13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_Pertemuan_4
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
		
		void Label2Click(object sender, EventArgs e)
		{	
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Hello World"+Environment.NewLine+"Nama	: "+this.textBox1.Text+Environment.NewLine+"Nim	: "+this.textBox2.Text+Environment.NewLine+"Kelas	: "+this.textBox3.Text+Environment.NewLine+
			"Matkul	: "+this.textBox4.Text);
		}
	}
}
