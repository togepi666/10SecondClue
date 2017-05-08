using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peabodyClick : MonoBehaviour {
    public GameObject textField;
    public TextMesh deathDescription;
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
            Instantiate(textField, new Vector3(0, -3.5f, -1), Quaternion.identity);
            Instantiate(deathDescription, new Vector3(0, -3.5f, -2), Quaternion.identity);
        }
    }
}
