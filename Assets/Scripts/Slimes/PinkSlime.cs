using UnityEngine;

public class PinkSlime : Slime
{
    protected override void HandleCatch()
    {
        player.Heal();
        Destroy(gameObject);
    }
}
