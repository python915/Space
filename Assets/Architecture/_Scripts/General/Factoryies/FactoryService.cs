using SpaceTrip.Assets.Architecture._Scripts.General;

namespace SpaceTrip
{
    public class FactoryService
    {
        private MeteoritFactory _meteoritFactory;
        private CoinFactory _coinFactory;
        private FuelTankFactory _fuelTankFactory;

        public FactoryService(ResourceService resourceService)
        {
            _meteoritFactory= new MeteoritFactory(resourceService);
            _coinFactory= new CoinFactory(resourceService);
            _fuelTankFactory= new FuelTankFactory(resourceService);
        }

        public ABaseFactory GetMeteoritFactory()
        {
            return _meteoritFactory;
        }

        public ABaseFactory GetCoinFactory()
        {
            return _coinFactory;
        }

        public ABaseFactory GetFuelTankFactory()
        {
            return _fuelTankFactory;
        }
    }
}
