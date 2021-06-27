using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTNSec : MonoBehaviour
{

	public GameObject Object;
	public GameObject Plane1Object;
	public GameObject Button1Object;
	public VirtualButtonBehaviour Vb1;
    // Start is called before the first frame update
    void Start()
    {
	Vb1.RegisterOnButtonPressed(OnButtonPressesed1);
	Object.SetActive(false);
        
    }

    public void OnButtonPressesed1(VirtualButtonBehaviour vb1)
	{
		Object.SetActive(true);
		Plane1Object.SetActive(false);
		Button1Object.SetActive(false);
	}
}
