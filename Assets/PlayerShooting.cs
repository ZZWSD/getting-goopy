using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;    // 能量球預製體
    public Transform shootPoint;           // 發射位置（子物件）
    public float projectileSpeed = 10f;
    public float recoilForce = 5f;

    private Rigidbody2D rb;
    private int ammo = 0;  // 儲存吸收數量
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
        // 取得滑鼠位置並計算方向
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shootDir = ((Vector2)mousePos - (Vector2)shootPoint.position).normalized;

        // 建立能量球
        GameObject proj = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D projRb = proj.GetComponent<Rigidbody2D>();

        if (projRb != null)
        {
            projRb.velocity = shootDir * projectileSpeed;
        }

        // 施加後座力
        rb.AddForce(-shootDir * recoilForce, ForceMode2D.Impulse);

        ammo--;

    }
    public void AddAmmo()
    {
        ammo++;
        Debug.Log("獲得能量球，目前彈藥數：" + ammo);
    }
}
