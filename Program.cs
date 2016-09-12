/*
read and write from and to files:
- user.json
- sound.json
- lesson.json
- quiz.json

- each file represents a different class
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using PitchPerfect.model;
using System.IO;
using System.Reflection;

namespace PitchPerfect
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            //Windows Form Loading
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PitchPerfect_());
        }
    }
}
