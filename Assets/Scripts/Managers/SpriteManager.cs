using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    [HideInInspector]
    public Sprite[] SpaceshipSprites;

    [HideInInspector]
    public Sprite BackgroundSprite;

    [HideInInspector]
    public Sprite SplashScreenSprite;


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
            SpaceshipSprites = Resources.LoadAll<Sprite>("Images/real/SpaceshipKit");
            BackgroundSprite = Resources.Load<Sprite>("Images/real/Planet");
            SplashScreenSprite = Resources.Load<Sprite>("Images/real/LastBullet");

            Debug.Log("SpriteManager started");
        }
    }
}
