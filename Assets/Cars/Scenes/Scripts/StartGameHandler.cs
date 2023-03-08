using IJunior.TypedScenes;
using UnityEngine;

public class StartGameHandler : MonoBehaviour, ISceneLoadHandler<int>
{
    public void OnSceneLoaded(int indexCar)
    {
        Debug.Log(indexCar);
    }
}
