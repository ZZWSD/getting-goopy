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

                // �ܤj
                transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);

                // �ܦ�
                sr.color = poweredColor;
            // ��X�Ҧ� ConditionalWall �ñҥθI����
            ConditionalWall[] walls = FindObjectsOfType<ConditionalWall>();
            foreach (ConditionalWall wall in walls)
            {
                wall.EnableWall(); // �I�s�𪺤�k
            }
        }
    } 
}
