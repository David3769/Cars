using UnityEngine;
using UnityEngine.UI;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField] private float _speed = 0;

    private float _position = 0;
    private RawImage _image;

    private void Start()
    {
        _image = GetComponent<RawImage>();
    }

    private void Update()
    {
        _position += _speed * Time.deltaTime;
        if (_position > 1.0f)
            _position -= 1.0f;
        _image.uvRect = new Rect(_position, 0, 1, 1);
    }
}
