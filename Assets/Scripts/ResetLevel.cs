using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.SetInt("levelNumber", 1);
        PlayerPrefs.SetInt("score", 0);
    }
}
