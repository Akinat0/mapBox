using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompassCtrl : MonoBehaviour {  

    public Text logText;
    public bool useText = false;
    public bool onceARun = false;

	// Use this for initialization
	void Start () {
        Input.compass.enabled = true;

        if(onceARun){
            SetRotation();
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(useText){
            setTextValues();
        }

    }
    private void LateUpdate()
    {
        if(!onceARun){
            SetRotation();
        }
    }

    private void SetRotation(){
        //transform.rotation = Quaternion.Euler(0, 0, Input.compass.trueHeading);
        transform.rotation = Quaternion.Euler(0, Input.compass.trueHeading, 0);
    }

    private void setTextValues(){
        logText.text = "True heading: " + Input.compass.trueHeading + "\n" +
            " Magnetic heading: " + Input.compass.magneticHeading + "\n" +
            " Update Duration: " + Input.compass.timestamp + "\n" +
            " Heading accuracy: " + Input.compass.headingAccuracy + "\n" +
            " Raw Vector X: " + Input.compass.rawVector.x + "\n" +
            " Raw Vector Y: " + Input.compass.rawVector.y + "\n" +
            " Raw Vector Z: " + Input.compass.rawVector.z;
    }
}
