using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10f;

    [SerializeField]
    private int _lifeTime = 2;

    private float _timeToGetDestroyed;

    private Vector3 _direction = new Vector3(0f,0f,1f);

    private void Start()
    {
        _timeToGetDestroyed = Time.time + _lifeTime;
    }

    void Update()
    {
        transform.position += _direction * _speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale *= 2f;
        }

        if(Time.time >= _timeToGetDestroyed)
        {
            Destroy(gameObject);
        }
    }
}
