using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P2_096;

namespace ClientCFC_Form_P4_2017096
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			BasicHttpBinding bind = new BasicHttpBinding();
			ChannelFactory<IMatematika> objChannel = new
			ChannelFactory<IMatematika>(bind, "http://localhost:1907");
			IMatematika obj = objChannel.CreateChannel();
			double hasilTambah = obj.Tambah(1, 2);
			double hasilKurang = obj.Kurang(3, 2);
			double hasilKali = obj.Kali(2, 2);
			double hasilBagi = obj.Bagi(2, 2);
			
			label1.Text = "1 + 2 = " + hasilTambah.ToString();
			label2.Text = "3 - 2 = " + hasilKurang.ToString();
			label3.Text = "2 x 2 = " + hasilKali.ToString();
			label4.Text = "2 / 2 = " + hasilBagi.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		
		}
	}
}
