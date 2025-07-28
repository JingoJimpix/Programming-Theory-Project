using UnityEngine;

public class PurpleSlime : Slime
{

    protected override void Start()
    {
        base.Start();
        speed = 1.8f;
    }

    protected override void HandleCatch()
    {
        base.HandleCatch();
        GameManager.instance.AddScore(5);
    }
}
