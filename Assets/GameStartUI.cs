using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartUI : MonoBehaviour
{
    public GameObject startPanel;  // UI�e�� Panel
    public GameObject player;      // ����

    void Start()
    {
        // �C���@�}�l�G�Ȱ��ɶ��B���è���B��� UI
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
        // ��_�C��
        Time.timeScale = 1f;
        player.SetActive(true);
        startPanel.SetActive(false);
    }
}

