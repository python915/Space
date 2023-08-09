using UnityEngine;
using UnityEngine.UI;
namespace SpaceTrip
{
    public class FuelBar : MonoBehaviour
    {
        public Slider slider;
        public Fuel rocketFuel;

        public void SetMaxFuel(int fuel)
        {
            slider.maxValue = fuel;
            slider.value = fuel;

            
        }
        public void SetFuel(int fuel)
        {
            
            slider.value = fuel;


        }

        private void Start() 
        {
            SetMaxFuel(rocketFuel.maxFuel);
        }

        private void Update()
        {
            SetFuel(rocketFuel.fuel);
        }
    }
}
