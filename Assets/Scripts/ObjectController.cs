using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectController : MonoBehaviour
{

    public float waitTime = 2;
    private float yMin = -4.5f;
    private float yMax = 4.5f;
    private int sector;

    public TextMeshPro scoreText;

    //public GameObject trash;
    public GameObject trashcan;
    public GameObject jellyfish;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waitTime -= Time.deltaTime;
        float score = int.Parse(scoreText.text);
        double discount = (score % 1000) * 0.1;
        discount = (discount >= 1) ? 1 : discount;

        double min = 2.5 - discount;

        if (waitTime <= 0)
        {
            float y = Random.Range(yMin, yMax);
            Vector3 pos = new Vector3(12, y, -1);
            Instantiate(trashcan, pos, Quaternion.identity);

            y = Random.Range(yMin, yMax);
            pos = new Vector3(12, y, -1);
            Instantiate(jellyfish,pos,Quaternion.identity);
            waitTime = Random.Range(2.5f, 2.5f);
            sector = (y < 0) ? 0 : 1;

            if (sector == 1)
            {
                yMax = 1;
                yMin = -4.5f;
            }
            else
            {
                yMax = 4.5f;
                yMin = -1;
            }
        }
        
        

        //obj.transform.position=new Vector3(ni,0,nt);

        //waitTime=Random.Range(0,10);
    }
}
