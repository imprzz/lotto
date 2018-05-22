namespace NSLotto
{
	partial class FNyito
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
			this.PBHatter = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.PBHatter)).BeginInit();
			this.SuspendLayout();
			// 
			// PBHatter
			// 
			this.PBHatter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PBHatter.Image = global::NSLotto.Properties.Resources.szerencsejatek;
			this.PBHatter.Location = new System.Drawing.Point(0, 0);
			this.PBHatter.Name = "PBHatter";
			this.PBHatter.Size = new System.Drawing.Size(800, 450);
			this.PBHatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PBHatter.TabIndex = 0;
			this.PBHatter.TabStop = false;
			// 
			// FNyito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.ControlBox = false;
			this.Controls.Add(this.PBHatter);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FNyito";
			this.ShowIcon = false;
			this.Text = "Főoldal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.PBHatter)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PBHatter;
	}
}