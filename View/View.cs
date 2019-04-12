namespace Views
{
    public class $safeitemname$ : View<$safeitemname$>
    {
        [SerializeField]
        private object _backingField = null;

        public object Property { get { return this._backingField; } }

        public override bool IsValid()
        {
            return base.IsValid() &&
                this.Property != null;
        }
    }
}
