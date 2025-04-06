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
        // 取得鍵盤輸入
        movement.x = Input.GetAxisRaw("Horizontal"); // A(-1) / D(1)
        movement.y = Input.GetAxisRaw("Vertical");   // S(-1) / W(1)
    }
    void FixedUpdate()
    {
        // 物理移動，防止卡頓
        rb.MovePosition(rb.position + movement * 5 * Time.fixedDeltaTime);
    }
}
