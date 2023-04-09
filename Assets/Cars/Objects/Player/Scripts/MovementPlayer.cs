using UnityEngine;
using UnityEngine.UIElements;

namespace Cars.Game
{
    public class MovementPlayer : MonoBehaviour
    {
        private void Update()
        {
            if (StateManager.GetCurrentState() == States.Game)
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
                var touch = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                if (IsPlayerInBoundaries(touch))
                    return;
                transform.position = SetPosition(touch);
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
            if (position.x < -1.5f || position.x > 1.5f)
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

