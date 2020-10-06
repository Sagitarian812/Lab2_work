using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonHandler : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbGameObject;
    public GameObject editObject;
    void Start()
    {
        vbGameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        editObject.GetComponent<Transform>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("vb Pressed");
        if(vbGameObject.tag == "Button1")
        {
            editObject.transform.position += new Vector3(0, .03f, 0);
        }
        if (vbGameObject.tag == "Button2")
        {
            editObject.transform.position += new Vector3(.03f, 0, 0);
        }
        if (vbGameObject.tag == "Button3")
        {
            editObject.transform.position += new Vector3(0, 0, .03f);
        }
        if (vbGameObject.tag == "Button4")
        {
            editObject.transform.Rotate(0, 10, 0);
        }
        if (vbGameObject.tag == "Button5")
        {
            editObject.transform.Rotate(0, 10, 10);
        }
        if (vbGameObject.tag == "Button6")
        {
            editObject.transform.localScale += new Vector3 (0,0,5);
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("vb Released");
        if (vbGameObject.tag == "Button1")
        {
            editObject.transform.position -= new Vector3(0, .03f, 0);
        }
        if (vbGameObject.tag == "Button2")
        {
            editObject.transform.position -= new Vector3(.03f, 0, 0);
        }
        if (vbGameObject.tag == "Button3")
        {
            editObject.transform.position -= new Vector3(0, 0, .03f);
        }
        if (vbGameObject.tag == "Button4")
        {
            editObject.transform.Rotate(0, -10, 0);
        }
        if (vbGameObject.tag == "Button5")
        {
            editObject.transform.Rotate(0, -10, -10);
        }
        if (vbGameObject.tag == "Button6")
        {
            editObject.transform.localScale -= new Vector3(0, 0, 5);
        }
    }

}
