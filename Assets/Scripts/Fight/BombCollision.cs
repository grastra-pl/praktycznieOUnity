using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ("CityC" == collision.gameObject.name)
        {
            Debug.Log("Bum!");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
