using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 0.01f;
    
    void Start()
    {

        
    }





    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0 ,0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
          
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y );
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y );
        }
    }

   
    
}
