using System;
using MySetup.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.IO;
using NUnit.Framework;

namespace MySetup.Core.Test
{
    [Binding]
    public class ExtractToPathAction
    {
        private Core.ExtractFile extractFile;

        [Given(@"Extract file action")]
        public void GivenExtractFileAction()
        {
            extractFile = new MySetup.Core.ExtractFile();
        }

        [Given(@"I have this file path ""(.*)""")]
        public void GivenIHaveThisFilePath(string p0)
        {
            extractFile.FilePath = p0;
        }

        [Given(@"I have this target directory path ""(.*)""")]
        public void GivenIHaveThisTargetDirectoryPath(string p0)
        {
            extractFile.TargetDirectory = p0;
        }

        [When(@"I do action extract")]
        public void WhenIDoActionExtract()
        {
            extractFile.DoAction(null);
        }
        
        [Then(@"the zip file should be extracted to destination directory path")]
        public void ThenTheZipFileShouldBeExtractedToDestinationDirectoryPath()
        {
            Assert.IsTrue(Directory.EnumerateFiles(extractFile.TargetDirectory).Any());
        }
    }
}
