using UnityEngine;

public class GreenSlime : Slime
{
    protected override void HandleCatch()
    {
        base.HandleCatch();
        GameManager.instance.AddScore(10);
    }

}
