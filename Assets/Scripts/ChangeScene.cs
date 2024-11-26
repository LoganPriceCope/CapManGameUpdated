using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static ChangeScene instance;
    public void ChangeToLevel()
    {
        SceneManager.LoadScene("Level");
        AudioManager.Instance.PlayMusic("InGameSong");
    }

    public void ChangeToTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
        AudioManager.Instance.PlayMusic("TitleScreenSong");
        PlayerPrefs.SetInt("levelNumber", 1);
    }

    public void ChangeToLoadingScreen()
    {
        SceneManager.LoadScene("LoadingScene");
        AudioManager.Instance.PlayMusic("TitleScreenSong");
    }
}
