using UnityEngine;

namespace Cars.Game
{
    public class CreateBoost : MonoBehaviour
    {
        public static CreateBoost Instance { get; private set; }

        public bool IsCreate = false;

        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private GameObject[] _prefabs;
        [SerializeField] private float T;
        
        public float _createTime;

        private void Start()
        {
            if (Instance == null)
                Instance = this;
        }

        public void SetStartCreate()
        {
            IsCreate = true;
            Create();
        }

        private void Create()
        {
            if (GameController.Instance.IsGame == true)
                Instantiate(_prefabs[Random.Range(0, _prefabs.Length)],
                            _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, 
                            Quaternion.identity);
            UpdateCreateTime();
            Invoke(nameof(Create), _createTime);
        }

        private void UpdateCreateTime()
        {
            _createTime = RoadDrive.Instance.Speed * T;
        }
    }
}