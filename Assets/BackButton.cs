using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

	public GameObject panel,options;
	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	void OnMouseEnter(){
		transform.localScale -= new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color += new Color(40,40,40);

	}

	void OnMouseEixt(){
		transform.localScale += new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color -= new Color(40,40,40);

	}
	void OnMouseUp()
	{
		gameObject.SetActive (false);
		panel.SetActive (true);
		options.SetActive (false);
		transform.localScale += new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color -= new Color(40,40,40);
	}
}
