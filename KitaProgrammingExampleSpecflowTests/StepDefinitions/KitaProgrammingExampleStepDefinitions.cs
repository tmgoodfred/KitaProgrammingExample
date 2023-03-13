using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using KitaProgrammingExample;
using NUnit.Framework;

namespace KitaProgrammingExampleSpecflowTests.StepDefinitions
{
    [Binding]
    public class KitaProgrammingExampleStepDefinitions
    {
        Main main = new Main();
        List<string> songList = new List<string>();

        string songInput = "Mango";
        bool enterCheck = false;
        bool userEnterCheck = false;
        bool _result = true;

        [Given(@"the user has entered a song")]
        public void GivenTheUserHasEnteredASong()
        {
            userEnterCheck = main.userEnteredValue(songInput);
            //songList.Add("Mango");
            Assert.IsTrue(userEnterCheck);
        }

        [When(@"the song does not exist")]
        public void WhenTheSongDoesNotExist()
        {
            enterCheck = main.CheckIfItemExists(songList, songInput);
            Assert.AreEqual(enterCheck, false);
        }

        [Then(@"the output will tell the user and be added to the list")]
        public void ThenTheOutputWillTellTheUserAndBeAddedToTheList()
        {
            main.setOutput(true);
        }
    }
}
