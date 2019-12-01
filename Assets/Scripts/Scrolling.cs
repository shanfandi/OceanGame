using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float speed;
    public float killZone;
    public float xStart, yStart;
    public Vector2 start;

    // Start is called before the first frame update
    void Start()
    {
        start = new Vector2(xStart, yStart);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= killZone)
        {
            transform.position = start;
        }
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
