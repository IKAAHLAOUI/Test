using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    public float moveSpeed = 15f;

    public Rigidbody2D rb2d;
    bool isFacingRight = true;

    Vector2 movement;
    Animator animator;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator = GetComponent<Animator>();
        animate();
        flip();

    }

    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed);
    }
    void animate()
    {
        if (movement.y == 0 && movement.x == 0)
        {
            animator.SetBool("isIdle", true);
        }
        else
        {
            animator.SetBool("isIdle", false);
            if (movement.x > 0)
            {
                animator.Play("Walk_Left");
            }
            if (movement.x < 0)
            {
                animator.Play("Walk_Left");
            }
            if (movement.y > 0)
            {
                animator.Play("Walk_Up");
            }
            if (movement.y < 0)
            {
                animator.Play("Walk_Down");
            }
        }


    }

    void flip()
    {
        if (movement.x > 0 && !isFacingRight)
        {
            Vector3 scale = transform.localScale;
            scale.x = scale.x * -1;
            transform.localScale = scale;
            isFacingRight = true;


        }
        if (movement.x < 0 && isFacingRight)
        {
            Vector3 scale = transform.localScale;
            scale.x = scale.x * -1;
            transform.localScale = scale;
            isFacingRight = false;
        }


    }

}
