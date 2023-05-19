using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public float Speed = 4.0f;

    void Update()
    {
        Vector3 position = this.gameObject.transform.position;
        position.y += Time.deltaTime * Speed;
        this.gameObject.transform.position = position;
    }
}
