using UnityEngine;

public class Slime : MonoBehaviour
{
    //Inheritance: Slime parent class that feeds the rest of slime child classes
    //Polymorphism: Slime childs all behave differently based on method overriding
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

//Abstraction: Complext method, handled in the update via a simpler method
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
//Abstraction: Complext method, handled in the update via a simpler method
    protected virtual void HandleCatch()
    {
        Destroy(gameObject);
        Debug.Log("Slime caught :D");
    }
//Abstraction: Complext method, handled in the update via a simpler method
    protected virtual void HandleMiss()
    {
        player.TakeDamage();
        Destroy(gameObject);
        Debug.Log("Slime missed D:");
    }

}
