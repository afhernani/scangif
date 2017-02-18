/*
 * Creado por SharpDevelop.
 * Usuario: hernani
 * Fecha: 23/10/2016
 * Hora: 19:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScanGifDir
{
	/// <summary>
	/// Description of Creditos.
	/// </summary>
	public partial class Creditos : Form
	{
		private static Creditos _instance = null;
		
		protected Creditos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
				
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public static Creditos GetCreditos()
		{
			if (_instance == null)
			{
				_instance = new Creditos();
			}
			return _instance;
		}
		
	}
}
