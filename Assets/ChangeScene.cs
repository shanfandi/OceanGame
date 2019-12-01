using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("PauseButton");
        Button btn = obj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            Time.timeScale=0;
        });
}
    // Update is called once per frame
    void Update()
    {
        
    }

}
