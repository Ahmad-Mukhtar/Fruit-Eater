using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 5f;
    private int i = 0;
    private Rigidbody2D mybody;

    // Start is called before the first frame update
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Touch touch = Input.GetTouch(0);

        Vector3 touchpos = Camera.main.ScreenToWorldPoint(touch.position);
      
          if(touchpos.x>0)
            {
                mybody.velocity = new Vector2(speed, 0f);
         
            }
            if (touchpos.x < 0)
                mybody.velocity = new Vector2(-speed, 0f);
            
         
    }

    /*   Touch touch = Input.GetTouch(0);
       //    Vector2 touchpos = mybody.velocity;
       Vector2 touchpos = touch.position;
       mybody.velocity = touchpos;*/
}
