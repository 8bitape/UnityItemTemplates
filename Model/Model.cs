using Data;
using UniRx;

namespace Models
{
    public class $safeitemname$ : IModel<Data>
    {
        public ReactiveProperty<object> Property { get; set; } = new ReactiveProperty<object>();

        public void Init(Data data)
        {
            if (!data.IsValid())
            {
                return;
            }

            this.Property.Value = data.Property;
        }
    }
}
