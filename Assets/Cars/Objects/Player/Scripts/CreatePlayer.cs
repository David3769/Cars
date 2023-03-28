using IJunior.TypedScenes;
using UnityEngine;

namespace Cars.Game.Player
{
    public class CreatePlayer : MonoBehaviour, ISceneLoadHandler<int>
    {
        [SerializeField] private GameObject _car;
        [SerializeField] private Transform _spawn;
        [SerializeField] private Sprite[] _sprites;

        private IGameOver game = new GameOver();

        public void OnSceneLoaded(int index)
        {
            if (FindObjectOfType<PlayerMove>())
                Destroy(FindObjectOfType<PlayerMove>().gameObject);

            CreateCar(index);
            SetStateGame();
        }

        private void CreateCar(int index)
        {
            if (_car != null)
            {
                GameObject car = Instantiate(_car, _spawn.transform.position, Quaternion.identity);

                var sprite = car.GetComponent<SpriteRenderer>();
                sprite.sprite = _sprites[index];

                if (index == 3)
                {
                    car.GetComponent<Transform>().localScale = new Vector2(1.2f, 1.2f);
                }
            }
        }

        private void SetStateGame()
        {
            game.State = States.Game;
        }
    }
}

