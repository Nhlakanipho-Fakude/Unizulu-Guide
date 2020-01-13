using UnityEngine;
using System.Collections;

public class LinkedIn : MonoBehaviour {
	public GameObject parent;
	public GameObject close;
	//private bool showG=false;
	public GameObject linkedIn;

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
		
		//showG = true;
		close.SetActive (true);
		parent.SetActive (false);
		transform.localScale += new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color -= new Color(40,40,40);

	}
}
