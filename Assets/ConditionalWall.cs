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
        col.enabled = false;  // �w�]�����A�����ܦ⪺���a���
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

            // �p�G�O���A�ҥθI���A�_�h�T��
            if (sr != null && sr.color == Color.green)
            {
                // �I�����ġG�O�d��
                GetComponent<Collider2D>().enabled = true;
            }
            else
            {
                // ����L�ĤơA������ Player ��L
                GetComponent<Collider2D>().enabled = false;
            }
        }
    }
        // ���F�����b���s�i�J�ɫ�_�I��
        //private void OnCollisionExit2D(Collision2D collision)
        //{
        //    if (collision.gameObject.CompareTag("Player"))
        //    {
        //        GetComponent<Collider2D>().enabled = true;
        //    }
        //}
    public void EnableWall()
    {
        col.enabled = true;   // �ܦ��~�צ��a
    }
}
