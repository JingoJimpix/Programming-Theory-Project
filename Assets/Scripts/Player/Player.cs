using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] protected int lives = 3;

    public virtual void TakeDamage()
    {
        lives--;
        if (lives <= 0)
        {
            Die();
        }
    }

    public virtual void Heal()
    {
        if (lives < 3)
        {
            lives++;
            Debug.Log("1+ life");
        }
    }

     public virtual void Die()
    {
        GameManager.instance.GameOver();
    }

    public int GetLives()
    {
        return lives;
    }
}
