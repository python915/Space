using UnityEngine;

namespace SpaceTrip
{
    public class Background_Behaviour : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _sprite;
        [SerializeField][Range(1, 10)] private float _speed;
        private float Speed => _speed;
        private float _positionMinY;
        private Vector2 _restartPosision;

        private void Awake()
        {
            _restartPosision = transform.position;
            _positionMinY = _sprite.bounds.size.y * 2 - _restartPosision.y;

        }
        

        // Update is called once per frame
        private void FixedUpdate()
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
            if (transform.position.y <= -_positionMinY)
            {
                transform.position = _restartPosision;
            }
        }
    }

}
