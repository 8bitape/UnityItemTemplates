using Components;
using Data;
using Models;

namespace Factories
{
    public class $safeitemname$ : ModelBinder<Data, Model>
    {
        protected override void Awake()
        {
            base.Awake();

            if (!this.IsValid())
            {
                return;
            }

            this.gameObject.AddHiddenComponent<Component>();
        }
    }
}
