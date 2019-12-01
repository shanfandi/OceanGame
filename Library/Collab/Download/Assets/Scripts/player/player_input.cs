using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_input : MonoBehaviour
{
    // accel value added per update
    public float accel = 0.15f;
    private Vector2 velocity = new Vector2(0f, 0f);
    public KeyCode MoveLeft = KeyCode.A;
    public KeyCode MoveRight = KeyCode.D;
    public KeyCode MoveUp = KeyCode.W;
    public KeyCode MoveDown = KeyCode.S;
    public float friction = 0.8f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {    
        UpdateMovement();
        
    }

    private void UpdateMovement()
    {
        UpdateHorizontalMovement();
        UpdateVerticalMovement();
        UpdateMovementBounds();
    }

    private void UpdateHorizontalMovement()
    {
        if (Input.GetKey(MoveLeft))
        {
            velocity.x -= accel * Time.deltaTime;
        }
        else if (Input.GetKey(MoveRight))
        {
            velocity.x += accel * Time.deltaTime;
        }
        velocity.x -= friction * Mathf.Sign(velocity.x) * Time.deltaTime;
        velocity.x = Mathf.Clamp(velocity.x, -0.5f, 0.5f);
        transform.position = new Vector2(transform.position.x + velocity.x, transform.position.y);

    }

    private void UpdateVerticalMovement()
    {
        if (Input.GetKey(MoveDown))
        {
            velocity.y -= accel * Time.deltaTime;
        }
        else if (Input.GetKey(MoveUp))
        {
            velocity.y += accel * Time.deltaTime;
        }
        velocity.y -= friction * Mathf.Sign(velocity.y) * Time.deltaTime;
        velocity.y = Mathf.Clamp(velocity.y, -0.5f, 0.5f);
        transform.position = new Vector2(transform.position.x, transform.position.y + velocity.y);

    }

    private void UpdateMovementBounds()
    {
        if (transform.localPosition.x < -8f)
        {
            transform.localPosition = new Vector3(-8f, transform.localPosition.y, transform.localPosition.z);
            velocity.x = 0f;
        }
        else if (transform.localPosition.x > 8f)
        {
            transform.localPosition = new Vector3(8f, transform.localPosition.y, transform.localPosition.z);
            velocity.x = 0f;
        }

        if (transform.localPosition.y < -4.5f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, -4.5f, transform.localPosition.z);
            velocity.y = 0f;
        }
        else if (transform.localPosition.y > 4.5f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 4.5f, transform.localPosition.z);
            velocity.y = 0f;
        } 
    }
}
