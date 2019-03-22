using UniRxEventAggregator.Events;
using UnityEngine;
using UnityValidation.Attributes;

namespace $rootnamespace$
{
    public class $safeitemname$ : PubSubMonoBehaviour
    {
        [RequiredProperty, ValidateObject]
        protected Model Model { get; set; }

        protected void Awake()
        {
            this.Subscribe<Model>(x => this.Model = x);
        }
    }
}
