using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("PauseButton");
        Button btn = obj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            Time.timeScale=1;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
