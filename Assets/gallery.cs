using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class gallery : MonoBehaviour {
	public GameObject close;
	private int count=0;
	public GameObject options;
	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
		close.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void showGallery(){

		gameObject.SetActive (true);
		close.SetActive (true);
		options.SetActive(false);

	}
	public void onButtonClick(){
		count += 1;

		if (count == 1) {
			gameObject.SetActive (false);
			close.SetActive (false);
			options.SetActive (true);
		} else if(count==2){
			gameObject.SetActive (true);
			count = 0;

		}


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
		transform.localScale += new Vector3(0.05f, 0.05f , 0f);
		//or
		transform.GetComponent<SpriteRenderer>().color -= new Color(40,40,40);
	

	}
}
