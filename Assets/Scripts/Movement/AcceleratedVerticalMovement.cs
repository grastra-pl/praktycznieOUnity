using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceleratedVerticalMovement : MonoBehaviour
{
    public float Acceleration = -2.0f;
    public float Speed = 0.0f;

    void Update()
    {
        Speed += Time.deltaTime * Acceleration;
        Vector3 position = this.gameObject.transform.position;
        position.y += Time.deltaTime * Speed;
        this.gameObject.transform.position = position;
    }
}
