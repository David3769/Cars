using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cars.Game
{
    public class SpawnObjectsRoad : MonoBehaviour
    {
        [SerializeField] private GameObject[] _objects;
        [SerializeField] private float _minTimeSpawn;
        [SerializeField] private float _maxTimeSpawn;
        [SerializeField] private Transform[] _spawnPoints;

        private void Start()
        {
            StartCoroutine(SpawnObjects());
        }

        private IEnumerator SpawnObjects()
        {
            while (true)
            {
                Instantiate(_objects[Random.Range(0, _objects.Length)],
                    _spawnPoints[Random.Range(0, _spawnPoints.Length)].position,
                    Quaternion.identity);
                yield return new WaitForSeconds(Random.Range(_minTimeSpawn, _maxTimeSpawn));
            }
        }
    }
}