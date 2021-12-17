using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileInteractions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLISION DETECTED");
        if (collision.gameObject.tag == "Player" ||
            collision.gameObject.tag == "Floor")
            Destroy(gameObject);

    }
}
