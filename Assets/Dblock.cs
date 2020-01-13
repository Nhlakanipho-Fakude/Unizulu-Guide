using UnityEngine;
using System.Collections;
using Vuforia;
using UnityEngine.UI;
public class Dblock : MonoBehaviour, ITrackableEventHandler
{
	private TrackableBehaviour mTrackableBehaviour;
	public GameObject options;
	public GameObject menuButton;
	public bool scan = false;
	public GameObject scanner;
	private bool hasAppeared = false;
	private bool hideScanner=false;
	void update(){
		if(hideScanner)
			scanner.SetActive (false);
	}
	void Start()
	{
		TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
		options.SetActive (false);
	}
	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
		    newStatus == TrackableBehaviour.Status.TRACKED ||
		    newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED) {
			hideScanner = true;
			//scanner.SetActive (false);
			options.SetActive (false);
			menuButton.SetActive (true);
			hasAppeared = true;
			scanner.SetActive (false);
		} else {
			hideScanner = false;
			options.SetActive (true);
			menuButton.SetActive (true);
			if (scan) {
				scanner.SetActive (true);
			}
			if(hasAppeared)
				scanner.SetActive (true);
		}
	}
	}  
	
