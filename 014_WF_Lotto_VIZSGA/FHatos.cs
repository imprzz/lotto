using System;
using System.Windows.Forms;

namespace NSLotto
{
	public partial class FHatos : Form
	{
		public FHatos()
		{
			InitializeComponent();
		}

		private void FHatos_Load(object sender, EventArgs e)
		{
			gombkezeles.GombokBetoltese(45, 5, PTorzs, LBLista);
		}

		private void FHatos_FormClosing(object sender, FormClosingEventArgs e)
		{
			GC.Collect();
		}

		private void BFogadas_Click(object sender, EventArgs e)
		{
			fogadas.Fogadas(6, LBLista, PTorzs);
		}

		private void BMegsem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}