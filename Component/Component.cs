using UniRx;

namespace Components
{
    public class $safeitemname$ : BaseComponent
    {
        private void Start()
        {
            if (!this.IsValid())
            {
                return;
            }
            
            this.OnUpdate()
                .Subscribe(_ =>
                {
                    
                });
        }
    }
}
