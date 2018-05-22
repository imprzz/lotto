namespace NSLotto
{
	partial class FOtos
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
			this.PJobb = new System.Windows.Forms.Panel();
			this.LBLista = new System.Windows.Forms.ListBox();
			this.PBLogo = new System.Windows.Forms.PictureBox();
			this.BFogadas = new System.Windows.Forms.Button();
			this.BMegsem = new System.Windows.Forms.Button();
			this.PJobb.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// PTorzs
			// 
			this.PTorzs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PTorzs.Location = new System.Drawing.Point(0, 0);
			this.PTorzs.Name = "PTorzs";
			this.PTorzs.Size = new System.Drawing.Size(119, 300);
			this.PTorzs.TabIndex = 0;
			// 
			// PJobb
			// 
			this.PJobb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PJobb.Controls.Add(this.LBLista);
			this.PJobb.Controls.Add(this.PBLogo);
			this.PJobb.Controls.Add(this.BFogadas);
			this.PJobb.Controls.Add(this.BMegsem);
			this.PJobb.Dock = System.Windows.Forms.DockStyle.Right;
			this.PJobb.Location = new System.Drawing.Point(119, 0);
			this.PJobb.Name = "PJobb";
			this.PJobb.Padding = new System.Windows.Forms.Padding(2);
			this.PJobb.Size = new System.Drawing.Size(156, 300);
			this.PJobb.TabIndex = 1;
			// 
			// LBLista
			// 
			this.LBLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LBLista.FormattingEnabled = true;
			this.LBLista.Location = new System.Drawing.Point(2, 152);
			this.LBLista.Name = "LBLista";
			this.LBLista.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.LBLista.Size = new System.Drawing.Size(150, 64);
			this.LBLista.Sorted = true;
			this.LBLista.TabIndex = 3;
			// 
			// PBLogo
			// 
			this.PBLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.PBLogo.Image = global::NSLotto.Properties.Resources.otos;
			this.PBLogo.Location = new System.Drawing.Point(2, 2);
			this.PBLogo.Name = "PBLogo";
			this.PBLogo.Size = new System.Drawing.Size(150, 150);
			this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PBLogo.TabIndex = 2;
			this.PBLogo.TabStop = false;
			// 
			// BFogadas
			// 
			this.BFogadas.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BFogadas.Location = new System.Drawing.Point(2, 216);
			this.BFogadas.Name = "BFogadas";
			this.BFogadas.Size = new System.Drawing.Size(150, 40);
			this.BFogadas.TabIndex = 0;
			this.BFogadas.Text = "Fogadás";
			this.BFogadas.UseVisualStyleBackColor = true;
			this.BFogadas.Click += new System.EventHandler(this.BFogadas_Click);
			// 
			// BMegsem
			// 
			this.BMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BMegsem.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BMegsem.Location = new System.Drawing.Point(2, 256);
			this.BMegsem.Name = "BMegsem";
			this.BMegsem.Size = new System.Drawing.Size(150, 40);
			this.BMegsem.TabIndex = 1;
			this.BMegsem.Text = "Mégsem";
			this.BMegsem.UseVisualStyleBackColor = true;
			this.BMegsem.Click += new System.EventHandler(this.BMegsem_Click);
			// 
			// FOtos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BMegsem;
			this.ClientSize = new System.Drawing.Size(275, 300);
			this.ControlBox = false;
			this.Controls.Add(this.PTorzs);
			this.Controls.Add(this.PJobb);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FOtos";
			this.ShowIcon = false;
			this.Text = "Ötös lottó";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FOtos_FormClosing);
			this.Load += new System.EventHandler(this.FOtos_Load);
			this.PJobb.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PTorzs;
		private System.Windows.Forms.Panel PJobb;
		private System.Windows.Forms.ListBox LBLista;
		private System.Windows.Forms.PictureBox PBLogo;
		private System.Windows.Forms.Button BFogadas;
		private System.Windows.Forms.Button BMegsem;
	}
}