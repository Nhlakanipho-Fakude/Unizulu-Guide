using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Scanner : MonoBehaviour {
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;
	public Transform LoadingBar;
	public Text textScan;
	// Use this for initialization
	void Start () {
		gameObject.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
		if(currentAmount<100){

			if(currentAmount<25)
				textScan.GetComponent<Text> ().color = Color.cyan;
			else if(currentAmount<45)
				textScan.GetComponent<Text> ().color = Color.blue;
			else if(currentAmount<55)
				textScan.GetComponent<Text> ().color = Color.black;
			else if(currentAmount<65)
				textScan.GetComponent<Text> ().color = Color.gray;
			else if(currentAmount<75)
				textScan.GetComponent<Text> ().color = Color.green;
			else if(currentAmount<85)
				textScan.GetComponent<Text> ().color = Color.red;
			else if(currentAmount<95)
				textScan.GetComponent<Text> ().color = Color.magenta;

			currentAmount += speed * Time.deltaTime;
		}
		else {
			currentAmount = 0;
			textScan.GetComponent<Text> ().color = Color.red;

		}
		LoadingBar.GetComponent<UnityEngine.UI.Image> ().fillAmount = currentAmount / 100;
	}
}
