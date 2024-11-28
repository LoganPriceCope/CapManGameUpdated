using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class SpawnCherry : MonoBehaviour
{
    public bool cherryExist = false;

    public Vector3 pos;

    public int digit;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(cherryExist == false)
        {
            Invoke("GenerateCherry", 0.3f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreSystem.instance.AddCherryPoints();
            cherryExist = false;
            Destroy(transform.gameObject);
        }
    }

    
    public void GenerateCherry()
    {
        digit = Random.Range(0, 20000);
        if (digit <= 1)
        {
            cherryExist = true;
            transform.position = pos;
            print("True");
        }
        else
        {
            print("False");
        }
    }
}