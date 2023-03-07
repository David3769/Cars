using UnityEngine;

namespace Cars.UI
{
    public class ChangeCar : MonoBehaviour
    {
        [SerializeField] private ScriptableObject[] _scriptableObjects;
        //[SerializeField] private ScreenSelection _screenSelection;

        private int _currentIndex;

        public void ChangeImageCar(int change)
        {
            _currentIndex += change;

            /*if (_currentIndex < 0)
                _currentIndex = _scriptableObjectsCar.Length - 1;
            else if (_currentIndex > _scriptableObjectsCar.Length - 1)
                _currentIndex = 0;

            if (_screenSelection != null)
                _screenSelection.Display((Car)_scriptableObjectsCar[_currentIndex]);*/
        }
    }
}