using UnityEngine;

public class ControllerUIInMenu : MonoBehaviour
{
    public static string nameCategory;

    [Header("GameObject")]
    [SerializeField] private GameObject _CStart;
    [SerializeField] private GameObject _CSelectionCar;   
    [SerializeField] private GameObject _CSelectionRoad;
    [SerializeField] private GameObject _CSettings;

    private void Awake()
    {
        nameCategory = "none";
    }

    private void Update()
    {
        switch (nameCategory)
        {
            case "none":
                TurnOffCanvases();
                _CStart.SetActive(true);
                break;
            case "selectionCar":
                TurnOffCanvases();
                _CSelectionCar.SetActive(true);
                break;
            case "selectionRoad":
                TurnOffCanvases();
                _CSelectionRoad.SetActive(true);
                break;
            case "settings":
                TurnOffCanvases();
                _CSettings.SetActive(true);
                break;
            default:
                Debug.Log("Неверный канвас");
                TurnOffCanvases();
                _CStart.SetActive(true);
                break;
        }
    }

    private void TurnOffCanvases()
    {
        _CStart.SetActive(false);
        _CSelectionCar.SetActive(false);
        _CSelectionRoad.SetActive(false);
        _CSettings.SetActive(false);
    }
}
