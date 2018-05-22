namespace NSLotto
{
	partial class FSorsolas
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
			this.PTorzs = new System.Windows.Forms.Panel();
			this.PTorzsKozep = new System.Windows.Forms.Panel();
			this.LBHatos = new System.Windows.Forms.ListBox();
			this.PBHatos = new System.Windows.Forms.PictureBox();
			this.PTorzsJobb = new System.Windows.Forms.Panel();
			this.LBSkandinav = new System.Windows.Forms.ListBox();
			this.PBSkandinav = new System.Windows.Forms.PictureBox();
			this.PTorzsBal = new System.Windows.Forms.Panel();
			this.LBOtos = new System.Windows.Forms.ListBox();
			this.PBOtos = new System.Windows.Forms.PictureBox();
			this.PMenu = new System.Windows.Forms.Panel();
			this.BMegsem = new System.Windows.Forms.Button();
			this.BTorles = new System.Windows.Forms.Button();
			this.BSorsolas = new System.Windows.Forms.Button();
			this.LOtosNyero = new System.Windows.Forms.Label();
			this.LHatosNyero = new System.Windows.Forms.Label();
			this.LSkandinavNyero = new System.Windows.Forms.Label();
			this.LBOtosTalalat = new System.Windows.Forms.ListBox();
			this.LBHatosTalalat = new System.Windows.Forms.ListBox();
			this.LBSkandinavTalalat = new System.Windows.Forms.ListBox();
			this.POtosCimke = new System.Windows.Forms.Panel();
			this.LOtosTalalat = new System.Windows.Forms.Label();
			this.LOtosFogadasok = new System.Windows.Forms.Label();
			this.PHatosCimke = new System.Windows.Forms.Panel();
			this.LHatosFogadasok = new System.Windows.Forms.Label();
			this.LHatosTalalat = new System.Windows.Forms.Label();
			this.PSkandinavCimke = new System.Windows.Forms.Panel();
			this.LSkandinavFogadasok = new System.Windows.Forms.Label();
			this.LSkandinavTalalat = new System.Windows.Forms.Label();
			this.PTorzs.SuspendLayout();
			this.PTorzsKozep.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBHatos)).BeginInit();
			this.PTorzsJobb.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBSkandinav)).BeginInit();
			this.PTorzsBal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBOtos)).BeginInit();
			this.PMenu.SuspendLayout();
			this.POtosCimke.SuspendLayout();
			this.PHatosCimke.SuspendLayout();
			this.PSkandinavCimke.SuspendLayout();
			this.SuspendLayout();
			// 
			// PTorzs
			// 
			this.PTorzs.Controls.Add(this.PTorzsKozep);
			this.PTorzs.Controls.Add(this.PTorzsJobb);
			this.PTorzs.Controls.Add(this.PTorzsBal);
			this.PTorzs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PTorzs.Location = new System.Drawing.Point(0, 0);
			this.PTorzs.Name = "PTorzs";
			this.PTorzs.Size = new System.Drawing.Size(674, 398);
			this.PTorzs.TabIndex = 0;
			// 
			// PTorzsKozep
			// 
			this.PTorzsKozep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PTorzsKozep.Controls.Add(this.LBHatos);
			this.PTorzsKozep.Controls.Add(this.LBHatosTalalat);
			this.PTorzsKozep.Controls.Add(this.PHatosCimke);
			this.PTorzsKozep.Controls.Add(this.LHatosNyero);
			this.PTorzsKozep.Controls.Add(this.PBHatos);
			this.PTorzsKozep.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PTorzsKozep.Location = new System.Drawing.Point(245, 0);
			this.PTorzsKozep.Name = "PTorzsKozep";
			this.PTorzsKozep.Padding = new System.Windows.Forms.Padding(2);
			this.PTorzsKozep.Size = new System.Drawing.Size(229, 398);
			this.PTorzsKozep.TabIndex = 1;
			// 
			// LBHatos
			// 
			this.LBHatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LBHatos.FormattingEnabled = true;
			this.LBHatos.Location = new System.Drawing.Point(2, 167);
			this.LBHatos.Name = "LBHatos";
			this.LBHatos.Size = new System.Drawing.Size(173, 207);
			this.LBHatos.TabIndex = 3;
			this.LBHatos.SelectedIndexChanged += new System.EventHandler(this.LBHatos_SelectedIndexChanged);
			// 
			// PBHatos
			// 
			this.PBHatos.Dock = System.Windows.Forms.DockStyle.Top;
			this.PBHatos.Image = global::NSLotto.Properties.Resources.hatos;
			this.PBHatos.Location = new System.Drawing.Point(2, 2);
			this.PBHatos.Name = "PBHatos";
			this.PBHatos.Size = new System.Drawing.Size(223, 150);
			this.PBHatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PBHatos.TabIndex = 1;
			this.PBHatos.TabStop = false;
			// 
			// PTorzsJobb
			// 
			this.PTorzsJobb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PTorzsJobb.Controls.Add(this.LBSkandinav);
			this.PTorzsJobb.Controls.Add(this.LBSkandinavTalalat);
			this.PTorzsJobb.Controls.Add(this.PSkandinavCimke);
			this.PTorzsJobb.Controls.Add(this.LSkandinavNyero);
			this.PTorzsJobb.Controls.Add(this.PBSkandinav);
			this.PTorzsJobb.Dock = System.Windows.Forms.DockStyle.Right;
			this.PTorzsJobb.Location = new System.Drawing.Point(474, 0);
			this.PTorzsJobb.Name = "PTorzsJobb";
			this.PTorzsJobb.Padding = new System.Windows.Forms.Padding(2);
			this.PTorzsJobb.Size = new System.Drawing.Size(200, 398);
			this.PTorzsJobb.TabIndex = 2;
			// 
			// LBSkandinav
			// 
			this.LBSkandinav.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LBSkandinav.FormattingEnabled = true;
			this.LBSkandinav.Location = new System.Drawing.Point(2, 167);
			this.LBSkandinav.Name = "LBSkandinav";
			this.LBSkandinav.Size = new System.Drawing.Size(144, 207);
			this.LBSkandinav.TabIndex = 3;
			this.LBSkandinav.SelectedIndexChanged += new System.EventHandler(this.LBSkandinav_SelectedIndexChanged);
			// 
			// PBSkandinav
			// 
			this.PBSkandinav.Dock = System.Windows.Forms.DockStyle.Top;
			this.PBSkandinav.Image = global::NSLotto.Properties.Resources.skandinav;
			this.PBSkandinav.Location = new System.Drawing.Point(2, 2);
			this.PBSkandinav.Name = "PBSkandinav";
			this.PBSkandinav.Size = new System.Drawing.Size(194, 150);
			this.PBSkandinav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PBSkandinav.TabIndex = 1;
			this.PBSkandinav.TabStop = false;
			// 
			// PTorzsBal
			// 
			this.PTorzsBal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PTorzsBal.Controls.Add(this.LBOtos);
			this.PTorzsBal.Controls.Add(this.LBOtosTalalat);
			this.PTorzsBal.Controls.Add(this.POtosCimke);
			this.PTorzsBal.Controls.Add(this.LOtosNyero);
			this.PTorzsBal.Controls.Add(this.PBOtos);
			this.PTorzsBal.Dock = System.Windows.Forms.DockStyle.Left;
			this.PTorzsBal.Location = new System.Drawing.Point(0, 0);
			this.PTorzsBal.Name = "PTorzsBal";
			this.PTorzsBal.Padding = new System.Windows.Forms.Padding(2);
			this.PTorzsBal.Size = new System.Drawing.Size(245, 398);
			this.PTorzsBal.TabIndex = 0;
			// 
			// LBOtos
			// 
			this.LBOtos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LBOtos.FormattingEnabled = true;
			this.LBOtos.Location = new System.Drawing.Point(2, 167);
			this.LBOtos.Name = "LBOtos";
			this.LBOtos.Size = new System.Drawing.Size(185, 207);
			this.LBOtos.TabIndex = 2;
			this.LBOtos.SelectedIndexChanged += new System.EventHandler(this.LBOtos_SelectedIndexChanged);
			// 
			// PBOtos
			// 
			this.PBOtos.Dock = System.Windows.Forms.DockStyle.Top;
			this.PBOtos.Image = global::NSLotto.Properties.Resources.otos;
			this.PBOtos.Location = new System.Drawing.Point(2, 2);
			this.PBOtos.Name = "PBOtos";
			this.PBOtos.Size = new System.Drawing.Size(239, 150);
			this.PBOtos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PBOtos.TabIndex = 0;
			this.PBOtos.TabStop = false;
			// 
			// PMenu
			// 
			this.PMenu.Controls.Add(this.BMegsem);
			this.PMenu.Controls.Add(this.BTorles);
			this.PMenu.Controls.Add(this.BSorsolas);
			this.PMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PMenu.Location = new System.Drawing.Point(0, 398);
			this.PMenu.Name = "PMenu";
			this.PMenu.Size = new System.Drawing.Size(674, 52);
			this.PMenu.TabIndex = 1;
			// 
			// BMegsem
			// 
			this.BMegsem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.BMegsem.Location = new System.Drawing.Point(393, 6);
			this.BMegsem.Name = "BMegsem";
			this.BMegsem.Size = new System.Drawing.Size(100, 40);
			this.BMegsem.TabIndex = 2;
			this.BMegsem.Text = "Mégsem";
			this.BMegsem.UseVisualStyleBackColor = true;
			this.BMegsem.Click += new System.EventHandler(this.BMegsem_Click);
			// 
			// BTorles
			// 
			this.BTorles.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.BTorles.Location = new System.Drawing.Point(287, 6);
			this.BTorles.Name = "BTorles";
			this.BTorles.Size = new System.Drawing.Size(100, 40);
			this.BTorles.TabIndex = 1;
			this.BTorles.Text = "Fogadások törlése";
			this.BTorles.UseVisualStyleBackColor = true;
			this.BTorles.Click += new System.EventHandler(this.BTorles_Click);
			// 
			// BSorsolas
			// 
			this.BSorsolas.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.BSorsolas.Location = new System.Drawing.Point(181, 6);
			this.BSorsolas.Name = "BSorsolas";
			this.BSorsolas.Size = new System.Drawing.Size(100, 40);
			this.BSorsolas.TabIndex = 0;
			this.BSorsolas.Text = "Sorsolás";
			this.BSorsolas.UseVisualStyleBackColor = true;
			this.BSorsolas.Click += new System.EventHandler(this.BSorsolas_Click);
			// 
			// LOtosNyero
			// 
			this.LOtosNyero.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LOtosNyero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LOtosNyero.Location = new System.Drawing.Point(2, 374);
			this.LOtosNyero.Name = "LOtosNyero";
			this.LOtosNyero.Size = new System.Drawing.Size(239, 20);
			this.LOtosNyero.TabIndex = 3;
			this.LOtosNyero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LHatosNyero
			// 
			this.LHatosNyero.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LHatosNyero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LHatosNyero.Location = new System.Drawing.Point(2, 374);
			this.LHatosNyero.Name = "LHatosNyero";
			this.LHatosNyero.Size = new System.Drawing.Size(223, 20);
			this.LHatosNyero.TabIndex = 4;
			this.LHatosNyero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LSkandinavNyero
			// 
			this.LSkandinavNyero.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LSkandinavNyero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LSkandinavNyero.Location = new System.Drawing.Point(2, 374);
			this.LSkandinavNyero.Name = "LSkandinavNyero";
			this.LSkandinavNyero.Size = new System.Drawing.Size(194, 20);
			this.LSkandinavNyero.TabIndex = 4;
			this.LSkandinavNyero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LBOtosTalalat
			// 
			this.LBOtosTalalat.Dock = System.Windows.Forms.DockStyle.Right;
			this.LBOtosTalalat.FormattingEnabled = true;
			this.LBOtosTalalat.Location = new System.Drawing.Point(187, 167);
			this.LBOtosTalalat.Name = "LBOtosTalalat";
			this.LBOtosTalalat.Size = new System.Drawing.Size(54, 207);
			this.LBOtosTalalat.TabIndex = 4;
			this.LBOtosTalalat.SelectedIndexChanged += new System.EventHandler(this.LBOtosTalalat_SelectedIndexChanged);
			// 
			// LBHatosTalalat
			// 
			this.LBHatosTalalat.Dock = System.Windows.Forms.DockStyle.Right;
			this.LBHatosTalalat.FormattingEnabled = true;
			this.LBHatosTalalat.Location = new System.Drawing.Point(175, 167);
			this.LBHatosTalalat.Name = "LBHatosTalalat";
			this.LBHatosTalalat.Size = new System.Drawing.Size(50, 207);
			this.LBHatosTalalat.TabIndex = 5;
			this.LBHatosTalalat.SelectedIndexChanged += new System.EventHandler(this.LBHatosTalalat_SelectedIndexChanged);
			// 
			// LBSkandinavTalalat
			// 
			this.LBSkandinavTalalat.Dock = System.Windows.Forms.DockStyle.Right;
			this.LBSkandinavTalalat.FormattingEnabled = true;
			this.LBSkandinavTalalat.Location = new System.Drawing.Point(146, 167);
			this.LBSkandinavTalalat.Name = "LBSkandinavTalalat";
			this.LBSkandinavTalalat.Size = new System.Drawing.Size(50, 207);
			this.LBSkandinavTalalat.TabIndex = 5;
			this.LBSkandinavTalalat.SelectedIndexChanged += new System.EventHandler(this.LBSkandinavTalalat_SelectedIndexChanged);
			// 
			// POtosCimke
			// 
			this.POtosCimke.Controls.Add(this.LOtosFogadasok);
			this.POtosCimke.Controls.Add(this.LOtosTalalat);
			this.POtosCimke.Dock = System.Windows.Forms.DockStyle.Top;
			this.POtosCimke.Location = new System.Drawing.Point(2, 152);
			this.POtosCimke.Name = "POtosCimke";
			this.POtosCimke.Size = new System.Drawing.Size(239, 15);
			this.POtosCimke.TabIndex = 5;
			// 
			// LOtosTalalat
			// 
			this.LOtosTalalat.Dock = System.Windows.Forms.DockStyle.Right;
			this.LOtosTalalat.Location = new System.Drawing.Point(189, 0);
			this.LOtosTalalat.Name = "LOtosTalalat";
			this.LOtosTalalat.Size = new System.Drawing.Size(50, 15);
			this.LOtosTalalat.TabIndex = 4;
			this.LOtosTalalat.Text = "Találat";
			this.LOtosTalalat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LOtosFogadasok
			// 
			this.LOtosFogadasok.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LOtosFogadasok.Location = new System.Drawing.Point(0, 0);
			this.LOtosFogadasok.Name = "LOtosFogadasok";
			this.LOtosFogadasok.Size = new System.Drawing.Size(189, 15);
			this.LOtosFogadasok.TabIndex = 5;
			this.LOtosFogadasok.Text = "Fogadások";
			this.LOtosFogadasok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// PHatosCimke
			// 
			this.PHatosCimke.Controls.Add(this.LHatosFogadasok);
			this.PHatosCimke.Controls.Add(this.LHatosTalalat);
			this.PHatosCimke.Dock = System.Windows.Forms.DockStyle.Top;
			this.PHatosCimke.Location = new System.Drawing.Point(2, 152);
			this.PHatosCimke.Name = "PHatosCimke";
			this.PHatosCimke.Size = new System.Drawing.Size(223, 15);
			this.PHatosCimke.TabIndex = 6;
			// 
			// LHatosFogadasok
			// 
			this.LHatosFogadasok.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LHatosFogadasok.Location = new System.Drawing.Point(0, 0);
			this.LHatosFogadasok.Name = "LHatosFogadasok";
			this.LHatosFogadasok.Size = new System.Drawing.Size(173, 15);
			this.LHatosFogadasok.TabIndex = 5;
			this.LHatosFogadasok.Text = "Fogadások";
			this.LHatosFogadasok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LHatosTalalat
			// 
			this.LHatosTalalat.Dock = System.Windows.Forms.DockStyle.Right;
			this.LHatosTalalat.Location = new System.Drawing.Point(173, 0);
			this.LHatosTalalat.Name = "LHatosTalalat";
			this.LHatosTalalat.Size = new System.Drawing.Size(50, 15);
			this.LHatosTalalat.TabIndex = 4;
			this.LHatosTalalat.Text = "Találat";
			this.LHatosTalalat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// PSkandinavCimke
			// 
			this.PSkandinavCimke.Controls.Add(this.LSkandinavFogadasok);
			this.PSkandinavCimke.Controls.Add(this.LSkandinavTalalat);
			this.PSkandinavCimke.Dock = System.Windows.Forms.DockStyle.Top;
			this.PSkandinavCimke.Location = new System.Drawing.Point(2, 152);
			this.PSkandinavCimke.Name = "PSkandinavCimke";
			this.PSkandinavCimke.Size = new System.Drawing.Size(194, 15);
			this.PSkandinavCimke.TabIndex = 6;
			// 
			// LSkandinavFogadasok
			// 
			this.LSkandinavFogadasok.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LSkandinavFogadasok.Location = new System.Drawing.Point(0, 0);
			this.LSkandinavFogadasok.Name = "LSkandinavFogadasok";
			this.LSkandinavFogadasok.Size = new System.Drawing.Size(144, 15);
			this.LSkandinavFogadasok.TabIndex = 5;
			this.LSkandinavFogadasok.Text = "Fogadások";
			this.LSkandinavFogadasok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LSkandinavTalalat
			// 
			this.LSkandinavTalalat.Dock = System.Windows.Forms.DockStyle.Right;
			this.LSkandinavTalalat.Location = new System.Drawing.Point(144, 0);
			this.LSkandinavTalalat.Name = "LSkandinavTalalat";
			this.LSkandinavTalalat.Size = new System.Drawing.Size(50, 15);
			this.LSkandinavTalalat.TabIndex = 4;
			this.LSkandinavTalalat.Text = "Találat";
			this.LSkandinavTalalat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// FSorsolas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 450);
			this.ControlBox = false;
			this.Controls.Add(this.PTorzs);
			this.Controls.Add(this.PMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FSorsolas";
			this.ShowIcon = false;
			this.Text = "Sorsolás";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FSorsolas_FormClosing);
			this.Load += new System.EventHandler(this.FSorsolas_Load);
			this.SizeChanged += new System.EventHandler(this.FSorsolas_SizeChanged);
			this.PTorzs.ResumeLayout(false);
			this.PTorzsKozep.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PBHatos)).EndInit();
			this.PTorzsJobb.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PBSkandinav)).EndInit();
			this.PTorzsBal.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PBOtos)).EndInit();
			this.PMenu.ResumeLayout(false);
			this.POtosCimke.ResumeLayout(false);
			this.PHatosCimke.ResumeLayout(false);
			this.PSkandinavCimke.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PTorzs;
		private System.Windows.Forms.Panel PMenu;
		private System.Windows.Forms.Button BMegsem;
		private System.Windows.Forms.Button BTorles;
		private System.Windows.Forms.Button BSorsolas;
		private System.Windows.Forms.Panel PTorzsKozep;
		private System.Windows.Forms.Panel PTorzsJobb;
		private System.Windows.Forms.Panel PTorzsBal;
		private System.Windows.Forms.PictureBox PBHatos;
		private System.Windows.Forms.PictureBox PBSkandinav;
		private System.Windows.Forms.PictureBox PBOtos;
		private System.Windows.Forms.ListBox LBHatos;
		private System.Windows.Forms.ListBox LBSkandinav;
		private System.Windows.Forms.ListBox LBOtos;
		private System.Windows.Forms.Label LHatosNyero;
		private System.Windows.Forms.Label LSkandinavNyero;
		private System.Windows.Forms.Label LOtosNyero;
		private System.Windows.Forms.ListBox LBHatosTalalat;
		private System.Windows.Forms.Panel PHatosCimke;
		private System.Windows.Forms.Label LHatosFogadasok;
		private System.Windows.Forms.Label LHatosTalalat;
		private System.Windows.Forms.ListBox LBSkandinavTalalat;
		private System.Windows.Forms.Panel PSkandinavCimke;
		private System.Windows.Forms.Label LSkandinavFogadasok;
		private System.Windows.Forms.Label LSkandinavTalalat;
		private System.Windows.Forms.ListBox LBOtosTalalat;
		private System.Windows.Forms.Panel POtosCimke;
		private System.Windows.Forms.Label LOtosFogadasok;
		private System.Windows.Forms.Label LOtosTalalat;
	}
}