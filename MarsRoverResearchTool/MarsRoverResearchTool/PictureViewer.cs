using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverResearchTool
{
    class PictureViewer
    {
        public void ShowPicture(List<string> hrefs)
        {
            foreach (var href in hrefs)
            {
                //returns a string
                //read that string
                //put that string into a list
                //save string, url, and the image id into a local file
                Process.Start("chrome.exe", href);
                Console.WriteLine("Enter research notes for the open image ID, press enter to save your notes to a .txt file. The next image in the set will automatically open for you.");
                Console.ReadLine();
            }
        }
    }
}
