/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 09/08/2017
 * Hora: 11:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScanGifDir
{
	/// <summary>
	/// Description of showGif.
	/// </summary>
	public partial class showGif : Form
	{
		public showGif()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public string PathRoot{ get;set; }
		
		string filename = string.Empty;
		string name_Only;
		
		private void ImagenBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfile =new OpenFileDialog()
			{
				Filter = "All files(*.*)|*.*|Gif file(*.gif*)|*.gif",
				Title = @"Open gif to load",
				//InitialDirectory = Environment.CurrentDirectory,
				//RestoreDirectory = true
				Multiselect = true
			};
			
			if(openfile.ShowDialog()==DialogResult.OK)
			{
				filename = openfile.FileName;
				name_Only = openfile.SafeFileName;
				foreach (var item in openfile.FileNames)
                {
					imagenbox1.FromFile(item);
                }
			}
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.G))
            {
                this.Text =("<CTRL> + G Save Gif");
                SaveFileToDisk();
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                this.Text=("<CTRL> + S save all imagens to disk");
                SaveAllImagensToDisk();
            }
            if (keyData == (Keys.Control | Keys.C))
            {
                this.Text=("<CTRL> + C save current image to disk");
                SaveCurrentImageToDisk();
            }
            if (keyData == (Keys.Control | Keys.H))
            {
                this.Text=("<CTRL> + H help comands");
				MessageBox.Show(" shotkut:\n" +
				"<CTRL> + G Save Gif\n" +
				"<CTRL> + S save all imagens to disk\n" +
				"<CTRL> + C save current image to disk");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SaveFileToDisk()
        {
            SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "Gif file(*.gif*)|*.gif",
                Title = @"Save gif to disk",
                //InitialDirectory = Environment.CurrentDirectory,
                //RestoreDirectory = true,
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                imagenbox1.SaveGif(savefile.FileName);
            }
        }
        private void SaveAllImagensToDisk(){
        	SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "JPG file(*.jpg*)|*.jpg",
                Title = @"Save jpg to disk",
                //InitialDirectory = Environment.CurrentDirectory,
                //RestoreDirectory = true,
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
				imagenbox1.SaveCurrentImagen(savefile.FileName);
            }
        }
        private void SaveCurrentImageToDisk()
        {
        	SaveFileDialog savefile = new SaveFileDialog()
            {
                Filter = "JPG file(*.jpg*)|*.jpg",
                Title = @"Save jpg to disk",
                //InitialDirectory = Environment.CurrentDirectory,
                //RestoreDirectory = true,
            };
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                
                imagenbox1.SaveCurrentImagen(savefile.FileName);
            }
        }
		void ShowGifLoad(object sender, EventArgs e)
		{
			if(!String.IsNullOrEmpty(this.PathRoot)){
				this.imagenbox1.FromFile(PathRoot);
			}
		}

		
	}
}
