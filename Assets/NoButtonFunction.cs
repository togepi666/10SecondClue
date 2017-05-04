using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButtonFunction : MonoBehaviour {
    public GameObject yesButton;
    public TextMesh yesText;
    public TextMesh noText;
    public GameObject textField;
	// Use this for initialization
	void Start () {
        yesButton = GameObject.Find("YesButton(Clone)");
        textField = GameObject.Find("Textfield(Clone)");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUpAsButton()
    {
        Destroy(yesButton);
        Destroy(yesText);
        Destroy(noText);
        Destroy(textField);
        Destroy(gameObject);
    }
}
