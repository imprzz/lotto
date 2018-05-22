using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NSLotto
{
	public partial class FSorsolas : Form
	{
		public FSorsolas()
		{
			InitializeComponent();
		}

		private void FSorsolas_Load(object sender, EventArgs e)
		{
			void Feltoltes(List<string> fogadottLista, ListBox feltoltendo)
			{
				// ListBox-ok feltöltése a fogadások elemeivel
				foreach(string s in fogadottLista)
				{
					feltoltendo.Items.Add(s);
				}
				// ---
			}

			Feltoltes(adat.otosLotto, LBOtos);
			Feltoltes(adat.hatosLotto, LBHatos);
			Feltoltes(adat.skandinavLotto, LBSkandinav);
		}

		private void FSorsolas_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Bezárásnál szemét összegyűjtése és eldobása
			GC.Collect();
			// ---
		}

		private void FSorsolas_SizeChanged(object sender, EventArgs e)
		{
			// Form méretezésekor a változásokhoz alkalmazkodnak a Panelek, így egyforma szélességgel jelennek meg
			int panelSzelesseg = Width / 3;
			PTorzsJobb.Width = panelSzelesseg;
			PTorzsBal.Width = panelSzelesseg;
			// ---
		}

		private void LBOtos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(LBOtos.Items.Count == LBOtosTalalat.Items.Count)
			{
				LBOtosTalalat.SelectedIndex = LBOtos.SelectedIndex;
			}
		}

		private void LBHatos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(LBHatos.Items.Count == LBHatosTalalat.Items.Count)
			{
				LBHatosTalalat.SelectedIndex = LBHatos.SelectedIndex;
			}
		}

		private void LBSkandinav_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(LBSkandinav.Items.Count == LBSkandinavTalalat.Items.Count)
			{
				LBSkandinavTalalat.SelectedIndex = LBSkandinav.SelectedIndex;
			}
		}

		private void LBOtosTalalat_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(LBOtosTalalat.Items.Count == LBOtos.Items.Count)
			{
				LBOtos.SelectedIndex = LBOtosTalalat.SelectedIndex;
			}
		}

		private void LBHatosTalalat_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(LBHatosTalalat.Items.Count == LBHatos.Items.Count)
			{
				LBHatos.SelectedIndex = LBHatosTalalat.SelectedIndex;
			}
		}

		private void LBSkandinavTalalat_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(LBSkandinavTalalat.Items.Count == LBSkandinav.Items.Count)
			{
				LBSkandinav.SelectedIndex = LBSkandinavTalalat.SelectedIndex;
			}
		}

		private void BSorsolas_Click(object sender, EventArgs e)
		{
			List<int> NyeroSzamok(int tipus, int maxSzam, Label cimke)
			{
				Random rnd = new Random();
				int sors = 0;
				List<int> nyeroLista = new List<int>();

				// Sorsolás
				for(int i = 0; i < tipus; i++)
				{
					sors = rnd.Next(maxSzam - 1) + 1;
					if(!nyeroLista.Contains(sors))
					{
						nyeroLista.Add(sors);
					}
					else
					{
						i--;
					}
				}
				nyeroLista.Sort();
				// ---

				// Kiiratás
				cimke.ResetText();
				foreach(int i in nyeroLista)
				{
					if(Convert.ToString(i).Length != 2)
					{
						cimke.Text += "0" + Convert.ToString(i) + ", ";
					}
					else
					{
						cimke.Text += Convert.ToString(i) + ", ";
					}
				}
				cimke.Text = cimke.Text.Remove(cimke.Text.Length - 2);
				// ---

				return nyeroLista;
			}

			if((LBOtos.Items.Count != 0) || (LBHatos.Items.Count != 0) || (LBSkandinav.Items.Count != 0))
			{
				List<int> otosNyero = NyeroSzamok(5, 90, LOtosNyero);
				List<int> hatosNyero = NyeroSzamok(6, 45, LHatosNyero);
				List<int> skandinavNyero = NyeroSzamok(7, 35, LSkandinavNyero);
				
				TalalatEllenor(otosNyero, hatosNyero, skandinavNyero);
			}
		}

		private void BTorles_Click(object sender, EventArgs e)
		{
			// Fogadások törlése
			adat.otosLotto.Clear();
			adat.hatosLotto.Clear();
			adat.skandinavLotto.Clear();
			// ---

			// ListBox-okba töltött fogadások törlése
			LBOtos.Items.Clear();
			LBHatos.Items.Clear();
			LBSkandinav.Items.Clear();
			// ---

			MessageBox.Show("A fogadások törlése befejeződött.", "Törölve", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BMegsem_Click(object sender, EventArgs e)
		{
			// ChildForm bezárása
			Close();
			// ---
		}

		private void TalalatEllenor(List<int> otosNyero, List<int> hatosNyero, List<int> skandinavNyero)
		{
			void Ellenor(List<string> fogadottLista, List<int> nyeroLista, ListBox talalatok)
			{
				string temp = "";
				int
					j,
					talalat;

				talalatok.Items.Clear();

				// Egyes fogadások vizsgálata
				foreach(string s in fogadottLista)
				{
					talalat = 0;
					j = 0;

					// Aktuális fogadás feldolgozása
					for(int i = 0; i < s.Length; i++)
					{
						j++;
						if((j != 3) && (s[i] != ',') && (s[i] != ' '))
						{
							temp += s[i];
						}
						else
						{
							if(temp != string.Empty)
							{
								if(nyeroLista.Contains(Convert.ToInt16(temp)))
								{
									talalat++;
								}

								if(i == s.Length - 1)
								{
									i++;
								}

								temp = string.Empty;
							}
							j = 0;
						}

						if(i == s.Length - 1)
						{
							i--;
							j = 2;
						}
					}
					talalatok.Items.Add(Convert.ToString(talalat));
					// ---
				}
				// ---
			}

			Ellenor(adat.otosLotto, otosNyero, LBOtosTalalat);
			Ellenor(adat.hatosLotto, hatosNyero, LBHatosTalalat);
			Ellenor(adat.skandinavLotto, skandinavNyero, LBSkandinavTalalat);
		}
	}
}