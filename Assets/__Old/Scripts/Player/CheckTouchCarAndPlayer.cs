using UnityEngine;

public class CheckTouchCarAndPlayer : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] private ControllerUIInGame _controllerUIInGame;
    [SerializeField] private UpdateChupaChupsInGame _updateChupaChupsInGame;
    [SerializeField] private ChupaChupsMove _chupaChupsMove;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            Time.timeScale = 0;
            _controllerUIInGame.SetGameOver();
        }
        else if (collision.gameObject.CompareTag("ChupaChups"))
        {
            _updateChupaChupsInGame.AddChupaChups(1);
            _chupaChupsMove.ResetChupaChups();
        }
    }
}
