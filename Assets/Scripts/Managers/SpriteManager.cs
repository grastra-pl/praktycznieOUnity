using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    public Sprite[] SpaceshipSprites;

    public static SpriteManager instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        SpaceshipSprites = Resources.LoadAll<Sprite>("Images/SpaceshipKit");
    }
}
