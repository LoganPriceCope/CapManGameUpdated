using UnityEngine;
//using UnityEngine.SocialPlatforms.Impl;

public class PortalPart : MonoBehaviour
{
    public Vector3 targetPos;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ghost") || other.gameObject.CompareTag("Player"))
        {
            other.transform.position = targetPos;
        }
    }
}
