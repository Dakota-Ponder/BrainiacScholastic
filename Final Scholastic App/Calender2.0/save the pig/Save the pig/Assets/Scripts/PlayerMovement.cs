using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D body;

    float xInput;

    Vector2 NewPosition;

    public float Speed;

    public float XPositionLimit;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Move from -1 to 1
        xInput = Input.GetAxis("Horizontal");

        NewPosition = transform.position;

        NewPosition.x += xInput * Speed;

        NewPosition.x = Mathf.Clamp(NewPosition.x, -XPositionLimit, XPositionLimit);

        body.MovePosition(NewPosition);


    }


}
