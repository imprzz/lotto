using System;
using System.Windows.Forms;

namespace NSLotto
{
	public partial class FOtos : Form
	{
		public FOtos()
		{
			InitializeComponent();
		}

		private void FOtos_Load(object sender, EventArgs e)
		{
			gombkezeles.GombokBetoltese(90, 10, PTorzs, LBLista);
		}

		private void FOtos_FormClosing(object sender, FormClosingEventArgs e)
		{
			GC.Collect();
		}

		private void BFogadas_Click(object sender, EventArgs e)
		{
			fogadas.Fogadas(5, LBLista, PTorzs);
		}

		private void BMegsem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}