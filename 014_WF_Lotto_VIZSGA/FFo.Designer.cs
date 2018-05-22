namespace NSLotto
{
	partial class FFo
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MSMenu = new System.Windows.Forms.MenuStrip();
			this.TSMIFooldal = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIOtos = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIHatos = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMISkandinav = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMISorsolas = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMINevjegy = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMIKilepes = new System.Windows.Forms.ToolStripMenuItem();
			this.MSMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// MSMenu
			// 
			this.MSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIFooldal,
            this.TSMIOtos,
            this.TSMIHatos,
            this.TSMISkandinav,
            this.TSMISorsolas,
            this.TSMINevjegy,
            this.TSMIKilepes});
			this.MSMenu.Location = new System.Drawing.Point(2, 2);
			this.MSMenu.Name = "MSMenu";
			this.MSMenu.Size = new System.Drawing.Size(680, 27);
			this.MSMenu.TabIndex = 1;
			this.MSMenu.Text = "menuStrip1";
			// 
			// TSMIFooldal
			// 
			this.TSMIFooldal.Name = "TSMIFooldal";
			this.TSMIFooldal.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.TSMIFooldal.Size = new System.Drawing.Size(62, 23);
			this.TSMIFooldal.Text = "Főoldal";
			this.TSMIFooldal.Click += new System.EventHandler(this.TSMIFooldal_Click);
			// 
			// TSMIOtos
			// 
			this.TSMIOtos.Name = "TSMIOtos";
			this.TSMIOtos.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.TSMIOtos.Size = new System.Drawing.Size(76, 23);
			this.TSMIOtos.Text = "Ötös lottó";
			this.TSMIOtos.Click += new System.EventHandler(this.TSMIOtos_Click);
			// 
			// TSMIHatos
			// 
			this.TSMIHatos.Name = "TSMIHatos";
			this.TSMIHatos.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.TSMIHatos.Size = new System.Drawing.Size(82, 23);
			this.TSMIHatos.Text = "Hatos lottó";
			this.TSMIHatos.Click += new System.EventHandler(this.TSMIHatos_Click);
			// 
			// TSMISkandinav
			// 
			this.TSMISkandinav.Name = "TSMISkandinav";
			this.TSMISkandinav.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.TSMISkandinav.Size = new System.Drawing.Size(105, 23);
			this.TSMISkandinav.Text = "Skandináv lottó";
			this.TSMISkandinav.Click += new System.EventHandler(this.TSMISkandinav_Click);
			// 
			// TSMISorsolas
			// 
			this.TSMISorsolas.Name = "TSMISorsolas";
			this.TSMISorsolas.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.TSMISorsolas.Size = new System.Drawing.Size(66, 23);
			this.TSMISorsolas.Text = "Sorsolás";
			this.TSMISorsolas.Click += new System.EventHandler(this.TSMISorsolas_Click);
			// 
			// TSMINevjegy
			// 
			this.TSMINevjegy.Name = "TSMINevjegy";
			this.TSMINevjegy.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.TSMINevjegy.Size = new System.Drawing.Size(66, 23);
			this.TSMINevjegy.Text = "Névjegy";
			this.TSMINevjegy.Click += new System.EventHandler(this.TSMINevjegy_Click);
			// 
			// TSMIKilepes
			// 
			this.TSMIKilepes.Name = "TSMIKilepes";
			this.TSMIKilepes.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
			this.TSMIKilepes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.TSMIKilepes.Size = new System.Drawing.Size(60, 23);
			this.TSMIKilepes.Text = "Kilépés";
			this.TSMIKilepes.Click += new System.EventHandler(this.TSMIKilepes_Click);
			// 
			// FFo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.MSMenu);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.MSMenu;
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "FFo";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lottó";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FFo_FormClosing);
			this.Load += new System.EventHandler(this.TSMIFooldal_Click);
			this.MSMenu.ResumeLayout(false);
			this.MSMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip MSMenu;
		private System.Windows.Forms.ToolStripMenuItem TSMIFooldal;
		private System.Windows.Forms.ToolStripMenuItem TSMIOtos;
		private System.Windows.Forms.ToolStripMenuItem TSMIHatos;
		private System.Windows.Forms.ToolStripMenuItem TSMISkandinav;
		private System.Windows.Forms.ToolStripMenuItem TSMISorsolas;
		private System.Windows.Forms.ToolStripMenuItem TSMINevjegy;
		private System.Windows.Forms.ToolStripMenuItem TSMIKilepes;
	}
}

