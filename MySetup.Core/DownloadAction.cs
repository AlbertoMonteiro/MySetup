using System.Collections.Generic;
using System.Net;

namespace MySetup.Core
{
    public class DownloadAction : BaseAction
    {
        public override string Name
        {
            get { return "Download file"; }
        }

        public override void DoAction(ISetupAction parentAction)
        {
            using (var webClient = new WebClient())
                webClient.DownloadFile(Url, DestinationPath);

            base.DoAction(this);
        }

        public string Url { get; set; }
        public string DestinationPath { get; set; }
    }
}