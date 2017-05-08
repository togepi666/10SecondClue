using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class importantStuff : MonoBehaviour {
    public static int chooser = 0;
    public GameObject suspectGeneral;
    public GameObject suspectLady;
    public GameObject suspectProfessor;
    public GameObject knife;
    public GameObject frap;
    public GameObject gun;
    public GameObject shroud;
    public int rand1;
    public int rand2;
    public int rand3;
    public Vector3[] spawnPoints;    // Use this for initialization
    void Start () {
        spawnPoints = new Vector3[3];
        chooser = (int)Random.Range(0, 3);
        if (chooser == 2)
        {
            suspectGeneral.GetComponent<PersonClick>().isMurderer = true;
        }
        if (chooser == 1)
        {
            suspectLady.GetComponent<PersonClick>().isMurderer = true;
        }
        if (chooser == 0)
        {
            suspectProfessor.GetComponent<PersonClick>().isMurderer = true;
        }

        spawnPoints[0] = new Vector3(2.1f, .3f, 0);
        spawnPoints[1] = new Vector3(-2.4f, .6f, 0);
        spawnPoints[2] = new Vector3(-3.7f, -1.8f, 0);
        rand1 = Random.Range(0, 3);
        rand2 = Random.Range(0, 3);
        while (rand2 == rand1)
        {
            rand2 = Random.Range(0, 3);
        }
        rand3 = Random.Range(0, 3);
        while (rand3 == rand1 || rand3 == rand2)
        {
            rand3 = Random.Range(0, 3);
        }
        Instantiate(shroud, spawnPoints[rand1], Quaternion.identity);
        Instantiate(shroud, spawnPoints[rand2], Quaternion.identity);
        Instantiate(shroud, spawnPoints[rand3], Quaternion.identity);
        Instantiate(knife, spawnPoints[rand1], Quaternion.identity);
        Instantiate(frap, new Vector3(spawnPoints[rand2].x, (spawnPoints[rand2].y - .2f), spawnPoints[rand2].z), Quaternion.identity);
        Instantiate(gun, spawnPoints[rand3], Quaternion.identity);


    }

    // Update is called once per frame
    void Update () {
		
	}
}
