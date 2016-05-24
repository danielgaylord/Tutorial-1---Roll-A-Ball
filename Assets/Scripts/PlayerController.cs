using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public GUIText countText;
	public GUIText winText;
	private int count;

	// Use this for initialization
	void Start () {
	
		count = 0;
		SetCountText ();
		winText.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		gameObject.GetComponent<Rigidbody> ().AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter (Collider other) {
	
		if (other.gameObject.tag == "PickUp") {

			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText() {

		countText.text = "Count: " + count.ToString ();

		if (count >= 12) {

			winText.text = "YOU WIN!";
		}
	}
}