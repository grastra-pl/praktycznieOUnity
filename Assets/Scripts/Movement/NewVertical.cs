using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewVertical : MonoBehaviour
{
    public float Speed = 2.0f;
    public float DestroyY = 10.0f;

    private void Update()
    {
        Vector3 position = transform.position;
        position.y += Time.deltaTime * Speed;
        transform.position = position;

        if (transform.position.y >= DestroyY)
        {
            Destroy(gameObject);
        }
    }
}