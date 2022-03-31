using UnityEngine;

public class CameraActivationController : MonoBehaviour
{

    [SerializeField]
    private Camera _mainCamera;

    [SerializeField]
    private Camera _skyCamera;

    private void Awake()
    {
        _mainCamera.gameObject.SetActive(true);
        _skyCamera.gameObject.SetActive(true);
    }

    void Start()
    {
        _skyCamera.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            _mainCamera.gameObject.SetActive(!_mainCamera.gameObject.activeSelf);
            _skyCamera.gameObject.SetActive(!_skyCamera.gameObject.activeSelf);
        }
    }
}
