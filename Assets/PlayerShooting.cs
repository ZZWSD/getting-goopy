using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;    // ��q�y�w�s��
    public Transform shootPoint;           // �o�g��m�]�l����^
    public float projectileSpeed = 10f;
    public float recoilForce = 5f;

    private Rigidbody2D rb;
    private int ammo = 0;  // �x�s�l���ƶq
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ammo > 0)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        // ���o�ƹ���m�íp���V
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shootDir = ((Vector2)mousePos - (Vector2)shootPoint.position).normalized;

        // �إ߯�q�y
        GameObject proj = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D projRb = proj.GetComponent<Rigidbody2D>();

        if (projRb != null)
        {
            projRb.velocity = shootDir * projectileSpeed;
        }

        // �I�[��y�O
        rb.AddForce(-shootDir * recoilForce, ForceMode2D.Impulse);

        ammo--;

    }
    public void AddAmmo()
    {
        ammo++;
        Debug.Log("��o��q�y�A�ثe�u�ļơG" + ammo);
    }
}
