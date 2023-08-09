
using UnityEngine;


namespace SpaceTrip
{
    public class CollisionDamage : MonoBehaviour
    {
        public int collisionDamage = 10;
        public string collisionTag;
        
        public void OnTriggerEnter2D(Collider2D coll)
        {
            if (coll.gameObject.tag == collisionTag)
            {
                
                Fuel fuel = coll.gameObject.GetComponent<Fuel>();
                fuel.TakeFuel(collisionDamage);
                Destroy(gameObject);
                


            }
        }
    }
}
