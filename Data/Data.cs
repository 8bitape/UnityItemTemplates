using UnityEngine;
using UnityValidation.Attributes;

namespace $rootnamespace$
{
    [CreateAssetMenu(fileName = "$safeitemrootname$", menuName = "$safeitemrootname$")]
    public class $safeitemname$ : Data<$safeitemname$>
    {
        [SerializeField]
        private object _backingField = null;

        [RequiredProperty]
        public object Property { get { return this._backingField; } }
    }
}