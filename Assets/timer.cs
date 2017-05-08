using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour {
    int number = 10;
	// Use this for initialization
	void Start () {
        InvokeRepeating("countDownFunction", 1, 1);
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<TextMesh>().text = "" + number;
        if(number <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
	}

    void  countDownFunction()
    {
        number--;
    }
    
}
