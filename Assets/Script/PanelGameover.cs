using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelGameover : MonoBehaviour {
    
    void Start () {
      
        
    }
	void Update ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("TITLE");
            Time.timeScale = 1;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Reload();
        }
	}
    void Reload()
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        Time.timeScale = 1;
    }
}
