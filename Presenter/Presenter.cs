using Models;
using States;
using Views;

namespace Presenters
{
    public class $safeitemname$ : Presenter<View, Model, State>
    {
        protected override void Start()
        {
            base.Start();

            if (!this.IsValid())
            {
                return;
            }

            // Setup view model bindings
        }
    }
}
