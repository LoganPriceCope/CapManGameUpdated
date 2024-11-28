using UnityEngine;
using UnityEngine.UI;

public class SpawnBoostScript : MonoBehaviour
{
    public bool cherryExist = true;
    public Vector3 pos;

    public GameObject boostUIIcon;
    public Text boostText;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (cherryExist == true)
            {
                boostUIIcon.SetActive(true);
                PlayerMovement.instance.boost = 1.5f;
                cherryExist = false;
                transform.position = pos;
                Invoke("ResetSpeed", 3f);
            }
        }
    }

    public void ResetSpeed()
    {
        boostUIIcon.SetActive(false);
        PlayerMovement.instance.boost = 1f;
    }
}