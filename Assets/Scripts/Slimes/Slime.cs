using UnityEngine;

public class Slime : MonoBehaviour
{
    [SerializeField] protected float speed = 3f;
    protected Player player;

    protected virtual void Start()
    {
        player = FindFirstObjectByType<Player>();
    }

    protected virtual void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HandleCatch();
        }
        if (other.CompareTag("Sensor"))
        {
            HandleMiss();
        }
    }

    protected virtual void HandleCatch()
    {
        GameManager.instance.AddScore(10);
        Destroy(gameObject);
    }

    protected virtual void HandleMiss()
    {
        player.TakeDamage();
        Destroy(gameObject);
        Debug.Log("Slime missed D:");
    }

}
