using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "$safeitemrootname$", menuName = "$safeitemrootname$")]
    public class $safeitemname$ : Data<$safeitemname$>
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