using System;
using System.Windows.Forms;

namespace TypeCalculator
{
    /// <summary>
    /// The creator of this application is Alex Altman (github: KBKarma)
    /// 
    /// All information used in this application was obtained from Bulbapedia (http://bulbapedia.bulbagarden.net), with specific pages 
    /// referred to listed where they are referenced.
    /// 
    /// Bulbapedia, and this source code, comes under a CC BY-NC-SA 2.5 licence, defined at http://creativecommons.org/licenses/by-nc-sa/2.5/
    /// 
    /// Pokémon and all related properties are © 1995-2014 Nintendo.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}