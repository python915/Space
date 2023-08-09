using System;
using UnityEngine;

namespace SpaceTrip
{
    public class Fuel : MonoBehaviour
    {
        public int fuel;
        public int maxFuel;
        public int spending = 10;
        
        public void SpendingFuel()
        {
            fuel -= spending * Convert.ToInt32 (Time.deltaTime);
        }
        public void TakeFuel(int flow)
        {
            fuel -= flow;
            if( fuel <= 0)
            {
                Lives lives = GetComponent<Lives>();
                lives.TakeLives();
                Destroy(gameObject);
                

            }

        }

        public void Refuel(int gas)
        {
            fuel += gas;

            if (fuel > maxFuel)
            {
                fuel = maxFuel;
            }

        }

        private void Update()
        {
            SpendingFuel();
        }


    }
}
