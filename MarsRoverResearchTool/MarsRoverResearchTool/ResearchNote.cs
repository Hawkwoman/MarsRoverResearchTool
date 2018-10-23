using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverResearchTool
{
    class ResearchNote
    {
        public string Note;

        public int id;

        public string url;

        public void OutputToFile()
        {
            using (StreamWriter writer = new StreamWriter("MarsRoverResearchNotes.txt"))
            {
                writer.WriteLine(id);
                writer.WriteLine(url);
                writer.WriteLine(Note);
            }
        }
    }
}
