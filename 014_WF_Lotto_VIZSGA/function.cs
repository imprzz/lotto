using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NSLotto
{
	class gombkezeles
	{
		public static void GombokBetoltese(int gombokSzama, int sorokSzama, Panel hely, ListBox lista)
		{
			int
				j = 0,
				k = 0;

			for(int i = 0; i < gombokSzama; i++)
			{
				Button b = new Button();
				j = i / sorokSzama;

				if(i % sorokSzama == 0)
				{
					k = 0;
				}

				b.Location = new Point(5 + k * 40, 5 + j * 40);
				b.Size = new Size(35, 35);
				k++;
				b.Text = Convert.ToString(i + 1);
				b.Tag = Convert.ToString(i + 1);
				hely.Controls.Add(b);
				b.Click += (sender, e) => B_Click(sender, e, lista, gombokSzama);
			}
		}

		private static void B_Click(object sender, EventArgs e, ListBox lista, int gombokSzama)
		{
			Button b = (Button)sender;
			int lottoTipus = 0;

			switch(gombokSzama)
			{
				case 90:
					lottoTipus = 5;
					break;

				case 45:
					lottoTipus = 6;
					break;

				case 35:
					lottoTipus = 7;
					break;
				
				default:
					break;
			}

			if(b.Text == "X")
			{
				b.Text = Convert.ToString(b.Tag);
				b.ForeColor = Color.Black;

				for(int i = 0; i < lista.Items.Count; i++)
				{
					if((Convert.ToString(lista.Items[i]) == Convert.ToString(b.Tag)) || (Convert.ToString(lista.Items[i]) == "0" + Convert.ToString(b.Tag)))
					{
						lista.Items.RemoveAt(i);
					}
				}
			}
			else
			{
				if(lista.Items.Count < lottoTipus)
				{
					b.Text = "X";
					b.ForeColor = Color.Red;
					string temp = Convert.ToString(b.Tag);
					if(temp.Length != 2)
					{
						temp = "0" + temp;
					}
					lista.Items.Add(temp);
				}
				else
				{
					MessageBox.Show("A kiválasztott számok száma elérte a maximumot.", "Nem lehetséges művelet!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}

	class fogadas
	{
		public static void Fogadas(int tipus, ListBox lista, Panel hely)
		{
			bool ok = false;

			switch(tipus)
			{
				case 5:
					if(adat.otosLotto.Count != 6)
					{
						ok = true;
					}
					break;

				case 6:
					if(adat.hatosLotto.Count != 6)
					{
						ok = true;
					}
					break;

				case 7:
					if(adat.skandinavLotto.Count != 6)
					{
						ok = true;
					}
					break;
				
				default:
					break;
			}

			if((ok) && (lista.Items.Count == tipus))
			{
				string temp = "";

				foreach(string s in lista.Items)
				{
					temp += s + ", ";
				}
				temp = temp.Remove(temp.Length - 2);

				switch(tipus)
				{
					case 5:
						adat.otosLotto.Add(temp);
						temp = Convert.ToString(6 - adat.otosLotto.Count);
						break;

					case 6:
						adat.hatosLotto.Add(temp);
						temp = Convert.ToString(6 - adat.hatosLotto.Count);
						break;

					case 7:
						adat.skandinavLotto.Add(temp);
						temp = Convert.ToString(6 - adat.skandinavLotto.Count);
						break;

					default:
						break;
				}

				foreach(Button b in hely.Controls)
				{
					b.Text = Convert.ToString(b.Tag);
					b.ForeColor = Color.Black;
				}

				lista.Items.Clear();

				MessageBox.Show("Még " + temp + " alkalommal fogadhatsz ezen a lottó típuson.", "Sikeres fogadás", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("A megtett fogadások száma maximális, vagy nincs elegendő szám kiválasztva.", "Nem lehetséges művelet!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}

	class adat
	{
		public static List<string> otosLotto = new List<string>();
		public static List<string> hatosLotto = new List<string>();
		public static List<string> skandinavLotto = new List<string>();
	}
}