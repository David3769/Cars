using UnityEngine;
using UnityEngine.UI;

public class UpdateChupaChupsUI : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] private Text _chupaChupsUI;

    private void Update()
    {
        _chupaChupsUI.text = "" + Data.chupaChups;
    }
}
