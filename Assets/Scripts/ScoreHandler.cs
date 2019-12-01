using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public TextMeshPro scoreText;
    public float score = 0f;


    // Start is called before the first frame update
    void Start()
    {
        score = 0f;
        scoreText.text = "" + score;
    }

    // Update is called once per frame
    void Update()
    {
        AddScore(1);
        if(Time.timeScale==0){
            AddScore(0);
        }
    }

    private void AddScore(int s)
    {
        score += s;
        scoreText.text = "" + score;
    }


}
