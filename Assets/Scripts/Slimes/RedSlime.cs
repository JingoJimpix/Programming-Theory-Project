using UnityEngine;

public class RedSlime : Slime
{
    protected override void HandleCatch()
    {
        player.TakeDamage();
        Destroy(gameObject);
    }

    protected override void HandleMiss()
    {
        Debug.Log("Hamrful slime avoided :)");
        Destroy(gameObject);
    }
}
