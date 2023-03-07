using UnityEngine;
using UnityEngine.UI;

public class UpdateChupaChupsInGame : MonoBehaviour
{
    public int countChupaChups = 0;
    
    [Header("Text")]
    [SerializeField] private Text _chupaChupsUI;

    public void Start()
    {
        _chupaChupsUI.text = "" + Data.chupaChups;
        countChupaChups = Data.chupaChups;
    }

    public void AddChupaChups(int add)
    {
        countChupaChups += add;
        _chupaChupsUI.text = "" + countChupaChups;
    }
}
