using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonClick : MonoBehaviour {
    public GameObject TextField;
    public TextMesh accusing;
    public GameObject yesButton;
    public GameObject noButton;
    public TextMesh yesText;
    public TextMesh noText;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUpAsButton()
    {
        Instantiate(TextField, new Vector3(0,-3.6f,1),Quaternion.identity);
        Instantiate(accusing, new Vector3(0, -3.5f, -1), Quaternion.identity);
        Instantiate(yesButton, new Vector3(4,-4,-2), Quaternion.identity);
        Instantiate(noButton, new Vector3(6.5f,-4,-2), Quaternion.identity);
        Instantiate(yesText, new Vector3(4,-4,-3), Quaternion.identity);
        Instantiate(noText, new Vector3(6.5f,-4,-3), Quaternion.identity);
    }
}
