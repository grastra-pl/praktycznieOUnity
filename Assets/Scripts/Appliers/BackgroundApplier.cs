using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundApplier : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = SpriteManager.BackgroundSprite;
        float width = ScreenSize.GetScreenToWorldHeight;
        transform.localScale = Vector3.one * 0.175f * width;
    }
}
