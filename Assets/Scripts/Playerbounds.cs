using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerbounds : MonoBehaviour
{
    private float minx, maxx;
    // Start is called before the first frame update
    void Start()
    {
       // Vector3 coor = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
      //  minx = -coor.x;
        //maxx = coor.x;
        minx = -1.89f;
        maxx = 1.98f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        if (temp.x > maxx)
            temp.x = maxx;
        if (temp.x < minx)
            temp.x = minx;

        transform.position = temp;
    }
}
