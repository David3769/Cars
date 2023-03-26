using UnityEngine;

namespace Cars.Game.Player
{
    public class PlayerMove : MonoBehaviour
    {
        private GameOver _states;
        private Vector2 _touch;

        private void Start()
        {
            if (_states == null)
                _states = FindObjectOfType<GameOver>().GetComponent<GameOver>();
        }

        private void Update()
        {
            if (_states.State == States.Game)
                Movement();
        }

        private void Movement()
        {
            if (Application.isMobilePlatform)
                MoveMobile();
            else if (Application.isEditor)
                MoveEditor();
        }

        private void MoveMobile()
        {
            if (Input.touchCount > 0)
            {
                _touch = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                transform.position = SetPosition(_touch);
            }
        }

        private void MoveEditor()
        {
            var position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (IsPlayerInBoundaries(position))
                return;

            transform.position = SetPosition(position);
        }

        private bool IsPlayerInBoundaries(Vector2 position)
        {
            if (position.x < -2 || position.x > 2)
                return true;
            else if (position.y < -4 || position.y > 0)
                return true;
            else
                return false;
        }

        private Vector2 SetPosition(Vector2 vector)
        {
            return new Vector2(vector.x, vector.y);
        }
    }
}

