using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject winUI;  // ��i�� UI Panel �� Text
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
            Debug.Log("�A�q���F�I");
            if (winUI != null)
            {
                winUI.SetActive(true);  // ��� UI
            }
            // �i��G�Ȱ��C��
            Time.timeScale = 0f;
        }
    }
}
