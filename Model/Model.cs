using UniRx;
using UnityEngine;
using UnityValidation.Attributes;
using UnityValidation.Extensions;

namespace $rootnamespace$
{
    public class $safeitemname$ : IModel<Data>
    {
        [RequiredProperty]
        public ReactiveProperty<object> ReactiveProperty { get; set; }

        public void Init(Data data)
        {
            if (!data.IsValidObject())
            {
                return;
            }

            this.ReactiveProperty = new ReactiveProperty<object>(data.Property);
        }
    }
}
