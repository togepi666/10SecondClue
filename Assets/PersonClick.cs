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
    public static bool alreadyClicked = false;
    public bool isMurderer = false;
    public int personClicked;


    // Use this for initialization
    void Start () {
        alreadyClicked = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
    void OnMouseUpAsButton()
    {
        if (alreadyClicked == false)
        {
            alreadyClicked = true;
            Instantiate(TextField, new Vector3(0, -3.4f, -1), Quaternion.identity);
            Instantiate(accusing, new Vector3(0, -3.4f, -2), Quaternion.identity);
            Instantiate(yesButton, new Vector3(4, -4, -2), Quaternion.identity);
            Instantiate(noButton, new Vector3(6.5f, -4, -2), Quaternion.identity);
            Instantiate(yesText, new Vector3(4, -4, -3), Quaternion.identity);
            Instantiate(noText, new Vector3(6.5f, -4, -3), Quaternion.identity);
            yesButton.GetComponent<YesButtonFunction>().personClicked  = personClicked;
        }
    }

}
