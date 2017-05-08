using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class YesButtonFunction : MonoBehaviour {
    public GameObject noButton;
    public TextMesh[] allTextMeshes;
    public GameObject textField;
    public GameObject personClickedOn;
    public int personClicked;
    // Use this for initialization
    void Start () {
        noButton = GameObject.Find("NoButton(Clone)");
        textField = GameObject.Find("Textfield(Clone)");
        allTextMeshes = (TextMesh[])FindObjectsOfType(typeof(TextMesh));
        if(personClicked == 0)
        {
            personClickedOn = GameObject.Find("generalguy");
        }
        if(personClicked == 1)
        {
            personClickedOn = GameObject.Find("prettylady");
        }
        if(personClicked == 2)
        {
            personClickedOn = GameObject.Find("professor");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUpAsButton()
    {
        if(personClickedOn.GetComponent<PersonClick>().isMurderer)
        {
            SceneManager.LoadScene("transitionScene");
        }
        else
        {
            SceneManager.LoadScene("gameOver");
        }

    }
}
