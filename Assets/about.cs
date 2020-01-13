using UnityEngine;
using System.Collections;

public class about : MonoBehaviour {
	public GameObject options;
	public GameObject location;
	public GameObject more;
	public GameObject exit;
	public GameObject search;
	public GameObject settings;
	int count=0;
	public GameObject messageBox;

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {

	}
	public void hide(){
		messageBox.SetActive (true);
		location.SetActive (false);
		more.SetActive (false);
		exit.SetActive (false);
		settings.SetActive (false);
		search.SetActive (false);
	}
	public void show(){
		messageBox.SetActive (false);
		location.SetActive (true);
		more.SetActive (true);
		exit.SetActive (true);
		settings.SetActive (true);
		search.SetActive (true);
	}
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

			hide ();
		} else if (count == 2) {
			show ();
			count = 0;
		}

		transform.localScale += new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color -= new Color(40,40,40);
	}
}
