using UnityEngine;
using System.Collections;
using Vuforia;
public class panel : MonoBehaviour {
	public GameObject options;
	public GameObject menu;
	public GameObject backButton;
	public GameObject scanner;
	public GameObject messageBox;
	// Use this for initialization
	void Start () {
	
	}
	void update(){
		menu.SetActive (false);
	}
	public void startTracking(){
		gameObject.SetActive (false);
		scanner.SetActive (true);
		menu.SetActive (true);
		messageBox.SetActive (false);
		TrackerManager.Instance.GetTracker<ObjectTracker>().Start();
		GetComponent<Dblock> ().scan = true;

	}
	public void showOptions(){
		options.SetActive (true);
		backButton.SetActive(true);
		gameObject.SetActive (false);
		GetComponent<Dblock> ().scan = false;

	}
}
