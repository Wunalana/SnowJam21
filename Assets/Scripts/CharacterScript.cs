using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public float speed = 3f;
    public Animator animator;
    SpriteRenderer m_SpriteRenderer;

    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        this.transform.Translate(horizontalMove, 0, 0);

        // animator
        m_SpriteRenderer.flipX = (horizontalMove < 0);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }
}
