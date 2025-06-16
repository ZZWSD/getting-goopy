using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUp : MonoBehaviour
{
    public bool hasPower = false;
    public int powerCount = 0;
    public float sizeIncrease = 0.1f;
    public Color poweredColor = Color.green;
    private SpriteRenderer sr;

    void Start()
    {
        if (sr == null)
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
                powerCount++;
                Destroy(other.gameObject);

                // 變大
                transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);

                // 變色
                sr.color = poweredColor;
            // 找出所有 ConditionalWall 並啟用碰撞器
            ConditionalWall[] walls = FindObjectsOfType<ConditionalWall>();
            foreach (ConditionalWall wall in walls)
            {
                wall.EnableWall(); // 呼叫牆的方法
            }
        }
    } 
}
