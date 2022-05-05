using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer rend;

    float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    private enum MovementState { idle, running, jumping, falling }
    private MovementState state = MovementState.idle;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // horizontal movement
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(0, jumpForce);
        }

        AnimTransition();
    }

    private void AnimTransition()
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            rend.flipX = false;
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            rend.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }
    }
}
