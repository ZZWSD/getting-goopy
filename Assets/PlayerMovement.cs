using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���o��L��J
        movement.x = Input.GetAxisRaw("Horizontal"); // A(-1) / D(1)
        movement.y = Input.GetAxisRaw("Vertical");   // S(-1) / W(1)
    }
    void FixedUpdate()
    {
        // ���z���ʡA����d�y
        rb.MovePosition(rb.position + movement * 5 * Time.fixedDeltaTime);
    }
}
