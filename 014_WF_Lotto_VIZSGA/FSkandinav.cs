using System;
using System.Windows.Forms;

namespace NSLotto
{
	public partial class FSkandinav : Form
	{
		public FSkandinav()
		{
			InitializeComponent();
		}

		private void FSkandinav_Load(object sender, EventArgs e)
		{
			gombkezeles.GombokBetoltese(35, 7, PTorzs, LBLista);
		}

		private void FSkandinav_FormClosing(object sender, FormClosingEventArgs e)
		{
			GC.Collect();
		}

		private void BFogadas_Click(object sender, EventArgs e)
		{
			fogadas.Fogadas(7, LBLista, PTorzs);
		}

		private void BMegsem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}