using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public static int score;
    public Animator animator;
    SpriteRenderer m_SpriteRenderer;
    public float speed = 3f;
    public bool isFrozen;
    private int freezeTime = 3;


    void Start()
    {
        score = 0;
        isFrozen = false;
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (isFrozen != true)
        {
            //amy
            float horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            this.transform.Translate(horizontalMove, 0, 0);

            // animator
            m_SpriteRenderer.flipX = (horizontalMove < 0);
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
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
            if (!isFrozen)
                animator.SetTrigger("Eat");
            score += 1;
        }
        else if (collision.gameObject.tag == "Cookie")
        {
            if (!isFrozen)
                animator.SetTrigger("Eat");
            score += 2;
        }
        else if (collision.gameObject.tag == "Croissant")
        {
            if (!isFrozen)
                animator.SetTrigger("Eat");
            score += 3;
        }
        else if (collision.gameObject.tag == "Toast")
        {
            if (!isFrozen)
                animator.SetTrigger("Eat");
            score += 10;
        }
        else if (collision.gameObject.tag == "IceCookie")
        {
            score += 0;
            isFrozen = true;
            animator.SetBool("isFrozen", isFrozen);
        }
        else if (collision.gameObject.tag == "PoisonDonut")
        {
            if (!isFrozen)
                animator.SetTrigger("Puke");
            score += -5;
        }

    }

    public IEnumerator frozen()
    {
        yield return new WaitForSeconds(freezeTime);
        isFrozen = false;
        animator.SetBool("isFrozen", isFrozen);
    }
}
