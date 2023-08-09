using System.Collections;
using UnityEngine;

namespace SpaceTrip
{
    public class NewBehaviourScript : MonoBehaviour
    {
        [SerializeField][Range(.1f, 5f)] private float _timeSpawnM;
        //[SerializeField] private Transform _spawnerPosition;
        [SerializeField] private GameObject _meteor;
        [SerializeField] private float _meteorSpawnPoint;
        [SerializeField] private Vector2 _whereToSpawnMeteor;
        //private Transform SpawnPosition => _spawnerPosition;
        private float MeteorSpawnPoint => _meteorSpawnPoint;
        private GameObject Meteorite => _meteor;
        private float TimeSpawnM => _timeSpawnM;
        private Vector2 WhereToSpawn => _whereToSpawnMeteor;


        void Repeat()
        {
            StartCoroutine(SpawnM());
        }


        IEnumerator SpawnM()
        {
            _meteorSpawnPoint = Random.Range(-8f, 8f);
            _whereToSpawnMeteor = new Vector2(_meteorSpawnPoint, 6.44f);
            Instantiate(Meteorite, _whereToSpawnMeteor, Quaternion.identity, Meteorite.transform.parent = transform);
            yield return new WaitForSeconds(_timeSpawnM);
            Repeat();

        }


        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SpawnM());
        }
    }
}
