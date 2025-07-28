using UnityEngine;

public class PurpleSlime : Slime
{

    protected override void Start()
    {
        speed = 1.8f;
    }

    protected override void HandleCatch()
    {
        GameManager.instance.AddScore(5);
        Destroy(gameObject);
    }
}
