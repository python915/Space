
using UnityEngine;

namespace SpaceTrip
{
    public class Player : MonoBehaviour
    {
        public float PlayerSpeed => _playerSpeed;
        public float MoveHorizontal => _moveHorizontal;
        public Rigidbody2D GetRigidbody2D => _player;
        public Vector2 PlayerMovement => _movement;

        [SerializeField] private float _moveHorizontal;
        [SerializeField][Range(2, 10)] private float _playerSpeed;



        private Rigidbody2D _player;
        private Vector2 _movement;



        public void Movement()
        {
            _moveHorizontal = Input.GetAxis("Horizontal") * _playerSpeed;
            _movement = new Vector2(_moveHorizontal, 0);


            _player.velocity = _movement * _playerSpeed;
            

        }

        void Start()
        {
            _player = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            Movement();
        }
    }
}
