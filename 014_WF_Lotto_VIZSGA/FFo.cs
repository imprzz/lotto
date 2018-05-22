using System;
using System.Windows.Forms;

namespace NSLotto
{
	public partial class FFo : Form
	{
		public FFo()
		{
			InitializeComponent();
		}

		private void FFo_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(e.CloseReason == CloseReason.UserClosing)
			{
				if(MessageBox.Show("Biztos kilépsz a programból?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Application.Exit();
				}
				else
				{
					e.Cancel = true;
				}
			}
		}

		private void TSMIFooldal_Click(object sender, EventArgs e)
		{
			bool nyitott = false;

			foreach(Form item in Application.OpenForms)
			{
				if(item.Name == "FNyito")
				{
					nyitott = true;
					item.BringToFront();
					item.Activate();
					break;
				}
			}

			if(!nyitott)
			{
				FNyito f = new FNyito();
				f.MdiParent = this;
				f.Dock = DockStyle.Fill;
				f.Show();
			}
		}

		private void TSMIOtos_Click(object sender, EventArgs e)
		{
			bool nyitott = false;

			foreach(Form item in Application.OpenForms)
			{
				if(item.Name == "FOtos")
				{
					nyitott = true;
					item.BringToFront();
					item.Activate();
					break;
				}
			}

			if(!nyitott)
			{
				FOtos f = new FOtos();
				f.MdiParent = this;
				f.Dock = DockStyle.Fill;
				f.Show();
				Width += 1;
				Width -= 1;
			}
		}

		private void TSMIHatos_Click(object sender, EventArgs e)
		{
			bool nyitott = false;

			foreach(Form item in Application.OpenForms)
			{
				if(item.Name == "FHatos")
				{
					nyitott = true;
					item.BringToFront();
					item.Activate();
					break;
				}
			}

			if(!nyitott)
			{
				FHatos f = new FHatos();
				f.MdiParent = this;
				f.Dock = DockStyle.Fill;
				f.Show();
				Width += 1;
				Width -= 1;
			}
		}

		private void TSMISkandinav_Click(object sender, EventArgs e)
		{
			bool nyitott = false;

			foreach(Form item in Application.OpenForms)
			{
				if(item.Name == "FSkandinav")
				{
					nyitott = true;
					item.BringToFront();
					item.Activate();
					break;
				}
			}

			if(!nyitott)
			{
				FSkandinav f = new FSkandinav();
				f.MdiParent = this;
				f.Dock = DockStyle.Fill;
				f.Show();
				Width += 1;
				Width -= 1;
			}
		}

		private void TSMISorsolas_Click(object sender, EventArgs e)
		{
			bool nyitott = false;

			foreach(Form item in Application.OpenForms)
			{
				if(item.Name == "FSorsolas")
				{
					nyitott = true;
					item.BringToFront();
					item.Activate();
					break;
				}
			}

			if(!nyitott)
			{
				FSorsolas f = new FSorsolas();
				f.MdiParent = this;
				f.Dock = DockStyle.Fill;
				f.Show();
				Width += 1;
				Width -= 1;
			}
		}

		private void TSMINevjegy_Click(object sender, EventArgs e)
		{
			FNevjegy f = new FNevjegy();
			f.ShowDialog();
		}

		private void TSMIKilepes_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}