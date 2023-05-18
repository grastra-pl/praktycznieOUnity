using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRight : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {
        Vector3 position = this.gameObject.transform.position;
        position.x += Time.deltaTime * speed;
        this.gameObject.transform.position = position;
    }
}
