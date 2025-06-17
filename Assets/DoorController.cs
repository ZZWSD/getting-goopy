using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Vector3 closedPosition;
    public float openDistance = 3f; // 開門往上移動距離
    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        closedPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        if (!isOpen)
        {
            transform.position = closedPosition + Vector3.up * openDistance;
            isOpen = true;
        }
    }
    public void CloseDoor()
    {
        if (isOpen)
        {
            transform.position = closedPosition;
            isOpen = false;
        }
    }
}
