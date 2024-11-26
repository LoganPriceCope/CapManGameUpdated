using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSceneManager : MonoBehaviour
{
    public ChangeScene changeSceneScript;
    public LevelManager levelManagerScript;

    void Start()
    {
        Invoke("ChangeScene", 2);
    }


    public void ChangeScene()
    {
        SceneManager.LoadScene("Level");
        AudioManager.Instance.PlayMusic("InGameSong");

        //LevelManager.instance.test++;
        
        int level = PlayerPrefs.GetInt("levelNumber");
        PlayerPrefs.SetInt("levelNumber", level+1);

        print("INCREASE LEVEL");

    }
}
