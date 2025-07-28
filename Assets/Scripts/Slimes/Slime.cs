using UnityEngine;

public class Slime : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    protected virtual void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
         transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HandleCatch();
        }
    }

    protected virtual void HandleCatch()
    {
        GameManager.instance.AddScore(10);
        Destroy(gameObject);
    }

}
