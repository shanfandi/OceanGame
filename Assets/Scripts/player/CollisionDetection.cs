using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CollisionDetection : MonoBehaviour
{
    public TextMeshPro livesText;
    public  float lives = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
       if (collider.gameObject.GetComponent<OceanTrash>() != null)
       {
            HurtPlayer();
            Destroy(collider.gameObject);
       }
       if (collider.gameObject.GetComponent<Jellyfish>() != null)
       {
            FeedPlayer();
            Destroy(collider.gameObject);
       }
    }

    private void HurtPlayer()
    {
        lives -= 1;
        if (lives <= 0)
        {
            killPlayer();
        }
    }

    private void FeedPlayer(){
        lives += 1;
        //if(lives<=0)
    }
    private void killPlayer(){
        Time.timeScale=0;
    }
    
}
