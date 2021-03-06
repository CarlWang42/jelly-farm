using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragIcon : MonoBehaviour
{
    bool allowed;
    Collider2D col;

    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            if (touch.phase==TouchPhase.Began)
            {
                Collider2D touchCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchCollider)
                {
                    allowed = true;
                }
            }


            if (touch.phase == TouchPhase.Moved)
            {
                if (allowed)
                {
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                allowed = false;
            }
        }
        
    }
}
