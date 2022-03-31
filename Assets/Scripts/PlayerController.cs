using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private BulletSpawner _bulletSpawner;

    [SerializeField]
    private float _shootingCooldown = 1;

    private float _timeToShoot = 0f;

    [SerializeField]
    private float _speed = 10f;

    void Start()
    {
        _bulletSpawner = gameObject.GetComponentInChildren<BulletSpawner>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Time.time >= _timeToShoot)
            {
                _timeToShoot = Time.time + _shootingCooldown;
                _bulletSpawner.SpawnBullet();
            }       
        }

        var directionX = Input.GetAxis("Horizontal");
        var directionY = Input.GetAxis("Vertical");

        var newDirection = new Vector3(directionX, 0f, directionY).normalized;

        Move(newDirection);
    }

    private void Move(Vector3 direction)
    {
        transform.position += _speed * direction * Time.deltaTime;
    }
}
