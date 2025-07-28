using UnityEngine;

public class BlueSlime : Slime
{
    protected override void Start()
    {
        base.Start();
        speed = 5f;
    }
    protected override void HandleCatch()
    {
        base.HandleCatch();
        GameManager.instance.AddScore(20);
    }
}
