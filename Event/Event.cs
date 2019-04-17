namespace Events
{
    public struct $safeitemname$
    {
        public object Property { get; private set; }

        public $safeitemname$(object property)
        {
            this.Property = property;
        }
    }
}
