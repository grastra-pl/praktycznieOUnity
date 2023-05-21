using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{
    public bool IsUpeerLimit = false;
    public bool IsBottomLimit = false;
    public bool IsLeftLimit = false;
    public bool IsRightLimit = false;

    public float UpeerLimit = 0f;
    public float BottomLimit = 0f;
    public float LeftLimit = 0f;
    public float RightLimit = 0f;

    void Update()
    {
        if (!IsUpeerLimit && !IsBottomLimit && !IsRightLimit && !IsRightLimit)
        {
            return;
        }

        Vector3 position = this.gameObject.transform.position;
        
        
        if (IsUpeerLimit)
        {
            position.y = position.y < UpeerLimit ? position.y : UpeerLimit;
        }
        if (IsBottomLimit)
        {
            position.y = position.y > BottomLimit ? position.y : BottomLimit;
        }
        if (IsLeftLimit)
        {
            position.x = position.x > LeftLimit ? position.x : LeftLimit;
        }
        if (IsRightLimit)
        {
            position.x = position.x < RightLimit ? position.x : RightLimit;
        }
        this.gameObject.transform.position = position;
    }
}
