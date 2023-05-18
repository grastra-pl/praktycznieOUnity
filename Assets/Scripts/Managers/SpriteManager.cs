using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public Sprite[] SpaceshipSprites;

    public static SpriteManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            SpaceshipSprites = Resources.LoadAll<Sprite>("Images/SpaceshipKit");
            Debug.Log("SpriteManager started");
        }
    }
}
