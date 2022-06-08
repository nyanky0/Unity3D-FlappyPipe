using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapanBatas : MonoBehaviour {

    private void Start()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag  == "Bird1")

        {
            Debug.Log("menabrak batas : " + other.gameObject.name);
            Destroy(other.gameObject);
        }

    }
}
