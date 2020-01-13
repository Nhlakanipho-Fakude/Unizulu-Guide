using UnityEngine;
using System.Collections;
using Vuforia;

public class Search : MonoBehaviour {
	//region for all the variables
#region variables
	//Public Variables
	public GameObject options;
	public GameObject location;
	public GameObject more;
	public GameObject exit;
	public GameObject settings;
	public GameObject about;

	// Private variables
	private int count=0;
	private bool showGui= false; 

#endregion
	void update(){
		OnGUI ();

	}
	void OnGUI(){
		if (showGui) {
			
			string value = "Search";

			value = GUI.TextField ( new Rect (Screen.width/2-Screen.width/4, 250, 100, 25), value,60);
		
			if (GUI.Button (new Rect (Screen.width/2-Screen.width/4+Screen.width/8, 270, 100, 30), "Search")) {
				showGui = false;
			}

		}
	}
	//custom methods region
#region methonds
	public void hide(){
		
		location.SetActive (false);
		more.SetActive (false);
		exit.SetActive (false);
		settings.SetActive (false);
		about.SetActive (false);

	}
	public void show(){
		location.SetActive (true);
		more.SetActive (true);
		exit.SetActive (true);
		settings.SetActive (true);
		about.SetActive (true);
		options.SetActive (true);

	}
		
#endregion
	void OnMouseEnter() {
		transform.localScale -= new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color += new Color(40,40,40);

	}
	void OnMouseExit(){

		transform.localScale += new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color -= new Color(40,40,40);
	}
	void OnMouseUp()
	{
		
		++count;
		if (count == 1) {
			showGui = true;
			hide ();

		} else if (count == 2) {
			show ();
			count = 0;
			showGui = false;

		}
		transform.localScale += new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color -= new Color(40,40,40);


	}
}
