using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI lives;
    [SerializeField] private TextMeshProUGUI finalScore;

    void Update()
    {
        score.text = "Score: " + GameManager.instance.GetScore();
        lives.text = "Lives " + FindAnyObjectByType<Player>().GetLives();
    }

    public void ShowFinalScore()
    {
        finalScore.text = "Final score: " + GameManager.instance.GetScore(); 
    }
}
