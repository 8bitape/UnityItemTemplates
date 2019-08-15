using Models;
using PubSubMonoBehaviours;

namespace Components
{
    public abstract class $safeitemname$ : StateEnabledPubSubMonoBehaviour
    {
        protected Model Model { get; set; }

        public override bool IsValid()
        {
            return base.IsValid() &&
                this.Model != null;
        }

        protected override void Awake()
        {
            base.Awake();

            this.Subscribe<Model>(x => this.Model = x);
        }
    }
}
