using Refit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverResearchTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mars Rover Research Tool! To begin, enter a date in format YYYY-MM-DD to pull photos from this date!");
            //prompts the user to enter a date to search the API for
            var DateEntry = Console.ReadLine();
            //creates a variable that will setup the call of the Nasa API
            var nasaApi = RestService.For<INasa>("https://api.nasa.gov");
            //calling the NasaAPI with Get.Images and converts the JSON into the returnimagelist object, which is an array of photos
            var returnImageList = nasaApi.GetImages(DateEntry).Result;

            foreach (var image in returnImageList.photos)
            {
                Process.Start("chrome.exe", image.img_src);
                Console.WriteLine("Enter research notes for the open image ID, press enter to save. The next image in the set will automatically open for you.");
                //noteinput is a string containing what the user inputs 
                string NoteInput = Console.ReadLine();
                //newnote is a new empty object of the type research note and contains a new instance of ResearchNote which has 2 properties
                var NewNote = new ResearchNote();
                //My var newnotw is accessing the Note Property or Researchnote and assigning it the user's string input stored previously in NoteInput
                NewNote.Note = NoteInput;
                //my var newnote is accessing the id property of the image and storing it in newnote along with the note
                NewNote.id = image.id;


                NewNote.url = image.img_src;

                //calls the OutputToFile method
                NewNote.OutputToFile();
            }
        }
    }
}
