using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    public Text levelText;
    void Update()
    {
        levelText.text = "Level " + PlayerPrefs.GetInt("levelNumber");
    }
}
