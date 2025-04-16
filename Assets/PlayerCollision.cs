using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public float scaleMultiplier = 1.5f;
    public Color targetColor = Color.green;

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenOrb"))
        {
            Debug.Log("�I����y��I");

            // ��j
            transform.localScale *= scaleMultiplier;

            // �ܺ��
            if (rend != null)
            {
                rend.material.color = targetColor;
            }

            // �i��G�I�����N�R���y��
            Destroy(other.gameObject);
        }
    }
}

