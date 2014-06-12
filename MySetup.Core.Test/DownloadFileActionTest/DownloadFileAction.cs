using NUnit.Framework;
using System.IO;
using TechTalk.SpecFlow;

namespace MySetup.Core.Test
{
    [Binding]
    public class DownloadFileAction
    {
        private DownloadAction downloadFile;

        [Given(@"Download file action")]
        public void GivenDownloadFileAction()
        {
            downloadFile = new DownloadAction();
        }

        [Given(@"I have this download url ""(.*)""")]
        public void GivenIHaveThisDownloadUrl(string p0)
        {
            downloadFile.Url = p0;
        }

        [Given(@"I have this destination path ""(.*)""")]
        public void GivenIHaveThisDestinationPath(string p0)
        {
            downloadFile.DestinationPath = p0;
        }

        [When(@"I do action")]
        public void WhenIDoAction()
        {
            downloadFile.DoAction(null);
        }

        [Then(@"the url should be download to destination path")]
        public void ThenTheUrlShouldBeDownloadToDestinationPath()
        {
            Assert.IsTrue(File.Exists(downloadFile.DestinationPath));
        }
    }
}
