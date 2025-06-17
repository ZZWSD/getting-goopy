using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject energyBallPrefab;  // �g�X����q�y�w�s��
    public Transform shootPoint;         // �g�X�I�]�бq Inspector �����^
    public float shootForce = 10f;
    public int energyCount = 0;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private Vector3 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && energyCount > 0)
        {
            ShootEnergyBall();
            energyCount--;
            transform.localScale = originalScale + Vector3.one * energyCount * 0.1f;
            if (energyCount == 0)
            {
                spriteRenderer.color = Color.white;  // �ܦ^�զ�
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PowerUp"))
        {
            energyCount++;
            spriteRenderer.color = Color.green;
            transform.localScale = originalScale + Vector3.one * energyCount * 0.1f;
            Destroy(other.gameObject);
        }
    }
    void ShootEnergyBall()
    {
        GameObject ball = Instantiate(energyBallPrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D ballRb = ball.GetComponent<Rigidbody2D>();

        Vector2 shootDir = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - shootPoint.position);
        shootDir.Normalize();

        ballRb.gravityScale = 1; //  �����O�����s
        ballRb.AddForce(shootDir * shootForce, ForceMode2D.Impulse);

        //  ��y�O
        rb.AddForce(-shootDir * shootForce * 0.5f, ForceMode2D.Impulse);

        //  �аO�o�O�q���a�g�X���y
        EnergyBall energyScript = ball.GetComponent<EnergyBall>();
        if (energyScript != null)
            energyScript.isFromPlayer = true;
    }
}
