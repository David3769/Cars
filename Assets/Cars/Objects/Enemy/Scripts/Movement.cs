﻿using Cars.Game.Player;
using UnityEngine;

namespace Cars.Game.Enemy
{
    public class Movement : MonoBehaviour
    {
        private float _speed;
        private RoadDrive _roadDrive;

        private void Start()
        {
            _roadDrive = FindObjectOfType<RoadDrive>()
                .GetComponent<RoadDrive>();
        }

        private void Update()
        {
            _speed = _roadDrive.Speed + 3f;

            var newPosition = transform.position;
            newPosition.y -= _speed * Time.deltaTime;
            transform.position = newPosition;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.GetComponent<PlayerMove>())
                Debug.Log("Car");
        }
    }
}

