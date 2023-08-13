
using UnityEngine;

namespace SpaceTrip.Assets.Architecture._Scripts.General
{
    public class ResourceService
    {
        private GameObject _prefabCoin;
        private GameObject _prefabMeteorit;
        private GameObject _prefabFuelTank;

        public ResourceService() 
        {
            _prefabCoin = (GameObject) Resources.Load("");
            _prefabMeteorit = (GameObject)Resources.Load("");
        }

        public GameObject GetPrefabMeteorit()
        {
            return _prefabMeteorit;
        }
    }
}
