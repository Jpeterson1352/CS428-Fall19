using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class VBTrans : MonoBehaviour, IVirtualButtonEventHandler
{
    // Start is called before the first frame update
    public GameObject origText;
    public GameObject transText;
    public GameObject button;
    public int current = 1;

    void Start()
    {
        origText = GameObject.Find("reviewTotal");
        transText = GameObject.Find("Translated Content");
        transText.SetActive(false);
        button = GameObject.Find("VirtualButtonTrans");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (current == 1)
        {
            origText.SetActive(false);
            transText.SetActive(true);

            current = 2;
        }
        if (current == 2)
        {
            origText.SetActive(true);
            transText.SetActive(false);

            current = 1;
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

    }
}
