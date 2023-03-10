using UnityEngine;

enum NameCategory
{
    Lollipop
}

namespace Cars.Data
{
    public class PlayerData : MonoBehaviour
    {
        public static void SaveLollipop(int count)
        {
            PlayerPrefs.SetInt(NameCategory.Lollipop.ToString(), count);
        }

        public static int LoadLollipop()
        {
            var lollipopLoad = PlayerPrefs.GetInt(NameCategory.Lollipop.ToString());
            return lollipopLoad;
        }
    }
}

