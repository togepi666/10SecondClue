using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour {

	public float fadeSpeed = 2f;

	public bool fadingOut = false;
	SpriteRenderer ourSprite;

	public string sceneToSwitchToWhenDoneFadingIn = "ActualGame";

	void Start() {
		ourSprite = GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update () {

		if (fadingOut) {
			float alpha = ourSprite.color.a;
			alpha += fadeSpeed*Time.deltaTime;
			if (alpha > 1f) {
				alpha = 1;
				SceneManager.LoadScene(sceneToSwitchToWhenDoneFadingIn);
			}
			ourSprite.color = new Color(ourSprite.color.r, ourSprite.color.g, ourSprite.color.b, alpha);
		}
		else {
			float alpha = ourSprite.color.a;
			alpha -= fadeSpeed*Time.deltaTime;
			if (alpha < 0f) {
				alpha = 0;
			}
			ourSprite.color = new Color(ourSprite.color.r, ourSprite.color.g, ourSprite.color.b, alpha);
		}

		if (Input.GetKeyDown(KeyCode.Space)) {
			fadingOut = !fadingOut;
		}

	}
}
