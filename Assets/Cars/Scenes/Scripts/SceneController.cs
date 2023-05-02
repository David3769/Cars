using UnityEngine;
using UnityEngine.SceneManagement;
using Cars.Data;

namespace Cars.Scene
{
    public class SceneController : MonoBehaviour
    {
        enum Scenes
        {
            Main,
            Game
        }

        public void LoadScene(int indexScene)
        {
            if (indexScene == (int)Scenes.Game)
            {
                if (PlayerDataHandler.Instance.CheckOnMyCar())
                    SceneManager.LoadScene(indexScene);
            }
            else
                SceneManager.LoadScene(indexScene);
        }
    }
}
