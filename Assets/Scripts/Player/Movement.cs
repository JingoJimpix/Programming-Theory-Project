using UnityEngine;

public class Movement : Player
{
    [SerializeField] private float moveSpeed = 7f;

    void Update()
    {
        HandleMove();
    }

//Abstraction: Complext method, handled in the update via a simpler method
    void HandleMove()
    {
        float input = Input.GetAxisRaw("Horizontal");
        Vector3 newPosition = transform.position + Vector3.right * input * moveSpeed * Time.deltaTime;

        float bounds = Mathf.Clamp(newPosition.x, -8f, 8f);
        transform.position = new Vector3(bounds, transform.position.y, transform.position.z);
    }
}
