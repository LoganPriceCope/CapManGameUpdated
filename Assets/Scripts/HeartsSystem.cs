using UnityEngine;
using UnityEngine.UI;

public class HeartsSystem : MonoBehaviour
{
    int lives = LevelManager.instance.lives;
    public static HeartsSystem heartSystem;

    public Text livesText;

    public GameObject heartOne;
    public GameObject heartTwo;
    public GameObject heartThree;

    void Update()
    {
        livesText.text = "Lives: "+lives;
        if (lives == 3)
        {
            heartOne.GetComponent<Image>().color = Color.white;
            heartTwo.GetComponent<Image>().color = Color.white;
            heartThree.GetComponent<Image>().color = Color.white;
        }
        else if (lives == 2)
        {
            heartThree.GetComponent<Image>().color = Color.black;
        }
        else if (lives == 1)
        {
            heartTwo.GetComponent<Image>().color = Color.black;
            heartThree.GetComponent<Image>().color = Color.black;
        }
        else if (lives == 0)
        {
            LevelManager.instance.ChangeToTitleScreen();
        }
    }
}
