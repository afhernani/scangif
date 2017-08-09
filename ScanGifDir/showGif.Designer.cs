/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 09/08/2017
 * Hora: 11:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ScanGifDir
{
	partial class showGif
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private LibPanes.ImagenBox imagenbox1;
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
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.imagenbox1 = new LibPanes.ImagenBox();
			this.SuspendLayout();
			// 
			// imagenbox1
			// 
			this.imagenbox1.CausesValidation = false;
			this.imagenbox1.CurrentFrame = 0;
			this.imagenbox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imagenbox1.Imagen = null;
			this.imagenbox1.Location = new System.Drawing.Point(0, 0);
			this.imagenbox1.Name = "imagenbox1";
			this.imagenbox1.NamePathFile = "";
			this.imagenbox1.Reverse = false;
			this.imagenbox1.Size = new System.Drawing.Size(434, 293);
			this.imagenbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imagenbox1.TabIndex = 3;
			this.imagenbox1.Time = 800;
			this.imagenbox1.Click += new System.EventHandler(this.ImagenBox1_Click);
			// 
			// showGif
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 293);
			this.Controls.Add(this.imagenbox1);
			this.Name = "showGif";
			this.Text = "showGif";
			this.Load += new System.EventHandler(this.ShowGifLoad);
			this.ResumeLayout(false);

		}
	}
}
