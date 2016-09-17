using UnityEngine;
using System.Collections;

public class Jewel : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame and it is ran all the time
	void Update () {

		float speed = 0.05f;

		if (Input.GetKeyDown ("space")) {
			Debug.Log ("Space key was just pressed!");
		}
		if (Input.GetKeyUp ("space")) {
			Debug.Log ("Space key was just released!");
		}

		if (Input.GetKey ("down") || Input.GetKey("s"))
		{

			this.transform.position = new Vector3 (
				this.transform.position.x,
				this.transform.position.y - speed,
				this.transform.position.z
			);
		}

		if (Input.GetKey ("up") || Input.GetKey("w"))
		{

			this.transform.position = new Vector3 (
				this.transform.position.x ,
				this.transform.position.y + speed,
				this.transform.position.z
			);
		}


		if (Input.GetKey ("right") || Input.GetKey("d"))
		{

			this.transform.position = new Vector3 (
				this.transform.position.x + speed,
				this.transform.position.y,
				this.transform.position.z
			);
		}

		if (Input.GetKey ("left") || Input.GetKey("a"))
		{

			this.transform.position = new Vector3 (
				this.transform.position.x - speed,
				this.transform.position.y,
				this.transform.position.z
			);
		}


	}
}

