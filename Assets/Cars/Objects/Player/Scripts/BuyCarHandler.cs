using Cars.Data;
using Cars.UI;
using UnityEngine;

namespace Cars.Main
{
    public class BuyCarHandler : MonoBehaviour
    {
        public void Buy()
        {
            var player = PlayerDataHandler.Instance;
            var isMyCar = player.CheckOnMyCar();
            if (isMyCar == false)
            {
                var car = ChangeCar.Instance.GetPlayerScriptableObject();
                if (player.Player.Lollipop >= car.Price)
                {
                    player.TakeLollipop(car.Price);
                    player.AddCar(car.Index);
                    GameFileHandler.Instance.Save();
                    LollipopUIDraw.Instance.UpdateLollipop();
                    ChangeCar.Instance.UpdateUI();
                }
            }
        }
    }
}

