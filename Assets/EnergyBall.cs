using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyBall : MonoBehaviour
{
    public bool isFromPlayer = false; // �g�X�y = true / ��l�y = false
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && isFromPlayer)
        {
            PlayerShooting player = other.GetComponent<PlayerShooting>();
            if (player != null)
            {
                player.energyCount++;
                player.GetComponent<SpriteRenderer>().color = Color.green;
                player.transform.localScale += Vector3.one * 0.1f;

                Destroy(gameObject); //  �Q�l�������
            }
        }
    }
}
