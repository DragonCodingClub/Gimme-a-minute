using UnityEngine;
using System.Collections;
using System;

public class background_script : MonoBehaviour {
    private DateTime lastTimeWeStartedAArrow = DateTime.Now;
    private GameObject downArrowTemplate = null;
	private GameObject leftArrowTemplate = null;
	private GameObject rightArrowTemplate = null;
	private GameObject upArrowTemplate = null;
	public int newArrowCloneDelay = 5;
	//public int arrowDistroy = 0;
    
    
    // Use this for initialization
    void Start () {
        Debug.Log("background start has been called");
        downArrowTemplate = GameObject.Find("arrow_down");
		leftArrowTemplate = GameObject.Find("arrow_left");
		rightArrowTemplate = GameObject.Find("arrow_right");
		upArrowTemplate = GameObject.Find("arrow_up");
        //downArrow_script downArrowTemplate = GetComponent( downArrowType ) as downArrow_script;
}
	
	// Update is called once per frame
	void Update () {
        DateTime currentTime = DateTime.Now;
        TimeSpan delta = currentTime - lastTimeWeStartedAArrow;
		if (delta.TotalSeconds > newArrowCloneDelay)
        {
            Debug.Log("arrow moved");
            lastTimeWeStartedAArrow = currentTime;
            Debug.Log("cloned");
			GameObject newDownArrow = Instantiate(downArrowTemplate, new Vector3(1,-7,0), Quaternion.identity) as GameObject;
           // GameObject newDownArrow = newArrow.gameObject;
            newDownArrow.SetActive(true);

            
        }
		//GameObject newLeftArrow = Instantiate(leftArrowTemplate, new Vector3(-3,-7,0), Quaternion.identity) as GameObject;
		//GameObject newRightArrow = Instantiate(rightArrowTemplate, new Vector3(3,-7,0), Quaternion.identity) as GameObject;
		//GameObject newUpArrow = Instantiate(upArrowTemplate, new Vector3(-1,-7,0), Quaternion.identity) as GameObject;
		//newLeftArrow.SetActive(true);
		//newRightArrow.SetActive(true);
		//newUpArrow.SetActive(true);
    }
}
