using UnityEngine;

public class RedSlime : Slime
{
    protected override void HandleCatch()
    {
        player.TakeDamage();
        Destroy(gameObject);
    }
}
