using System.Collections;
using UnityEngine;

namespace SpaceTrip
{
    public class MeteorSpawner : MonoBehaviour
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

        private FactoryService _factoryService;

        public void Init(FactoryService factoryService)
        {
            _factoryService = factoryService;
        }


        public void StartSpawn()
        {
            StartCoroutine(Spawning());
        }

        public void StopSpawn()
        {
            StopCoroutine(Spawning());
        }



        private void Repeat()
        {
            StartCoroutine(Spawning());
        }


        private IEnumerator Spawning()
        {
            _meteorSpawnPoint = Random.Range(-8f, 8f);
            _whereToSpawnMeteor = new Vector2(_meteorSpawnPoint, 6.44f);
            
            var meteorit = _factoryService.GetMeteoritFactory().Create();
            meteorit.transform.parent = transform;
            meteorit.transform.position = _whereToSpawnMeteor;

            yield return new WaitForSeconds(_timeSpawnM);
            Repeat();

        }

    }
}
