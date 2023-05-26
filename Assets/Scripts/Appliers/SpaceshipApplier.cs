using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipApplier : MonoBehaviour
{
    public int SpaceshipModuleNumber = 0;
    public BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        if (boxCollider != null)
        {
            // Change the size of the collider
            if(gameObject.name == "BulletB"){
                boxCollider.size = new Vector2(0.05f, 0.15f);
            }
            else if(gameObject.name == "BulletB(Clone)"){
                boxCollider.size = new Vector2(0.05f, 0.15f);
            }
            else{
                boxCollider.size = new Vector2(0.3f, 0.2f);
            }
            
            
        }
        SpriteRenderer spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = SpriteManager.SpaceshipSprites[SpaceshipModuleNumber];
        float width = ScreenSize.GetScreenToWorldHeight;
        transform.localScale = Vector3.one * 0.5f * width;
    }
}
