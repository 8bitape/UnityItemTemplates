using Models;
using States;
using UniRx;
using Views;

namespace Presenters
{
    public class $safeitemname$ : Presenter<Presenter, View, Model>
    {
        public void Init()
        {
            if (this.IsValid())
            {
                return;
            }
        }

        protected override void Start()
        {
            base.Start();

            if (!this.IsValid())
            {
                return;
            }

            this.OnStateEntered()
                .Where(x => x is State)
                .Subscribe(_ =>
                {
                    this.View.Display(true);
                });

            this.OnStateExited()
                .Where(x => x is State)
                .Subscribe(_ =>
                {
                    this.View.Display(false);
                });
        }
    }
}
