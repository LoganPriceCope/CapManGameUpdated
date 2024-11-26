using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class GhostScript : MonoBehaviour
{
    public NavMeshAgent nav;
    public GameObject player;
    public float speed;
    public float speedChange;
    void Update()
    {
        speedChange = LevelManager.instance.levels / 15f + 1;
        nav.destination = player.transform.position;
        nav.speed = speed * speedChange;
    }

    public void OnTriggerEnter(Collider other)
    {
        print("W");
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level");
            AudioManager.Instance.PlaySFX("Death");
            LevelManager.instance.lives--;
        }
    }
}
