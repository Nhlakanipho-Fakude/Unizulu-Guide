using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;
public class menuButton : MonoBehaviour {
	
	public GameObject options;
	private int count=0;
	public Sprite close, menu;
	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
	}
	public void showMenu(){
		if(count==0){
			gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = close;
		options.SetActive (true);
			count++;
		}
		else {
			gameObject.GetComponent<UnityEngine.UI.Image> ().sprite = menu;
			options.SetActive (false);
			count = 0;
		}
	}

}
