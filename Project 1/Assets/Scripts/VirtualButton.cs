using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public GameObject authorText;
    public GameObject reviewText;
    public int current = 1;

    // Start is called before the first frame update
    void Start()
    {
        authorText = GameObject.Find("BackCoverText");
        reviewText = GameObject.Find("Reviewtotal");
        reviewText.SetActive(false);
        button = GameObject.Find("VirtualButton3");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (current == 1)
        {
            authorText.SetActive(false);
            reviewText.SetActive(true);
            current = 2;
        }
        else
        {
            authorText.SetActive(true);
            reviewText.SetActive(false);
            current = 1;
        }
        

        Debug.Log("Button Pressed");
        Debug.Log("Current is: " + current);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
