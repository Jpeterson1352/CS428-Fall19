using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject button;
    public GameObject obj;
    public Animator objAnimation;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("totoro");
        obj.SetActive(false);
        button = GameObject.Find("VirtualButton");
        button.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        objAnimation.GetComponent<Animator>();
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        obj.SetActive(true);
        objAnimation.Play("TotoroAnimation");
        Debug.Log("Button Pressed");

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        objAnimation.Play("none");
        obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
