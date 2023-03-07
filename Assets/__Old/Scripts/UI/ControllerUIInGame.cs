using UnityEngine;
using UnityEngine.UI;

public class ControllerUIInGame : MonoBehaviour
{
    public bool isPause;
    public bool isGameOver;

    [Header("GameObject")]
    [SerializeField] private GameObject _panelPause;
    [SerializeField] private GameObject _panelGameOver;
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _scoreText;
    [SerializeField] private GameObject _chupaChupsScore;
    [Header("Text")]
    [SerializeField] private Text _scoreGameOver;
    [SerializeField] private Text _chupaChupsGameOver;
    [Header("Scripts")]
    [SerializeField] private Score _score;
    [SerializeField] private UpdateChupaChupsInGame _updateChupaChupsInGame;

    private void Awake()
    {
        isPause = false;
        isGameOver = false;
    }

    private void Update()
    {
        if(isPause != true) 
        {
            _panelPause.SetActive(false);
        }
        if(isGameOver != true)
        {
            _panelGameOver.SetActive(false);
        }
    }

    public void SetPause()
    {
        _panelPause.SetActive(true);
        _pauseButton.SetActive(false);
        isPause = true;

        if(_panelGameOver.activeSelf)
        {
            _panelGameOver.SetActive(false);
        }
    }

    public void SetPlay()
    {
        _panelPause.SetActive(false);
        _pauseButton.SetActive(true);
        isPause = false;
    }

    public void SetGameOver()
    {
        _panelGameOver.SetActive(true);
        _pauseButton.SetActive(false);
        _scoreText.SetActive(false);
        _chupaChupsScore.SetActive(false);
        isGameOver = true;

        _scoreGameOver.text = "Счёт: " + _score.score;
        _chupaChupsGameOver.text = "" + (_updateChupaChupsInGame.countChupaChups - Data.chupaChups);

        Data.chupaChups = _updateChupaChupsInGame.countChupaChups;
    }
}
