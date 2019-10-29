using Data;
using Models;

namespace ModelBinders
{
    public class $safeitemname$ : ModelBinder<Data, Model>
    {
        protected override void Start()
        {
            base.Start();

            if (!this.IsValid())
            {
                return;
            }

            this.gameObject.AddHiddenComponent<Component>();
        }
    }
}
