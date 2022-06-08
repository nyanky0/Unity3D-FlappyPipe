using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenderScoreLast : MonoBehaviour
{
    public GameObject panel;
    public GameObject testscr;
    void Start()
    {
        testscr.GetComponent<Renderer>().enabled = false;

    }

    void Update()
    {
        /*if panel.active
        {
            testscr.GetComponent<Renderer>().enabled = true;

        }*/
    }
}