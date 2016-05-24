using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {

		offset = gameObject.GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
	
		gameObject.GetComponent<Transform>().position = player.transform.position + offset;
	}
}
