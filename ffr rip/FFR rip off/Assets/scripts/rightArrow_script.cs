using UnityEngine;
using System.Collections;

public class rightArrow_script : MonoBehaviour {
	public const int SPEED = 4;
	// Use this for initialization
	void Start () {
		gameObject.SetActive(true);

	}

	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.up * Time.deltaTime * SPEED);

	}
}
