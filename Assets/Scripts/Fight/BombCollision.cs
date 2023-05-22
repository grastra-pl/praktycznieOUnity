using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollision : MonoBehaviour
{
    public GameObject Bomber;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ("CityC" == collision.gameObject.name)
        {
            Debug.Log("Bum!");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        Debug.Log(collision.gameObject.name);

        if ("BulletB(Clone)" == collision.gameObject.name)
        {
            Destroy(Bomber);
            Destroy(gameObject);
        }

        
    }
}
