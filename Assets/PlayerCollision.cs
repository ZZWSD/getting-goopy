using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float scaleMultiplier = 1.5f;
    public Color targetColor = Color.green;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenOrb"))
        {
            Debug.Log("碰到綠色球體！");

            // 放大
            transform.localScale *= scaleMultiplier;

            // 變綠色
            if (rend != null)
            {
                rend.material.color = targetColor;
            }

            // 可選：碰撞完就刪除球體
            Destroy(other.gameObject);
        }
    }
}

