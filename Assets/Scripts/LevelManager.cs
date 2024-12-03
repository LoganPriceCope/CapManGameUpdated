
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class LevelManager : MonoBehaviour
{
  //  int highscoreMM;
  //  public Text highScoreTextMM;
    public float levels;
    public int lives = 3;
    public static LevelManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            //setup variables for first time

            levels = 0;

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
       // highscoreMM = PlayerPrefs.GetInt("highScore");
       // highScoreTextMM.text = "High Score: " + highscoreMM;
        levels = PlayerPrefs.GetInt("levelNumber", 1);
       // levelText.text = "Level " + levelLevel;
        print("level number is " + levels);
        PlayerPrefs.SetInt("lives", lives);
        CheckLives();
    }

    public void ChangeToLevel()
    {
        SceneManager.LoadScene("Level");
        AudioManager.Instance.PlayMusic("InGameSong");
    }

    public void ChangeToTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
        AudioManager.Instance.PlayMusic("TitleScreenSong");
        lives = 3;
    }

    public void ChangeToLoadingScreen()
    {
        SceneManager.LoadScene("LoadingScene");
        AudioManager.Instance.PlayMusic("TitleScreenSong");
    }

    public void CheckLives()
    {
    }
}
