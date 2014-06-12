using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MySetup.Core
{
    public interface ISetupAction
    {
        string Name { get; }
        void DoAction(ISetupAction parentAction);
        void CallDependencies();
        IList<ISetupAction> Dependencies { get; set; }
    }
}
