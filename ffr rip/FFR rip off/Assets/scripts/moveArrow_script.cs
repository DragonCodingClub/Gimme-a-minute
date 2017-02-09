using UnityEngine;
using System.Collections;

public class moveArrow_script : MonoBehaviour {
	public int SPEED;
	// Use this for initialization
	void Start () {
		gameObject.SetActive(true);

	}

	// Update is called once per frame
	void Update () {

		transform.Translate(Vector3.up * Time.deltaTime * SPEED);

	}
}
