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
        GameManager.instance.AddScore(20);
        Destroy(gameObject);
    }
}
