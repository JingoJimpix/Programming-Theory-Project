using UnityEngine;

public class BlueSlime : Slime
{
    protected override void Start()
    {
        base.Start();
        speed = 4f;
    }
    protected override void HandleCatch()
    {
        base.HandleCatch();
        GameManager.instance.AddScore(20);
    }
}
