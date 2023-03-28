using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    enum NameScene
    {
        Main,
        Game
    }
    public static bool IsCurrentNameScene(string sceneName)
    {
        return sceneName == GetCurrentSceneName();
    }

    private static string GetCurrentSceneName()
    {
        return SceneManager.GetActiveScene().name;
    }
}
