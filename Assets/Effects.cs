using UnityEngine;
using System.Collections;

public class Effects{
	public GameObject options;
	public GameObject location;
	public GameObject exit;
	public GameObject more_options;
	public GameObject search;
	public GameObject settings;
	private Color effectColour=Color.green;
	public GameObject parent;
	private string shader;
	public Effects(GameObject parent){
		this.parent = parent;
	}
	public void hideOptions(bool hide){

		if (hide) {

			location.SetActive (false);
			exit.SetActive (false);
			more_options.SetActive (false);
			search.SetActive (false);
			settings.SetActive (false);

		} else

		{
			location.SetActive (true);
			exit.SetActive (true);
			more_options.SetActive (true);
			search.SetActive (true);
			settings.SetActive (true);

		}
	}
	public void showEffect(){
		
		parent.GetComponent<Renderer> ().material.color = effectColour;

	}

}
