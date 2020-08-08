using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
public GameObject board;
	private Rigidbody rb;
	// Use this for initialization
	void Start () {
			rb=board.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		board.transform.RotateAround(board.transform.forward,3*Time.deltaTime);
	}
}
