using UnityEngine;

public class PinkSlime : Slime
{
    protected override void HandleCatch()
    {
        base.HandleCatch();
        player.Heal();
    }

    protected override void HandleMiss()
    {
        Debug.Log("Heal missed :(");
        Destroy(gameObject);
    }
}
