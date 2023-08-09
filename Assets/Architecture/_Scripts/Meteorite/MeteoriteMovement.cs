using UnityEngine;

namespace SpaceTrip
{
    public class MeteoriteMovement : MonoBehaviour
    {
        [SerializeField] private float _speedMeteor;
        [SerializeField] private Vector2 _meteorMove;
        private float SpeedMeteorite => _speedMeteor;
        private Vector2 MeteorMove => _meteorMove;

        private void FixedUpdate()
        {
            transform.Translate(_speedMeteor * _meteorMove * Time.deltaTime, Space.World);
        }
    }
}
