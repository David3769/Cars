using UnityEngine;
using IJunior.TypedScenes;

namespace Cars.Scenes
{
    public class ChangeSceneAtGame : MonoBehaviour
    {
        public static void Change(int indexCar)
        {
            Game.Load(indexCar);
        }
    }
}

