﻿/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 23/10/2016
 * Hora: 11:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ScanGifDir
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripBtnAntes;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripBtnDespues;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripButton toolStripBtnOpen;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDir;
		private System.Windows.Forms.ToolStripButton toolStripBtnHelp;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolStripBtnClear;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
			_instance = null;
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripBtnOpen = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnAntes = new System.Windows.Forms.ToolStripButton();
			this.toolStripBtnDespues = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnHelp = new System.Windows.Forms.ToolStripButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelDir = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripBtnClear = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripBtnOpen,
			this.toolStripSeparator1,
			this.toolStripBtnAntes,
			this.toolStripBtnDespues,
			this.toolStripSeparator2,
			this.toolStripBtnHelp,
			this.toolStripSeparator3,
			this.toolStripBtnClear});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(447, 39);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripBtnOpen
			// 
			this.toolStripBtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnOpen.Image")));
			this.toolStripBtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnOpen.Name = "toolStripBtnOpen";
			this.toolStripBtnOpen.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnOpen.Text = "toolStripButton1";
			this.toolStripBtnOpen.Click += new System.EventHandler(this.ToolStripBtnOpenClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripBtnAntes
			// 
			this.toolStripBtnAntes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnAntes.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAntes.Image")));
			this.toolStripBtnAntes.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnAntes.Name = "toolStripBtnAntes";
			this.toolStripBtnAntes.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnAntes.Text = "toolStripButton1";
			this.toolStripBtnAntes.Click += new System.EventHandler(this.ToolStripBtnAntesClick);
			// 
			// toolStripBtnDespues
			// 
			this.toolStripBtnDespues.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnDespues.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnDespues.Image")));
			this.toolStripBtnDespues.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnDespues.Name = "toolStripBtnDespues";
			this.toolStripBtnDespues.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnDespues.Text = "toolStripButton2";
			this.toolStripBtnDespues.Click += new System.EventHandler(this.ToolStripBtnDespuesClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripBtnHelp
			// 
			this.toolStripBtnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnHelp.Image")));
			this.toolStripBtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnHelp.Name = "toolStripBtnHelp";
			this.toolStripBtnHelp.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnHelp.Text = "toolStripButton1";
			this.toolStripBtnHelp.Click += new System.EventHandler(this.ToolStripBtnHelpClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 39);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(447, 360);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1,
			this.toolStripStatusLabelDir});
			this.statusStrip1.Location = new System.Drawing.Point(0, 374);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(447, 25);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 20);
			this.toolStripStatusLabel1.Text = "ScanGifDir";
			// 
			// toolStripStatusLabelDir
			// 
			this.toolStripStatusLabelDir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStripStatusLabelDir.Name = "toolStripStatusLabelDir";
			this.toolStripStatusLabelDir.Size = new System.Drawing.Size(46, 20);
			this.toolStripStatusLabelDir.Text = ": Dir -";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
			// 
			// toolStripBtnClear
			// 
			this.toolStripBtnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnClear.Image")));
			this.toolStripBtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnClear.Name = "toolStripBtnClear";
			this.toolStripBtnClear.Size = new System.Drawing.Size(36, 36);
			this.toolStripBtnClear.Text = "Clear List files";
			this.toolStripBtnClear.Click += new System.EventHandler(this.ToolStripBtnClearClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 399);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "ScanGifDir";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
