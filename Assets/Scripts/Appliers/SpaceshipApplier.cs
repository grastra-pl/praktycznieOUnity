using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipApplier : MonoBehaviour
{
    public int SpaceshipModuleNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = SpriteManager.SpaceshipSprites[SpaceshipModuleNumber];
        float width = ScreenSize.GetScreenToWorldHeight;
        transform.localScale = Vector3.one * 0.5f * width;
    }
}
