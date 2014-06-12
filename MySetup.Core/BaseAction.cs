using System.Collections.Generic;

namespace MySetup.Core
{
    public abstract class BaseAction : ISetupAction
    {
        public abstract string Name { get; }
        public virtual void DoAction(ISetupAction parentAction)
        {
            CallDependencies();
        }

        public void CallDependencies()
        {
            foreach (var action in Dependencies)
                action.DoAction(this);
        }

        public IList<ISetupAction> Dependencies { get; set; }
    }
}