using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Game
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			new Startup().Run(args);
		}
	}

	public class Startup : WindowsFormsApplicationBase
	{
		protected override void OnCreateSplashScreen()
		{
			SplashScreen = new SplashForm();
		}

		protected override void OnCreateMainForm()
		{
			MainForm = new StartForm();
		}
	}
}
