using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Generate : MonoBehaviour {

    public GameObject Bird;
    //public GameObject Bird2;
    /*public string[] manuk = new string[2]
    {
        "Bird1","Bird2"
    };*/

    void Start() {
        InvokeRepeating("CreateObstacle", 1f, 2.5f);
        /*Bird = new GameObject[2];
        Bird[0] = Bird1;
        Bird[1] = Bird2;*/
        
    }

    /*private void InvokeRepeating(string v1, float v2, float v3)
    {
        throw new NotImplementedException();
    }*/

	void Update () {
        
    }

    void CreateObstacle()
    {
        //Instantiate(GameObject.manuk[UnityEngine.Random.Range(0, 1)]);
        Instantiate(Bird);
        
    }

}
