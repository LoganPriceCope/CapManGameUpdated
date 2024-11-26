using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public void ChangeToTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
        AudioManager.Instance.PlayMusic("TitleScreenSong");
        LevelManager.instance.lives = 3;
    }
}
