using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressureButton : MonoBehaviour
{
    public DoorController door; // ����������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("PowerUp"))
        {
            door.OpenDoor();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            door.CloseDoor(); // �p�G�Ʊ���ä[���}�A�i�H���ѱ��o�@��
        }
    }
}
