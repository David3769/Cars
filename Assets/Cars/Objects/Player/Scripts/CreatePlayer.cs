using Cars.Data;
using UnityEngine;

namespace Cars.Game
{
    public class CreatePlayer : MonoBehaviour
    {
        [SerializeField] private GameObject _car;
        [SerializeField] private Transform _spawn;
        [SerializeField] private Sprite[] _sprites;

        private void Awake()
        {
            if (FindObjectOfType<MovementPlayer>())
                Destroy(FindObjectOfType<MovementPlayer>().gameObject);
            var index = PlayerDataHandler.Instance.GetSelectionIndexCar();
            CreateCar(index);
        }

        private void CreateCar(int index)
        {
            if (_car != null)
            {
                GameObject car = Instantiate(_car, _spawn.transform.position, Quaternion.identity);
                var sprite = car.GetComponent<SpriteRenderer>();
                sprite.sprite = _sprites[index];
            }
        }
    }
}

