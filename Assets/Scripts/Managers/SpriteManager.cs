using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    [HideInInspector]
<<<<<<< HEAD
    public Sprite[] SpaceshipSprites;

    [HideInInspector]
    public Sprite BackgroundSprite;

    [HideInInspector]
    public Sprite SplashScreenSprite;


    public static SpriteManager Instance { get; private set; }
=======
    static Sprite[] _spaceshipSprites;

    [HideInInspector]
    static Sprite _backgroundSprite;
>>>>>>> master

    [HideInInspector]
    static Sprite _splashScreenSprite;

    public static Sprite SplashScreenSprite
    {
        get
        {
<<<<<<< HEAD
            Destroy(this);
        }
        else
        {
            Instance = this;
            SpaceshipSprites = Resources.LoadAll<Sprite>("Images/real/SpaceshipKit");
            BackgroundSprite = Resources.Load<Sprite>("Images/real/Planet");
            SplashScreenSprite = Resources.Load<Sprite>("Images/real/LastBullet");

            Debug.Log("SpriteManager started");
=======
            if (_splashScreenSprite == null)
            {
                SpriteManager._splashScreenSprite = Resources.Load<Sprite>("Images/real/LastBullet");
            }
            return _splashScreenSprite;
>>>>>>> master
        }
    }

    public static Sprite BackgroundSprite
    {
        get
        {
            if (_backgroundSprite == null)
            {
                SpriteManager._backgroundSprite = Resources.Load<Sprite>("Images/real/PlanetOne");
            }
            return _backgroundSprite;
        }
    }

    public static Sprite[] SpaceshipSprites
    {
        get
        {
            if (_spaceshipSprites == null)
            {
                SpriteManager._spaceshipSprites = Resources.LoadAll<Sprite>("Images/real/SpaceshipKit");
            }
            return _spaceshipSprites;
        }
    }
   
}
