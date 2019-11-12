using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;



namespace Scavenger
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Event Publisher
            UIForm gui = new UIForm();
            //Event Subscriber
            Directory directory = new Directory(gui);
            Comparison comparison = new Comparison(gui);
            //Subscriber
  
            gui.SearchButtonClicked += directory.DisplayUserResult;
            gui.SaveButtonClicked += directory.SaveUserSecGroups;
            gui.compare.SearchButton2Clicked += comparison.CompareUsers;
            gui.compare.SearchButton2Clicked += gui.AddResultPanel;
            Application.Run(gui);

        }

    }
}
