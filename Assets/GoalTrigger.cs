using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject winUI;  // 拖進來 UI Panel 或 Text
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("你通關了！");
            if (winUI != null)
            {
                winUI.SetActive(true);  // 顯示 UI
            }
            // 可選：暫停遊戲
            Time.timeScale = 0f;
        }
    }
}
