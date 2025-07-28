using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected int lives = 3;

    public virtual void LoseLife()
    {
        lives--;
        if (lives <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        //GameManager.Instance.GameOver();
    }
}
