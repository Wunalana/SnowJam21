using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileInteractions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION DETECTED");
        Destroy(gameObject);
    }
}
