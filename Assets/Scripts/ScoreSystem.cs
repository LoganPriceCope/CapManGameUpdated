using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public int highScore;
    public Text highScoreText;

    public static ScoreSystem instance;

    public void Awake()
    {
        PlayerPrefs.GetInt("highScore");
        PlayerPrefs.GetInt("score");
        PlayerPrefs.GetInt("lives");
    }
    public void Start()
    {
        score = PlayerPrefs.GetInt("score");
    }
    public void Update()
    {
        CheckForNextLevel();
        scoreText.text = "Score: " + score;
        if(score >= highScore)
        {
            highScore = score;
            highScoreText.text = $"High Score: {PlayerPrefs.GetInt("highScore")}";
            if(score >= PlayerPrefs.GetInt("highScore", 0))
            {
                setHighScore();
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PointOrb"))
        {
            PlayerPrefs.SetInt("score", score++);
            Destroy(other.gameObject);
            AudioManager.Instance.PlaySFX("Powerup");
        }
    }
    public void setHighScore()
    {
        PlayerPrefs.SetInt("highScore", highScore);
    }

    public void CheckForNextLevel()
    {
        // Check if score is 10 in level
        float scoreSystem = score / LevelManager.instance.levels;
        if (scoreSystem >= 142)
        {
            LevelManager.instance.ChangeToLoadingScreen();
        }
    }
}
