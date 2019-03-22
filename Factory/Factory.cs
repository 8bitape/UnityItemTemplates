using UniRx;
using UniRxEventAggregator.Events;
using UnityEngine;
using UnityValidation.Extensions;

namespace $rootnamespace$
{
    public class $safeitemname$ : Factory<Data, Model>
    {
        private void Start()
        {
            if (!this.IsValidObject())
            {
                return;
            }

            // Add components
        }
    }
}
