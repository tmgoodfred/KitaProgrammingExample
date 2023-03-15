using System.IO;

namespace KitaProgrammingExample
{
    public partial class Main : Form
    {
        List<string> songs = new List<string>();    //need to create the list to hold all the song titles
        List<string> albumArtists = new List<string>();
        List<string> songLists = new List<string>();
        public Main()
        {
            //test
            string[] albums = Directory.GetFiles(@"~\albumart");
            string[] songs = Directory.GetFiles(@"~\songlists");
            albumArtists = albums.ToList();
            songLists = songs.ToList();
            InitializeComponent();  //this is auto-generated
        }

        private void submitBtn_Click(object sender, EventArgs e)    //this is the code that is run when you press the button
        {
            string songTitle = songTxt.Text;    //this takes the text entered from the user in the text box and stores it in a string
            string artistName = artistTxt.Text; //this takes the text entered from the user in the text box and stores it in a string
            bool existsFlag = false;    //this will be used to determine if a song already exists
            bool valueEntered = false;

            valueEntered = userEnteredValue(songTitle); //need to actually do something with this, such as donig a while loop or an if statement

            existsFlag = CheckIfItemExists(songs, songTitle);   //this calls the method we created below. If a match is found, it's true, else it's false

            if (existsFlag == true) //if it exists, we want to trigger some code
            {
                setOutput(true); //nothing will happen essentially
            }
            else
            {
                setOutput(false);
                songs.Add(songTitle);   //if the song doesn't exist, we add it to the list
            }

            if (albumArtists.Contains(@"~\albumart\" + songTitle.ToLower() + ".jpg") == true || albumArtists.Contains(@"~\albumart\" + artistName.ToLower() + ".jpg") == true)   //if we have a match on the song title with an album 
            {
                try
                {
                    albumArt.Image = Image.FromFile(@"~\albumart\" + songTitle + ".jpg");
                }
                catch { }
                try
                {
                    albumArt.Image = Image.FromFile(@"~\albumart\" + artistName + ".jpg");
                }
                catch { }
            }
            if (songLists.Contains(@"~\songlists\" + songTitle.ToLower() + ".txt") == true || songLists.Contains(@"~\songlists\" + artistName.ToLower() + ".txt") == true)
            {
                try
                {
                    trackList.Text = File.ReadAllText(@"~\songlists\" + songTitle + ".txt");
                }
                catch { }
                try
                {
                    trackList.Text = File.ReadAllText(@"~\songlists\" + artistName + ".txt");
                }
                catch { }
            }
        }

        public int TryToDoMath(int num1, int num2)  //ONLY FOR TESTING PURPOSES
        {
            return num1 + num2;
        }

        public bool CheckIfItemExists(List<string> listOfItems, string userInput)   //this will check if the item exists in our list
        {
            bool flag = false;
            foreach (string item in listOfItems)
            { //this will go through the list we created before and for every item in there it compares it to what was entered
                if (item == userInput)  //if it DOES exist
                {
                    flag = true;  //then it will trigger the flag
                    break;
                }
            }
            return flag;    //this sends back the flag
        }

        public bool userEnteredValue(string enteredValue)
        {
            if (string.IsNullOrWhiteSpace(enteredValue))
            {
                return false;
            }
            else
                return true;
        }

        public void setOutput(bool result)
        {
            if(result == true)
            {
                outputTxt.Text = "We have it!";
            }
            else
                outputTxt.Text = "We'll add it.";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            outputTxt.Clear();
            songTxt.Clear();
            artistTxt.Clear();
            albumArt.Image = null;
            trackList.Clear();
        }
    }
}