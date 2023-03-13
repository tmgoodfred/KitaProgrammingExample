namespace KitaProgrammingExample
{
    public partial class Form1 : Form
    {
        List<string> songs = new List<string>();    //need to create the list to hold all the song titles
        public Form1()
        {
            InitializeComponent();  //this is auto-generated
        }

        private void submitBtn_Click(object sender, EventArgs e)    //this is the code that is run when you press the button
        {
            string songTitle = songTxt.Text;    //this takes the text entered from the user in the text box and stores it in a string
            string artistName = artistTxt.Text; //this takes the text entered from the user in the text box and stores it in a string
            bool existsFlag = false;    //this will be used to determine if a song already exists

            foreach (string song in songs){ //this will go through the list we created before and for every item in there it compares it to what was entered
                if (song == songTitle)  //if it DOES exist
                {
                    existsFlag = true;  //then it will trigger the flag
                    break;
                }
            }
            if (existsFlag == true) //if it exists, we want to trigger some code
            {
                outputTxt.Text = "We have it!"; //nothing will happen essentially
            }
            else
            {
                outputTxt.Text = "We'll add it.";
                songs.Add(songTitle);   //if the song doesn't exist, we add it to the list
            }
        }
    }
}