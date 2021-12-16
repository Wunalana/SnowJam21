using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        this.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
    }
}
