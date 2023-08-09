using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceTrip
{
    public class CoinsSpawner : MonoBehaviour
    {
        [SerializeField][Range(.1f, 5f)] private float _timeSpawnC;
        //[SerializeField] private Transform _spawnerPosition;
        [SerializeField] private GameObject _coin;
        [SerializeField] private float _coinSpawnPoint;
        [SerializeField] private Vector2 _whereToSpawnCoin;
        //private Transform SpawnPosition => _spawnerPosition;
        private float CoinSpawnPoint => _coinSpawnPoint;
        private GameObject Coin => _coin;
        private float TimeSpawnC => _timeSpawnC;
        private Vector2 WhereToSpawnCoin => _whereToSpawnCoin;


        void Repeat()
        {
            StartCoroutine(SpawnC());
        }


        IEnumerator SpawnC()
        {
            _coinSpawnPoint = Random.Range(-8f, 8f);
            _whereToSpawnCoin = new Vector2(_coinSpawnPoint, 6.44f);
            Instantiate(Coin, _whereToSpawnCoin, Quaternion.identity, Coin.transform.parent = transform);
            yield return new WaitForSeconds(_timeSpawnC);
            Repeat();

        }


        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SpawnC());
        }




    }

}
