using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] private ControllerUIInGame _controllerUIInGame;

    private Vector3 _mousePosition;

    private void Update()
    {
        if(_controllerUIInGame.isPause == true || _controllerUIInGame.isGameOver == true) return;
        
        _mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (_mousePosition.x < -4.5f || _mousePosition.x > 4.5f || _mousePosition.y > 10f) return;

        transform.position = new Vector2(_mousePosition.x, 0);
    }
}
