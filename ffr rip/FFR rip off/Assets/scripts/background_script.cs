using UnityEngine;
using System.Collections;
using System;

public class background_script : MonoBehaviour {
	bool appRun = true;
	private DateTime timeWeStartedTheSong = DateTime.Now;
    private GameObject downArrowTemplate = null;
	private GameObject leftArrowTemplate = null;
	private GameObject rightArrowTemplate = null;
	private GameObject upArrowTemplate = null;
	private int newArrowCloneDelay = 5;
	private long timeToLaunchNextNote = 0;
	private int positionOfNextNote = -1;
	private Song songToPlay = null;
	//public int arrowDistroy = 0;
	private Note[] noteArray = null;
    
    // Use this for initialization
    void Start () {
		songToPlay = new SongImpl ();
		noteArray = songToPlay.getNotes ();
		Note firstNote = noteArray [0];
		positionOfNextNote = 0;
		timeToLaunchNextNote = firstNote.getMillisFromStart ();
        Debug.Log("background start has been called");
        downArrowTemplate = GameObject.Find("arrow_down");
		leftArrowTemplate = GameObject.Find("arrow_left");
		rightArrowTemplate = GameObject.Find("arrow_right");
		upArrowTemplate = GameObject.Find("arrow_up");
        //downArrow_script downArrowTemplate = GetComponent( downArrowType ) as downArrow_script;

		//Music
		GameObject audio = GameObject.Find("Audio_Source");
		AudioSource audioConv = audio.GetComponent<AudioSource> ();
		//AudioSource audioConv = (AudioSource)audio;
		audioConv.Play ();
}
		

	// Update is called once per frame
	void Update () {
		if (appRun == false) {
			return;
		}

		DateTime currentTime = DateTime.Now;
		TimeSpan delta = currentTime - timeWeStartedTheSong;
		if (delta.TotalMilliseconds > timeToLaunchNextNote) {
			Debug.Log ("arrow moved");
			Debug.Log ("cloned");
			//increments note position, Stops if out of notes
			positionOfNextNote = positionOfNextNote + 1;
			if (noteArray.Length <= positionOfNextNote) {
				Debug.Log ("Exit Now");
				appRun = false;
				return;
			}

			GameObject newDownArrow = Instantiate (downArrowTemplate, new Vector3 (1, -7, 0), Quaternion.identity) as GameObject;
			// GameObject newDownArrow = newArrow.gameObject;
			newDownArrow.SetActive (true);
			Note theNextNote = noteArray [positionOfNextNote];
			timeToLaunchNextNote = theNextNote.getMillisFromStart ();

		}



		if (Input.GetKeyDown("d") ) {
			Debug.Log("d key was pressed");
			//test if arrow is in right place when d is pressed



	}

		//GameObject newLeftArrow = Instantiate(leftArrowTemplate, new Vector3(-3,-7,0), Quaternion.identity) as GameObject;
		//GameObject newRightArrow = Instantiate(rightArrowTemplate, new Vector3(3,-7,0), Quaternion.identity) as GameObject;
		//GameObject newUpArrow = Instantiate(upArrowTemplate, new Vector3(-1,-7,0), Quaternion.identity) as GameObject;
		//newLeftArrow.SetActive(true);
		//newRightArrow.SetActive(true);
		//newUpArrow.SetActive(true);
	}

}
