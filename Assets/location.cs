using UnityEngine;
using System.Collections;

public class location : MonoBehaviour {

	public GameObject more;
	public GameObject exit;
	public GameObject search;
	public GameObject settings;
	public GameObject about;
	int count=0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void hide(){

		more.SetActive (false);
		exit.SetActive (false);
		settings.SetActive (false);
		search.SetActive (false);
		about.SetActive (false);

	}
	public void show(){

		more.SetActive (true);
		exit.SetActive (true);
		settings.SetActive (true);
		search.SetActive (true);
		about.SetActive (true);
	

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
