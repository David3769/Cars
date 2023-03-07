using UnityEngine;

public class InfoText : MonoBehaviour
{
    private string[] _infoCar = {
        "Простая машинка. Доступна в начале игры.",
        "На вид простая машина, но с шансом 10% может проехать сквозь машину.",
        "Гоночный спорт кар. х2 чупики!",
        "Крепкий орешек... Может 3 раза столкнуться и не сломаться!!",
        "Самая дорогая машина в игре. К этому ещё и с более высоким разрешением. Плюс х4 чупиков."
    };
    private string[] _infoRoad = {
        "",
        "",
        "",
        "",
        ""
    };

    public string GiveInfo(int index, string nameCategory)
    {
        string returnText = "";

        switch (nameCategory)
        {
            case "car":
                returnText = _infoCar[index];
                break;

            case "road":
                break;

            default:
                Debug.Log("Неизвестная категория! $Script - InfoText$");
                break;
        }

        return returnText;
    }
}
