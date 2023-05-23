using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
{
    [HideInInspector]
    static Sprite[] _spaceshipSprites;

    [HideInInspector]
    static Sprite _backgroundSprite;

    [HideInInspector]
    static Sprite _splashScreenSprite;

    public static Sprite SplashScreenSprite
    {
        get
        {
            if (_splashScreenSprite == null)
            {
                SpriteManager._splashScreenSprite = Resources.Load<Sprite>("Images/real/LastBullet");
            }
            return _splashScreenSprite;
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
