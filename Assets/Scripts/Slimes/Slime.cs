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
        else if (other.CompareTag("Sensor"))
        {
            HandleMiss();
        }
    }

    protected virtual void HandleCatch()
    {
        Destroy(gameObject);
        Debug.Log("Slime caught :D");
    }

    protected virtual void HandleMiss()
    {
        //player.TakeDamage();
        Destroy(gameObject);
        Debug.Log("Slime missed D:");
    }

}
