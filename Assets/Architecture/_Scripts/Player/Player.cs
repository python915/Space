
using SpaceTrip.Architecture._Scripts.Player;
using UnityEngine;

namespace SpaceTrip
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : MonoBehaviour
    {
        public float Speed => _speed;
        public float PositionX => _positionX;
        public Rigidbody2D Rigidbody => _rigidbody;
        public Vector2 DirectionMovement => _directionMovement;

        [SerializeField] private float _positionX;
        [SerializeField][Range(2, 10)] private float _speed;

        private Vector2 _directionMovement;

        private Rigidbody2D _rigidbody;
        private IInputService _inputService;

        public void Init(IInputService inputService)
        {
            _inputService = inputService;
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            CalculateDirectionMovement();
            Movement();
        }

        public void Movement()
        {
            _rigidbody.velocity = _directionMovement * _speed;
        }

        private void CalculateDirectionMovement()
        {
            _positionX = _inputService.GetAxisHorizontal * _speed;
            _directionMovement.x = _positionX;
        }
    }
}
