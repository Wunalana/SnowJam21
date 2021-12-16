using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public int score;
    public float speed = 3f;
    public bool isFrozen;
    private int freezeTime = 3;


    void start()
    {
        score = 0;
        isFrozen = false;
    }

    void Update()
    {
        if (isFrozen != true)
        {
            this.transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
        }
        else
        {
            StartCoroutine("frozen");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cake")
        {
            //Debug.Log("hit the cake");
            score += 1;
        }
        else if (collision.gameObject.tag == "Cookie")
        {
            score += 2;
        }
        else if (collision.gameObject.tag == "Croissant")
        {
            score += 3;
        }
        else if (collision.gameObject.tag == "Toast")
        {
            score += 10;
        }
        else if (collision.gameObject.tag == "IceCookie")
        {
            score += 0;
            isFrozen = true;
        }
        else if (collision.gameObject.tag == "PoisonDonut")
        {
            score += -5;
        }

    }

    public IEnumerator frozen()
    {
        yield return new WaitForSeconds(freezeTime);
        isFrozen = false;
    }
}
