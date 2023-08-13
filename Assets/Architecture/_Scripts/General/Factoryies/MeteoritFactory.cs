using SpaceTrip.Assets.Architecture._Scripts.General;
using UnityEngine;

namespace SpaceTrip
{
    public class MeteoritFactory : ABaseFactory
    {
        public MeteoritFactory(ResourceService resourceService)
        {
            _prefab = resourceService.GetPrefabMeteorit();
        }

        public override GameObject Create()
        {
            return base.Create();
        }
    }
}
