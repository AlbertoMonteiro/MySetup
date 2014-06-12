using System.IO;
using System.IO.Compression;

namespace MySetup.Core
{
    public class ExtractFile : BaseAction
    {
        public override string Name
        {
            get { return "Extract file"; }
        }

        public override void DoAction(ISetupAction parentAction)
        {
            var downloadAction = parentAction as DownloadAction;
            if (downloadAction != null)
                FilePath = downloadAction.DestinationPath;

            if (Directory.Exists(TargetDirectory))
            {
                Directory.Delete(TargetDirectory, true);
            }
            ZipFile.Open(FilePath, ZipArchiveMode.Read).ExtractToDirectory(TargetDirectory);

            base.DoAction(parentAction);
        }

        public string FilePath { get; set; }
        public string TargetDirectory { get; set; }
    }
}