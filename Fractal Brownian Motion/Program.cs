using System;
using System.Windows.Forms;

namespace Fractal_Brownian_Motion
{
	internal static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using (MainForm mainForm = new MainForm())
			{
				Application.Run(mainForm: mainForm);
			}
		}
	}
}
