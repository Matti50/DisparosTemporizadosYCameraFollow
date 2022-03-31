using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform _player;

    private Vector3 _cameraOffset;

    private const float delay = 10f;

    void Start()
    {
        _cameraOffset = transform.position - _player.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _player.position + _cameraOffset, delay * Time.deltaTime);
    }
}
