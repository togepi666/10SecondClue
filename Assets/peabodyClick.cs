using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peabodyClick : MonoBehaviour {
    public GameObject textField;
    public TextMesh deathDescription1;
    public TextMesh deathDescription2;
    public TextMesh deathDescription3;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	    	
	}
    void OnMouseUpAsButton()
    {
        if(PersonClick.alreadyClicked == false)
        {
            Instantiate(textField, new Vector3(0, -3.5f, -.3f), Quaternion.identity);
            if (importantStuff.chooser == 0)
            {
                Instantiate(deathDescription1, new Vector3(0, -2.5f, -.5f), Quaternion.identity);
            }
            if (importantStuff.chooser == 1)
            {
                Instantiate(deathDescription2, new Vector3(0, -2.5f, -.5f), Quaternion.identity);
            }
            if (importantStuff.chooser == 2)
            {
                Instantiate(deathDescription3, new Vector3(0, -2.5f, -.5f), Quaternion.identity);
            }
        }
    }
}
