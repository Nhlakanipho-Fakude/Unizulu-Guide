using UnityEngine;
using System.Collections;

public class ProfileButton : MonoBehaviour {
	public GameObject parent;
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
		parent.SetActive (false);
		transform.localScale += new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color -= new Color(40,40,40);

	}
}
