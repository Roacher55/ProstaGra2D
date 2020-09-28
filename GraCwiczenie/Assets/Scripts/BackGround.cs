using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed =-0.01f;
    private float moveX;
    private float startPosition;
    void Start()
    {
        startPosition = transform.position.x;
        moveX = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = moveX + speed;
        transform.position = new Vector2(moveX, 0);

        if(moveX < (startPosition-24))
        {
            
            transform.position = new Vector2(startPosition, 0);
            moveX = startPosition;
        }
            
        
    }
}
