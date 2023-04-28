using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private Rigidbody2D body;

    public bool grounded;
    public LayerMask Isgrounded;

    private Collider2D myCollider;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(moveSpeed, body.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (grounded)
            {
                body.velocity = new Vector2(body.velocity.x, jumpForce);
            }
        }
    }
}
