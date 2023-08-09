
using UnityEngine;

namespace SpaceTrip
{
    public class Destroyer : MonoBehaviour
    {
        public void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
        }
    }
}
