using UnityEngine;
using IJunior.TypedScenes;

public class ChangeSceneAtGame : MonoBehaviour
{
    public static void Change(int indexCar)
    {
        Game.Load(indexCar);
    }
}

