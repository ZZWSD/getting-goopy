using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // ����
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        Vector3 dir;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dir.x = 1;
            dir.y = 1;
            dir.z = 1;
            this.transform.localScale = dir;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            dir.x = -1;
            dir.y = 1;
            dir.z = 1;
            this.transform.localScale = dir;
        }

        // �a���ˬd
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // ���D
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}


