using UnityEngine;
using System.Collections;

public class Staff : MonoBehaviour {
	// Use this for initialization
	public TextMesh staffName;
	public string id;
	public GameObject staffDialog;
	void Start() {
		StartCoroutine(getStaffData());
		StartCoroutine(profilePic());
	}
	// Update is called once per frame
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
			gameObject.GetComponent<SpriteRenderer> ().sprite = spriteToUse;

			www.Dispose ();
			www = null;
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
	void OnMouseDown(){
		staffDialog.SetActive (true);
	}
}
