using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using IJunior.TypedScenes;

public class ButtonClick : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] private ControllerUIInGame _controllerUIInGame;
    [SerializeField] private InfoText _infoText;
    [Header("GameObject")]
    [SerializeField] private GameObject _buyCar;
    [SerializeField] private GameObject _error;
    [SerializeField] private GameObject _info;
    [Header("Text")]
    [SerializeField] private Text _priceBuyCar;
    [SerializeField] private Text _price;
    [SerializeField] private Text _errorLog;
    [SerializeField] private Text _infoLog;

    public void Pause()
    {
        _controllerUIInGame.SetPause();
        Time.timeScale = 0;
    }

    public void PlayInGame()
    {
        _controllerUIInGame.SetPlay();
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void BuyCar()
    {
        CloseAllWindow();

        if (Data.indexMyCar.Contains(ChangeImage.indexImage) == true)
        {
            return;
        }
        else
        {
            _buyCar.SetActive(true);
            _priceBuyCar.text = "Купить за: " + Data.priceCar[ChangeImage.indexImage];
        }
    }

    public void ConfirmBuyCar()
    {
        if(Data.chupaChups < Data.priceCar[ChangeImage.indexImage])
        {
            _error.SetActive(true);
            _errorLog.text = "Недостаточно чупа-чупсов.";

            _buyCar.SetActive(false);
        }
        else
        {
            Data.chupaChups -= Data.priceCar[ChangeImage.indexImage];
            Data.indexMyCar.Add(ChangeImage.indexImage);

            _price.text = "Куплено";
            ChangeImage.priceCar = "Куплено";

            CloseAllWindow();
        }
    }

    public void ShowWhatIsNeededToPurchaseTheRoad()
    {
        CloseAllWindow();

        if(Data.countRebicth >= Data.rebirthToOpenRoad[ChangeImage.indexImage])
        {
            return;
        }
        else
        {
            _error.SetActive(true);
            _errorLog.text = $"Для доступа к этой дороге требуется сделать " +
                $"{Data.rebirthToOpenRoad[ChangeImage.indexImage]} ребитхов.";
        }
    }

    public void CloseAllWindow()
    {
        _buyCar.SetActive(false);
        _error.SetActive(false);
        _info.SetActive(false);
    }

    public void OpenInfoCar()
    {
        CloseAllWindow();

        _info.SetActive(true);
        _infoLog.text = _infoText.GiveInfo(ChangeImage.indexImage, "car");
    }

    public void GoToMain()
    {
        //Main.Load();
    }
}
