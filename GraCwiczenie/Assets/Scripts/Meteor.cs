using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = -0.01f;
    float startPositionX;
    float startPositionY;
    float moveX;

    void Start()
    {
        startPositionX = transform.position.x;
        startPositionY = transform.position.y;
        moveX = startPositionX;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(moveX, startPositionY);
        moveX = moveX + speed;
        if(moveX < (- 12))
        {
            transform.position = new Vector2(Random.Range(startPositionX-3, startPositionX +3), Random.Range(transform.position.y-3, transform.position.y+3));
            moveX = startPositionX;
        }
    }
}
