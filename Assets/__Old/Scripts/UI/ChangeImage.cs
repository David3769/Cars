using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public static int indexImage = 0;
    public static string priceCar = "";

    [Header("Sprite")]
    [SerializeField] private Sprite[] _cars;
    [SerializeField] private Sprite[] _roads;
    [Header("GameObject")] 
    [SerializeField] private GameObject[] _category;
    [Header("Text")]
    [SerializeField] private Text _price;
    [Header("Image")]
    [SerializeField] private Image _image;
    [Header("Script")]
    [SerializeField] private ButtonClick _buttonClick;

    private void Start()
    {
        var category = CheckCategory();
        CheckOnMy(category);
    }

    public void ChangeUp()
    {
        _buttonClick.CloseAllWindow();

        var category = CheckCategory();
        if(category == -1)
        {
            Debug.Log("Неизвестная категория...");
            return;
        }

        indexImage++;

        switch (category)
        {
            case 0: // cars
                if(indexImage >= _cars.Length)
                {
                    indexImage = 0;
                }

                _image.sprite = _cars[indexImage];
                break;
            case 1: // roads
                if(indexImage >= _roads.Length)
                {
                    indexImage = 0;
                }

                _image.sprite = _roads[indexImage];
                break;
        }

        CheckOnMy(category);
    }

    public void ChangeDown()
    {
        _buttonClick.CloseAllWindow();

        var category = CheckCategory();
        if(category == -1)
        {
            Debug.Log("Неизвестная категория...");
            return;
        }

        indexImage--;

        switch (category)
        {
            case 0: // cars
                if(indexImage < 0)
                {
                    indexImage = _cars.Length - 1;
                }

                _image.sprite = _cars[indexImage];
                break;
            case 1: // roads
                if(indexImage < 0)
                {
                    indexImage = _roads.Length - 1;
                }

                _image.sprite = _roads[indexImage];
                break;
        }

        CheckOnMy(category);
    }

    private int CheckCategory()
    {
        for(int i = 0; i < _category.Length; i++)
        {
            if(_category[i].gameObject.activeInHierarchy)
            {
                return i;
            }
        }

        return -1;
    }

    private bool CheckOnMy(int category)
    {
        bool returnBool = false;

        switch (category)
        {
            case 0:
                if(Data.indexMyCar.Contains(indexImage))
                {
                    returnBool = true;
                    _price.text = "Куплено";
                    priceCar = _price.text;
                }
                else 
                {
                    returnBool = false;
                    SetPrice(category);
                }
                break;
            case 1:
                if (Data.countRebicth >= Data.rebirthToOpenRoad[indexImage])
                {
                    returnBool = true;
                    _price.text = "Доступно";
                }
                else
                {
                    returnBool = false;
                    SetPrice(category);
                }
                break;
        }

        return returnBool;
    }

    private void SetPrice(int category)
    {
        switch (category)
        {
            case 0:
                _price.text = "" + Data.priceCar[indexImage];
                priceCar = _price.text;
                break;
            case 1:
                _price.text = "" + Data.rebirthToOpenRoad[indexImage];
                break;
        }
    }
}
