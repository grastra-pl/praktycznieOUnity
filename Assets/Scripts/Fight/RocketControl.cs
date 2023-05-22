using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControl : MonoBehaviour
{
    public GameObject RocketPrefab;
    public int BulletsLeft = 1;
    public float FireDelay = 1f;


    private InputManager inputManager;
    private float lastFireTime = 0f;

    private void Awake()
    {
        inputManager = InputManager.Instance;
        lastFireTime = FireDelay;
    }

    private void OnEnable()
    {
        inputManager.OnStartTouch += Fire;
    }

    private void OnDisable()
    {
        inputManager.OnStartTouch -= Fire;
    }

    public void Fire(Vector2 screenPosition, float time)
    {
        if (BulletsLeft > 0 && time-lastFireTime > FireDelay)
        {
            BulletsLeft--;
            lastFireTime = time;
            Instantiate(RocketPrefab, gameObject.transform);
        }
    }
}
