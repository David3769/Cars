using IJunior.TypedScenes;
using UnityEngine;

namespace Cars.Scenes
{
    public class StartGameHandler : MonoBehaviour, ISceneLoadHandler<int>
    {
        public void OnSceneLoaded(int indexCar)
        {
            Debug.Log(indexCar);
        }
    }
}
