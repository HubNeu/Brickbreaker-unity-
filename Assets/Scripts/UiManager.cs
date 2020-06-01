using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UiManager : MonoBehaviour {

	int score = 0;
	public Text stext;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncrementScore(){
		score++;
		if (score==15) {
			Time.timeScale = 0; 
			stext.text = "You win!";
		}
	}
	
	public void loose(){
		Time.timeScale = 0; 
		stext.text = "Game over!";
	}
}
