﻿using UnityEngine;

namespace Cars.Game
{
    public class CreateBoost : MonoBehaviour
    {
        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private GameObject[] _prefabs;
        [SerializeField] private float _createTime;

        private void Start ()
        {
            Invoke(nameof(Create), _createTime);
        }

        private void Create()
        {
            Instantiate(_prefabs[Random.Range(0, _prefabs.Length)],
                        _spawnPoints[Random.Range(0, _spawnPoints.Length)].position,
                        Quaternion.identity);

            Invoke(nameof(Create), _createTime);
        }
    }
}