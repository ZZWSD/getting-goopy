using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalWall : MonoBehaviour
{
    private Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        col.enabled = false;  // 預設關閉，讓未變色的玩家能穿
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = collision.gameObject;

        if (player.CompareTag("Player"))
        {
            SpriteRenderer sr = player.GetComponent<SpriteRenderer>();

            // 如果是綠色，啟用碰撞，否則禁用
            if (sr != null && sr.color == Color.green)
            {
                // 碰撞有效：保留牆
                GetComponent<Collider2D>().enabled = true;
            }
            else
            {
                // 讓牆無效化，等於讓 Player 穿過
                GetComponent<Collider2D>().enabled = false;
            }
        }
    }
        // 為了讓牆能在重新進入時恢復碰撞
        //private void OnCollisionExit2D(Collision2D collision)
        //{
        //    if (collision.gameObject.CompareTag("Player"))
        //    {
        //        GetComponent<Collider2D>().enabled = true;
        //    }
        //}
    public void EnableWall()
    {
        col.enabled = true;   // 變色後才擋住玩家
    }
}
