﻿/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 23/10/2016
 * Hora: 11:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using LibPanes;

namespace ScanGifDir
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form, IForm
	{
		private static MainForm _instance = null;
		
		private MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			Index = 0;
			CurrentFile = string.Empty;
			if (!String.IsNullOrEmpty(Init.Default.DirPathShow)) {
				if (Directory.Exists(Init.Default.DirPathShow))
					LoadFromSelectedPath(Init.Default.DirPathShow);
			}
		}
		// Inatancia unica singleton
		
		public static MainForm GetInstancia()
		{
			if (_instance == null) {
				_instance = new MainForm();
			}
			return _instance;
		}
		// El orden "global" de pulsación es:
		// KeyDown en formulario
		// KeyDown en control
		// KeyPress en formulario
		// KeyPress en control
		// KeyUp en formulario
		// KeyUp en control

		// para que detecte las pulsaciones en el formulario
		// hay que asignar un valor True a la propiedad KeyPreview del formulario

		// en KeyDown no diferencia entre mayúsculas y minúsculas
		// en KeyPess si distingue la diferencia

		private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar) {
				case (char)Keys.Z: // mayúsculas
					toolStripStatusLabel1.Text = "Z -> " + PathCurrent;
					//textBox3.Text += "\r\nTecla W en el formulario (KeyPress)";
                    //clipboard pathcurrent fichero.
                    if(!string.IsNullOrEmpty(PathCurrent))Clipboard.SetText(PathCurrent);
					break;
				case (char)(Keys.Z + 32): // minúsculas
					toolStripStatusLabel1.Text = "z -> " + PathCurrent;
                    //textBox3.Text += "\r\nTecla W en el formulario (KeyPress)";
                    if (!string.IsNullOrEmpty(PathCurrent)) Clipboard.SetText(PathCurrent);
                    break;
				case (char)Keys.Y:
					toolStripStatusLabel1.Text = "Y";
					break;
				case (char)(Keys.Y + 32): // minúsculas
					toolStripStatusLabel1.Text = "y";
					break;
				default:
					toolStripStatusLabel1.Text = "Tecla^: " + e.KeyChar.ToString();
					//textBox3.Text += "\r\nTecla W en el formulario (KeyDown)";
					break;
			}
			if (e.KeyChar == (char)(Keys.X + 32) && (ModifierKeys & Keys.Control) == Keys.Control) {
				Debug.WriteLine("Hello Hernani");
			}

		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			//return;
			// da igual mayúsculas que minúsculas
			switch (e.KeyCode) {
				case Keys.S:
					toolStripStatusLabel1.Text = "S";
					break;
				case Keys.W:
					toolStripStatusLabel1.Text = "W";
					//textBox3.Text += "\r\nTecla W en el formulario (KeyDown)";
					break;
				case Keys.Right:
					KeyRignt();
					toolStripStatusLabel1.Text = "-->";
					break;
				case Keys.Left:
					KeyLeft();
					toolStripStatusLabel1.Text = "<--";
					break;
				default:
					toolStripStatusLabel1.Text = "Tecla " + e.KeyCode.ToString();
					//textBox3.Text += "\r\nTecla W en el formulario (KeyDown)";
					break;
					
			}
			if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control) {
				Debug.WriteLine("Hello world");
			}
			if (e.Control && e.Shift && e.KeyCode == Keys.P) {
				MessageBox.Show("Hello");
			}
		}

		private void MainForm_KeyUp(object sender, KeyEventArgs e)
		{
			/*
			switch (e.KeyValue) {
				case (char)Keys.S:
					toolStripStatusLabel1.Text = "Tecla S en el formulario (KeyUp)";
					break;
				case (char)Keys.W:
					toolStripStatusLabel1.Text = "Tecla W en el formulario (KeyUp)";
					//textBox3.Text += "\r\nTecla W en el formulario (KeyUp)";
					break;
			} */

		}


		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			string filesearch = GetFileNameFromString(CurrentFile);
			if (keyData == (Keys.Control | Keys.Alt | Keys.S)) {
				Debug.WriteLine("<CTRL> + Alt + S Captured");
				LanchCtrlSearch(filesearch);	
			}
			if (keyData == (Keys.Control | Keys.V)) {
				Debug.WriteLine("<CTRL> + V Captured");
				SearchAndLunchVideo(filesearch);	
			}
			if (keyData == (Keys.Left)) {
				Debug.WriteLine("Keys Left");
				KeyLeft();	
			}
			if (keyData == (Keys.Right)) {
				Debug.WriteLine("Keys right");
				KeyRignt();		
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
		
		private void LanchCtrlSearch(string filesearch)
		{
			if (Path.GetExtension(filesearch).Equals(".gif")) {
				MessageBox.Show("OOOfff");
				return;
			}
			CtrlSearch ctrlsearch = CtrlSearch.GetInstancia();
			ctrlsearch.SearchString = filesearch;
			ctrlsearch.Show();
			
		}
		private void SearchAndLunchVideo(string filesearch)
		{
			if (Path.GetExtension(filesearch).Equals(".gif")) {
				MessageBox.Show("OOOfff");
				return;
			}
			Search control = new Search() {
				SearchString = filesearch,
				AutoProcess = true
			};
			control.Start();
                    
		}
		
		public static string GetFileNameFromString(string name)
		{
			int pos = name.IndexOf(@"_thumbs_", StringComparison.Ordinal);
			if (pos == -1)
				return name;
			name = name.Substring(0, pos);
			return Path.GetFileName(name);
		}
		
		// el orden de pulsación es:
		//  KeyDown, KeyPress y KeyUp
		
		List<string> _FilesNames = new List<string>();
		
		string _pathactual = string.Empty;
		
		public string PathCurrent {
			get{ return _pathactual; }
			set{ _pathactual = value; }
		}
		
		public void Start()
		{
			if (!String.IsNullOrEmpty(PathCurrent)) {
				LoadFromSelectedPath(PathCurrent);
				if (!String.IsNullOrEmpty(CurrentFile)) {
					Index = _FilesNames.IndexOf(CurrentFile);
					PresentImagenInPictureBox(Index);
				}
			}
		}
		
		public string CurrentFile{ get; set; }
		
		void ToolStripBtnOpenClick(object sender, EventArgs e)
		{
			FolderBrowserDialog folder = new FolderBrowserDialog();
			DialogResult result = folder.ShowDialog();
			if (result == DialogResult.OK) {
				_FilesNames.Clear();
				LoadFromSelectedPath(folder.SelectedPath);		
			}
		}
		
		private void LoadFromSelectedPath(string folder)
		{
			Index = 0;
			PathCurrent = folder;
		    folder = Path.Combine(folder, "Thumbails");
		    if (!Directory.Exists(folder)) return;
			string[] files = Directory.GetFiles(folder, "*.gif");
			toolStripStatusLabelDir.Text = " : Dir - " + Path.GetDirectoryName(PathCurrent);
			//tenemos que clear el _FilesNames, o si no adicionamos directorios.
			_FilesNames.AddRange(files);
			PresentImagenInPictureBox(0);
		}
		
		private int Index{ get; set; }
		
		private void PresentImagenInPictureBox(int index)
		{
			string file = _FilesNames[index];
			if (File.Exists(file)) {
				this.Text = "ScanGirDir: - " + Path.GetFileName(file);
				toolStripStatusLabelDir.Text = " : Dir - " + Path.GetFileName(file);
                imagenBox1.Reset();
                imagenBox1.FromFile(file);
                imagenBox1.SetCurrentFrame = (int)(imagenBox1.Count / 2);
                CurrentFile = file;
			} else {
				toolStripStatusLabelDir.Text = " : Dir - impossible to load file ";
			}
		}
		
		private void KeyRignt()
		{

			if (_FilesNames != null && _FilesNames.Count != 0) {
				if (Index < _FilesNames.Count - 1) {
					Index++;
					PresentImagenInPictureBox(Index);
				} else {
					Index = 0;
					PresentImagenInPictureBox(Index);
				}
			}
			
		}
		private void KeyLeft()
		{
			if (_FilesNames != null && _FilesNames.Count != 0) {
				if (Index >= 1) {
					Index--;
					PresentImagenInPictureBox(Index);
				} else {
					Index = _FilesNames.Count - 1;
					PresentImagenInPictureBox(Index);
				}
			}
		}
		void ToolStripBtnDespuesClick(object sender, EventArgs e)
		{
			KeyRignt();
		}
		void ToolStripBtnAntesClick(object sender, EventArgs e)
		{
			KeyLeft();
		}
		
		void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && (ModifierKeys & Keys.Control) == Keys.Control) {
				MessageBox.Show("Control key + MouseButton Left was held down.");
			}
		}
		//Creditos creditos;
		void ToolStripBtnHelpClick(object sender, EventArgs e)
		{
			Creditos creditos = Creditos.GetCreditos();
			creditos.Show();
		}
		
		void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!String.IsNullOrEmpty(PathCurrent)) {
				Init.Default.DirPathShow = PathCurrent;
				Init.Default.Save();
			}
		}
		void ToolStripBtnClearClick(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Clean list of files *.gif", "Advertencia",
				                   MessageBoxButtons.OKCancel,
				                   MessageBoxIcon.Exclamation);
			if (res == DialogResult.OK) {
				_FilesNames.Clear();
				Index = 0;
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		
		#region IForm implementation
		public void ChangeDirToExplore(string pathdir)
		{
			if (Directory.Exists(pathdir + @"\Thumbails"))
            {
				//limpia la pagina actual/seleccionada
				//añade los nuevos elementos del directorio siguiente
				_FilesNames.Clear();
                LoadFromSelectedPath(pathdir);
            }
		}
		public void AddFileFoundedSeached(FileInfo file)
		{
			Debug.WriteLine("addfilefoundedseached {"+file.FullName+"}");
			_FilesNames.Add(file.FullName);
		}
		#endregion
		void ToolStripBtnMovieClick(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(CurrentFile)) return;
            string movie = CombineAddressFileMovie(CurrentFile);
            if (File.Exists(movie)) Process.Start(movie);
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
            Debug.WriteLine("direccion fichero: "+cad);
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
		void ToolStripBtnGifClick(object sender, EventArgs e)
		{
			//Image sprite = Image.FromFile(CurrentFilePath);
			showGif fgif = new showGif();
			if(!String.IsNullOrEmpty(CurrentFile))
				fgif.PathRoot = CurrentFile;
            //Size size = new Size(sprite.Width, sprite.Height);
            //fgif.Size = size;
            //fgif.ImageToView = sprite;
            //fgif.Tag = CurrentFilePath;// sprite.Tag;
            fgif.Show();
		}
		void ToolStripBtnExploreClick(object sender, EventArgs e)
		{
			Explora explo = Explora.GetInstancia();
            explo.Show(this);
		}
		void ToolStripBtnSearchClick(object sender, EventArgs e)
		{
			Busca fr = new Busca();
            fr.Show(this);
		}
		void ToolStripBtnViewerClick(object sender, EventArgs e)
		{
			Viewer vis = new Viewer();
			if(_FilesNames!=null && _FilesNames.Count > 0)
				vis.Listaficheros = _FilesNames;
			vis.Show();
		}
	}
}
