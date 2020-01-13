using UnityEngine;
using System.Collections;
using System;
public class getStaffInfo : MonoBehaviour {
	public string id;
	public UnityEngine.UI.Text description,cellNumber,officeNumber,emailAddress,qualifications,staffName;
	public GameObject linkedIn;
	public GameObject profileImage;
	public UnityEngine.UI.Image availability;
	// Use this for initialization
	void Start (){
		StartCoroutine (getContacts ());
		StartCoroutine (getAbout_me ());
		StartCoroutine (getQualifications());
		StartCoroutine (profilePic ());
		StartCoroutine (getStaffData());
		StartCoroutine (getAvailability ());
	}
	
	// Update is called once per frame
	void Update () {
		/*
		StartCoroutine(getContacts ());
		StartCoroutine(getAbout_me());
		StartCoroutine(getQualifications ());
		*/
	}

	IEnumerator getContacts(){
		// Start a download of the given URL
		var www = new WWW("http://sboworks.co.za/unizulu/app/contacts.php?id="+id);            
		// wait until the download is done
		yield return www;
		string data = www.text;
		if (data.Length>1) {
		JSONObject json = new JSONObject (www.text);
			System.Text.StringBuilder cell =  new System.Text.StringBuilder(json.GetField ("cellNumber").ToString ());
			cell [0] = ' ';
			cell [cell.Length - 1] = ' ';
			cellNumber.text = cell.ToString() ;
			System.Text.StringBuilder office =  new System.Text.StringBuilder(json.GetField("officeNumber").ToString());
			office [0] = ' ';
			office [office.Length - 1] = ' ';
			officeNumber.text = office.ToString();
			System.Text.StringBuilder email =  new System.Text.StringBuilder(json.GetField("emailAddress").ToString());
			email [0] = ' ';
			email [email.Length - 1] = ' ';
			emailAddress.text = email.ToString();
			System.Text.StringBuilder linkedIn_url =  new System.Text.StringBuilder(json.GetField("linkedIn").ToString());
			linkedIn_url [0] = ' ';
			linkedIn_url [linkedIn_url.Length - 1] = ' ';
			linkedIn.GetComponent<sampleWebView> ().setURL (linkedIn_url.ToString());
		}
	}
	IEnumerator getAbout_me(){
		// Start a download of the given URL
		var www = new WWW("http://sboworks.co.za/unizulu/app/about_me.php?id="+id);            
		// wait until the download is done
		yield return www;
		string data = www.text;
		if (data.Length>1) {
			description.text = www.text;
		}


	}
	IEnumerator getQualifications(){
		// Start a download of the given URL
		var www = new WWW("http://sboworks.co.za/unizulu/app/staffName.php?id="+id);            
		// wait until the download is done
		yield return www;
		string data = www.text;
		if (data.Length>1) {

		}

	}
	IEnumerator getStaffData(){
		// Start a download of the given URL
		var www = new WWW("http://sboworks.co.za/unizulu/app/staffName.php?id="+id);            
		// wait until the download is done
		yield return www;
		string data = www.text;
		if (data.Length>1) {
			staffName.text =data;
		}
	}
	IEnumerator profilePic(){
		// Start a download of the given URL
		var www = new WWW("http://sboworks.co.za/unizulu/app/staffPic.php?id="+id);            
		// wait until the download is done
		yield return www;
		string data = www.text;
		if (data.Length>1) {
			// Create a texture in DXT1 format

			Texture2D texture = new Texture2D (www.texture.width,www.texture.height, TextureFormat.DXT1, false);

			// assign the downloaded image to sprite

			www.LoadImageIntoTexture (texture);
			Rect rec = new Rect (0, 0,www.texture.width,www.texture.height);
			Sprite spriteToUse = Sprite.Create (texture, rec, new Vector2 (0.5f, 0.5f), 100);
			profileImage.GetComponent<SpriteRenderer> ().sprite = spriteToUse;

			www.Dispose ();
			www = null;
		}
	}
	IEnumerator getAvailability(){
		// Start a download of the given URL
		var www = new WWW("http://sboworks.co.za/unizulu/app/available.php?id="+id);            
		// wait until the download is done
		yield return www;
		UnityEngine.UI.Image yes = Resources.Load("yes", typeof(UnityEngine.UI.Image)) as UnityEngine.UI.Image;
		UnityEngine.UI.Image no = Resources.Load("no", typeof(UnityEngine.UI.Image)) as UnityEngine.UI.Image;
		string data = www.text;
		if (data.Length>1) {
			int x = Convert.ToInt32 (data);
			if (x == 1) {
				availability = yes;
			} else {
				availability = no;
			}
		}
	}
}
