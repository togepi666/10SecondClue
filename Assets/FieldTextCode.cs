using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldTextCode : MonoBehaviour {
    public TextMesh accusing;
	// Use this for initialization
	void Start () {
        Instantiate(accusing, new Vector3(0, -3.5f, -1), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //Instantiating mesh text has been moved to PersonClicks.cs because that can do the same thing. 
    //Might delete this script.
}
