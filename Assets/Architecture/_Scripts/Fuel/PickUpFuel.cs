using UnityEngine;

namespace SpaceTrip
{
    public class PickUpFuel : MonoBehaviour
    {
        public string _collisionTag;
        public int _fuelTank = 100 ;


        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Gas")
            {
                Fuel fuel = gameObject.GetComponent<Fuel>();
                Debug.Log("Catch");
                fuel.Refuel(_fuelTank);
                Destroy(other.gameObject);



            }
        }
    }
}
