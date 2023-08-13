using SpaceTrip.Assets.Architecture._Scripts.General;
using UnityEngine;

namespace SpaceTrip
{
    public abstract class ABaseFactory
    {
        protected GameObject _prefab;

        public virtual GameObject Create()
        {
            return Object.Instantiate(_prefab);
        }
    }
}
