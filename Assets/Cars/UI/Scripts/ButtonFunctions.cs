using UnityEngine;
using System.Linq;

namespace Cars.UI
{
    public class ButtonFunctions : MonoBehaviour
    {
        [SerializeField] private GameObject[] _screens;
        [SerializeField] private ChangeCar _changeCar;

        public void OpenScreen(GameObject screenIsOpen)
        {
            if (_screens.Contains(screenIsOpen))
            {
                CloseScreen(_screens, screenIsOpen);
                screenIsOpen.SetActive(true);
            }
            else
                Debug.Log($"Требуется добавить {screenIsOpen} в массив _screens класса ButtonFunctions.");
        }

        private void CloseScreen(GameObject[] screens, GameObject screenIsNotClosing)
        {
            foreach (var screen in screens)
            {
                if (screen == screenIsNotClosing)
                    continue;

                screen.SetActive(false);
            }
        }

        public void ChangeCarImage(int change)
        {
            _changeCar.Change(change);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
    }
}

