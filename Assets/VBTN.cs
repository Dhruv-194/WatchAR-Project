using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    public GameObject echoObject;
    public GameObject PlaneObject;
    public GameObject Scriptvbtn2;
    public VirtualButtonBehaviour Vb; 
    // Start is called before the first frame update
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPressed);
        echoObject.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        echoObject.SetActive(true);
        PlaneObject.SetActive(false);
        Scriptvbtn2.SetActive(false);  
    }
}
