﻿using UnityEngine;
using System.Collections;

public class StaffQualifications : MonoBehaviour {

	public GameObject parent;
	public GameObject staffInfo;
	public GameObject about, contacts, qualifications;
	public GameObject close;
	void start(){
		close.SetActive (true);
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
		parent.SetActive (false);
		staffInfo.SetActive (true);
		about.SetActive (false);
		contacts.SetActive (false);
		qualifications.SetActive (true);
		transform.localScale += new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color -= new Color(40,40,40);

	}
}