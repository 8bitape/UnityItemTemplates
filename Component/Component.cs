using UniRx;
using UniRx.Triggers;
using UniRxEventAggregator.Events;
using UnityEngine;
using UnityValidation.Extensions;

namespace $rootnamespace$
{
    public class $safeitemname$ : BaseComponent
    {
        public void Start()
        {
            if (!this.IsValidObject())
            {
                return;
            }

            // Setup subscriptions
        }
    }
}
