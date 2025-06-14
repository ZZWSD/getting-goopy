using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowerUp : MonoBehaviour
{
    public bool hasPower = false; // ���A�G���Y��y�H
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

            // ��X�Ҧ� ConditionalWall �ñҥθI����
            ConditionalWall[] walls = FindObjectsOfType<ConditionalWall>();
            foreach (ConditionalWall wall in walls)
            {
                wall.EnableWall(); // �I�s�𪺤�k
            }
        }
        if (other.CompareTag("Player"))
        {
            PlayerShooting ps = other.GetComponent<PlayerShooting>();
            if (ps != null)
            {
                ps.AddAmmo(); // �W�[�g������
                Destroy(gameObject); // �l���y��
            }
        }
    } 
}
