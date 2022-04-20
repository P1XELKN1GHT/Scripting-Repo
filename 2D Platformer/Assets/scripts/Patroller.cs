using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool moveRight = true;
    public Transform groundDetect;
   
    // Update is called once per frame
    void Update()
    {   
        // move enemy to the right
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetect.position, Vector2.down, distance);

        if(groundInfo.collider == false)
        {
            if(moveRight == true)
            {//flip enemy so it moves left
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveRight = false;
            }
            else
            {//FLip Enemy to move right
                transform.eulerAngles = new Vector3(0,0,0);
                moveRight = true;
            }
        }
    }
}
