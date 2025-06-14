using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUp : MonoBehaviour
{
    public bool hasPower = false; // 狀態：有吃到球？
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PowerUp") && !hasPower)
        {
            Destroy(other.gameObject);
            hasPower = true;
            sr.color = Color.green;
            transform.localScale *= 1.5f;

            // 找出所有 ConditionalWall 並啟用碰撞器
            ConditionalWall[] walls = FindObjectsOfType<ConditionalWall>();
            foreach (ConditionalWall wall in walls)
            {
                wall.EnableWall(); // 呼叫牆的方法
            }
        }
        if (other.CompareTag("Player"))
        {
            PlayerShooting ps = other.GetComponent<PlayerShooting>();
            if (ps != null)
            {
                ps.AddAmmo(); // 增加射擊次數
                Destroy(gameObject); // 吸收球體
            }
        }
    } 
}
