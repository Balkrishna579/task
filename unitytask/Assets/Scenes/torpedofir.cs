using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torpedofir : MonoBehaviour {
	public GameObject torpedo;
	public GameObject cube;
	public Camera cam;
	public Rigidbody tor;
	public float speed;
	public float turnspeed;
	public GameObject model;
	public GameObject pass;
	public bool forw =true;
	
	public bool ground=true;
	

	// Use this for initialization
	void Start () {
		tor=torpedo.GetComponent<Rigidbody>();
		
		
	

	}
	public void OnCollisionEnter(Collision col){
		
		if(col.gameObject.name=="cube"){
			ground=true;
			}}
	
	// Update is called once per frame
	void Update () {
		
			
		transform.position+=transform.forward*speed*Time.deltaTime*-1;
		if(Input.GetButtonDown("Jump") && ground){
			tor.AddForce(Vector3.up*1200);
		
            ground=false;
		}
		
	}
}
