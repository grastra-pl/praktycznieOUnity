using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public float Speed = 2.0f;

    void Update()
    {
        Vector3 position = this.gameObject.transform.position;
        position.x += Time.deltaTime * Speed;
        this.gameObject.transform.position = position;
    }
}
