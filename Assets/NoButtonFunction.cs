using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoButtonFunction : MonoBehaviour {
    public GameObject yesButton;
    public TextMesh[] allTextMeshes;
    public GameObject textField;
	// Use this for initialization
	void Start () {
        yesButton = GameObject.Find("YesButton(Clone)");
        textField = GameObject.Find("Textfield(Clone)");
        allTextMeshes =(TextMesh[]) FindObjectsOfType(typeof(TextMesh));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUpAsButton()
    {
        Destroy(yesButton);
        Destroy(textField);
        Destroy(allTextMeshes[0]);
        Destroy(allTextMeshes[1]);
        Destroy(allTextMeshes[2]);
        Destroy(gameObject);

    }
}
