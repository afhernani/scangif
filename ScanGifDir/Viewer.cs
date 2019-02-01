/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 05/08/2017
 * Hora: 1:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibPanes;
using System.IO;
using System.Diagnostics;

namespace ScanGifDir
{
	/// <summary>
	/// Description of Viewer.
	/// </summary>
	public partial class Viewer : Form
	{
		Task t;
		public List<string> _listaficheros; //= new List<string>();
		public List<string> Listaficheros{
			set
			{
				_listaficheros = value;
			}
		}
		public Viewer()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			LimtConatrols = 15;
			ContadorActual = 0;
		}
		/// <summary>
		/// limite de componenetes a presentar en el control flowlayoutpane
		/// </summary>
		public int LimtConatrols{ get; set; }
		/// <summary>
		/// contador de hasta donde se ha cargado
		/// </summary>
		int ContadorActual{ get; set; }
		/// <summary>
		/// index
		/// </summary>
		int Index{ get; set; }
		void ViewerLoad(object sender, EventArgs e)
		{
			Index = 0;
			t = Task.Factory.StartNew(AddSpriteToControlFlowLayoutPane);
		}
		private void AddSpriteToControlFlowLayoutPane()
		{
			if(_listaficheros!=null)
			{
				//flowLayoutPanel.Controls.Clear();
				while (ContadorActual < LimtConatrols) 
				{
					ImagenBox pn = new ImagenBox(){
						Width=220,
						Height=110,
					};
                    pn.DoubleClick += pn_DoubleClick;
                    pn.Tag = _listaficheros[Index];
					pn.FromFile(_listaficheros[Index]);
                    pn.SetCurrentFrame = (int)Math.Floor((decimal)(pn.Count / 2));
					if (Index < _listaficheros.Count-1)
						Index++;
					else
						Index = 0;
					Invoke(new Action(()=>AddSprite(pn)));
					ContadorActual++;
				}
				ContadorActual = 0;
			}
		}

        private void pn_DoubleClick(object sender, EventArgs e)
        {
            ImagenBox pn = (ImagenBox)sender;
            string CurrentFilePath = pn.Tag.ToString();
            if (String.IsNullOrEmpty(CurrentFilePath)) return;
            string movie = CombineAddressFileMovie(CurrentFilePath);
            if (File.Exists(movie)) Process.Start(movie);
        }

        void AddSprite(ImagenBox pn)
		{
			if(flowLayoutPanel.Controls.Count>LimtConatrols-1)
				flowLayoutPanel.Controls.RemoveAt(0);
			flowLayoutPanel.Controls.Add(pn);
		}
		void ToolStripBtnRightClick(object sender, EventArgs e)
		{
			//flowLayoutPanel.Controls.Clear();
			t = Task.Factory.StartNew(AddSpriteToControlFlowLayoutPane);
		}
        /// <summary>
        /// encontrar el nombre del fichero de video referenciado.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private static string GetFileNameFromString(string name)
        {
            int pos = name.IndexOf(@"_thumbs_", StringComparison.Ordinal);
            if (pos == -1)
                return name;
            name = name.Substring(0, pos);
            return Path.GetFileName(name);
        }

        private static string CombineAddressFileMovie(string currentfilepath)
        {
            string name = null;
            string cad = null;
            if (!String.IsNullOrEmpty(currentfilepath))
            {
                name = GetFileNameFromString(currentfilepath);
                cad = Path.Combine(PathNivel(Path.GetDirectoryName(currentfilepath), 1), name);
            }

            Debug.WriteLine($"direccion fichero: {cad}");
            return cad;
        }
        /// <summary>
		/// Utilidad para retroceder
		/// devuelve el nivel n veces inferior en el path
		/// </summary>
		/// <param name="root"></param>
		/// <param name="n"></param>
		/// <returns></returns>
	    private static string PathNivel(string root, int n)
        {
            string[] name = root.Split(Convert.ToChar(@"\"));
            string path = name[0];
            for (int i = 1; i < name.Length - n; i++)
            {
                path += @"\" + name[i];
            }

            return path;
        }

    }
}
