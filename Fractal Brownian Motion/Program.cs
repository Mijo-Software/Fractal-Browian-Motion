using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fractal_Brownian_Motion
{
  static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainApp());
    }
  }
}
