using SpaceTrip.Architecture._Scripts.Player;
using UnityEngine;

namespace SpaceTrip.Assets.Architecture._Scripts.General
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private MeteorSpawner _meteoritSpawner;
        [SerializeField] private CoinsSpawner _coinsSpawner;
        [SerializeField] private FuelTankSpawner _fuelTankSpawner;

        private IInputService _inputService;
        private FactoryService _factoryService;
        private ResourceService _resourceService;

        private void Awake()
        {
            _resourceService = new ResourceService();
            _inputService = new PCInputSystem();
            _factoryService = new FactoryService(_resourceService);

            _player.Init(_inputService);
            _meteoritSpawner.Init(_factoryService);
        }
    }
}
