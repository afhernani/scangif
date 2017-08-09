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
					pn.FromFile(_listaficheros[Index]);
					pn.CurrentFrame = 10;
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
	}
}
