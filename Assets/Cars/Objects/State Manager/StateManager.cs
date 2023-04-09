using UnityEngine;

namespace Cars.Game
{
    public class StateManager : MonoBehaviour
    {
        public static States CurrentState;

        private void Start()
        {
            CurrentState = States.Game;
        }

        public static States GetCurrentState()
        {
            return CurrentState;
        }
        public static void SetGame()
        {
            CurrentState = States.Game;
            Time.timeScale = 1f;
        }

        public static void SetPause()
        {
            CurrentState = States.Pause;
            Time.timeScale = 0f;
        }

        public static void SetGameOver()
        {
            CurrentState = States.GameOver;
            Time.timeScale = 0f;
        }
    }
}