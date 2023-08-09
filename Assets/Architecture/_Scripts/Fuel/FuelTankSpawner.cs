using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceTrip
{
    public class FuelTankSpawner : MonoBehaviour
    {
        [SerializeField][Range(.1f, 5f)] private float _timeSpawnFuelTank;
        [SerializeField] private GameObject _fuelTank;
        [SerializeField] private float _fuelTankSpawnPoint;
        [SerializeField] private Vector2 _whereToSpawnFuelTank;
        private float FuelTankSpawnPoint => _fuelTankSpawnPoint;
        private GameObject Fuel => _fuelTank;
        private float TimeSpawnFuelTank => _timeSpawnFuelTank;
        private Vector2 WhereToSpawnFuelTank => _whereToSpawnFuelTank;


        void Repeat()
        {
            StartCoroutine(SpawnFuelTank());
        }


        IEnumerator SpawnFuelTank()
        {
            _fuelTankSpawnPoint = Random.Range(-8f, 8f);
            _whereToSpawnFuelTank = new Vector2(_fuelTankSpawnPoint, 6.44f);
            Instantiate(Fuel, _whereToSpawnFuelTank, Quaternion.identity, Fuel.transform.parent = transform);
            yield return new WaitForSeconds(_timeSpawnFuelTank);
            Repeat();

        }


        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SpawnFuelTank());
        }
    }
}
