using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDropper : MonoBehaviour
{
    public GameObject Bomb;
    public float DropZoneLeft = 0f;
    public float DropZoneRight = 0f;

    private bool isBombardmentStarted = false;

    private AcceleratedVerticalMovement bombAccelerator;

    private void Start()
    {
        bombAccelerator = Bomb.GetComponent<AcceleratedVerticalMovement>();
    }


    void Update()
    {
        if (isBombardmentStarted)
        {
            return;
        }

        Vector3 position = this.gameObject.transform.position;
        if (position.x > DropZoneLeft && position.x < DropZoneRight)
        {
            bombAccelerator.Acceleration = -2;
            isBombardmentStarted = true;
        }
    }
}
