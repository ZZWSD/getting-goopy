using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartUI : MonoBehaviour
{
    public GameObject startPanel;  // UI畫面 Panel
    public GameObject player;      // 角色

    void Start()
    {
        // 遊戲一開始：暫停時間、隱藏角色、顯示 UI
        Time.timeScale = 0f;
        player.SetActive(false);
        startPanel.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        // 恢復遊戲
        Time.timeScale = 1f;
        player.SetActive(true);
        startPanel.SetActive(false);
    }
}

