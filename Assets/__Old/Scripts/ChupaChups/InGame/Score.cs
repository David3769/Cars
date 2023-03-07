using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score;

    [Header("Text")]
    [SerializeField] private Text _scoreUI;
    [Header("Scripts")]
    [SerializeField] private ControllerUIInGame _controllerUIInGame;
    [SerializeField] private RoadDrive _roadDrive; 

    private void Update()
    {
        if(_controllerUIInGame.isPause == true || _controllerUIInGame.isGameOver == true) return;

        score = UpdateScore(score);
        _scoreUI.text = "" + score;
    }

    private float UpdateScore(float score)
    {
        score += 1 + _roadDrive.speed * Time.deltaTime;
        return Mathf.Round(score);
    }
}
