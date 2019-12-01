using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OceanTrash : MonoBehaviour
{
    private float speed = 5;

    public TextMeshPro scoreText;

    public void Start()
    {
        speed = Random.Range(4.3f, 6);
    }

    public void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < -8)
        {
            DestroyGameObject();
        }
    }

    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }

}
