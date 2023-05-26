using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRocket : MonoBehaviour
{
    public GameObject RocketPrefab;
    private float spawnInterval = 0.5f;
    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnRocket();
            timer = 0f;
        }
    }

    private void SpawnRocket()
    {
        GameObject rocket = Instantiate(RocketPrefab, transform.position, Quaternion.identity);
        rocket.transform.localScale = RocketPrefab.transform.localScale;
    }
}
