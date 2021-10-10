using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private GameObject _cam;
    [SerializeField] private float _parallaxEffect;

    [SerializeField] private SpriteRenderer _renderer;

    private float _lenght;
    private float _startPos;

    private void Start()
    {
        _startPos = transform.position.x;
        _lenght = _renderer.bounds.size.x;
    }

    private void Update()
    {
        float temp = (_cam.transform.position.x * (1 - _parallaxEffect));
        float dist = (_cam.transform.position.x * _parallaxEffect);

        transform.position = new Vector3(_startPos + dist, transform.position.y, transform.position.z);

        if (temp > _startPos + _lenght)
            _startPos += _lenght;
        else if (temp < _startPos - _lenght)
            _startPos -= _lenght;
    }
}
