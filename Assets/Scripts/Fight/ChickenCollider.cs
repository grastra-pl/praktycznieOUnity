using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collider is on the other object
        if (other.CompareTag("BulletB"))
        {
            // Destroy the objects
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
