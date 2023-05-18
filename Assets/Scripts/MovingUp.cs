using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUp : MonoBehaviour
{
    public float speed = 4.0f;

    void Update()
    {
        Vector3 position = this.gameObject.transform.position;
        position.y += Time.deltaTime * speed;
        this.gameObject.transform.position = position;
    }
}
