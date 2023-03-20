using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPlayer : MonoBehaviour
{
    float movementSpd = 0.08f;
    int endingNum = 10;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       //camera movement
        Vector3 newPos = transform.position;
        //if(Input.GetKey(KeyCode.W))
        //{ newPos.y += movementSpd; }
        //if (Input.GetKey(KeyCode.S))
        //{ newPos.y -= movementSpd; }
        if (Input.GetKey(KeyCode.D))
        { newPos.x += movementSpd; }
        if (Input.GetKey(KeyCode.A))
        { newPos.x -= movementSpd; }

        transform.position = newPos;

        //camera looping
        if(newPos.x >= 35)
        {
            newPos.x = -10;
        }

        if(newPos.x <= -15)
        {
            newPos.x = 35;
        }

        transform.position = newPos; 
    }
}

//-15 and 35