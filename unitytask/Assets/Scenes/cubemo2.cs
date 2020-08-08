using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cubemo2 : MonoBehaviour {
	public Camera cam;
	private Vector3 offset;
	public bool ground=true;
	public float speed;
	public float turnspeed;
	public Rigidbody rb;
	public GameObject torpedo;
	public GameObject txt;
	private Text txx;
	public Text tks;
	private Rigidbody tor;
	private Vector3 torpos;
	private Vector3 offsettor;
	private Vector3 ini;
	private Quaternion torposa;
	private Quaternion offsettora;
	private Quaternion inia;
	public float count=0.0f;
	public float cou;

	// Use this for initialization
	void Start () {
		rb =GetComponent<Rigidbody>();
		txx=txt.GetComponent<Text>();
		ini=transform.position;
		inia=transform.rotation;
		offset =transform.position-cam.transform.position;
		offsettora=cam.transform.rotation;
		torposa=torpedo.transform.rotation;
		tor=torpedo.GetComponent<Rigidbody>();
		offsettor=transform.position-torpedo.transform.position;
	}
	public void OnCollisionEnter(Collision col){
		if(  col.gameObject.tag=="surface"){
			ground=true;
		}
		if(col.gameObject.name=="Plain"){
			ground=true;
		}
		if(col.gameObject.name=="Terrain"){
			txx.text="Failed ";
		
            StartCoroutine(Timedelay());

		}}
		IEnumerator Timedelay(){
		yield return new WaitForSeconds(2);
		txx.text=" ";
		tks.text=" ";
		transform.position=ini;
		transform.rotation=inia;
		torpedo.transform.rotation=torposa;
		cam.transform.rotation=offsettora;

			cam.transform.position=transform.position+ offset;
			torpedo.transform.position=transform.position+offsettor;}
			

	
	
	// Update is called once per frame
	void Update () {
		if(tks.text=="Failed"){
			txx.text=tks.text;
			
			StartCoroutine(Timedelay());

		}
		if(tks.text=="Task Completed"){
			txx.text=tks.text;
			SceneManager.LoadScene("final scene");
			}
		torpedo.transform.position=transform.position-offsettor;
		cam.transform.position=transform.position-offset;
		transform.Translate(-1*speed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,-1*speed*Input.GetAxis("Vertical")*Time.deltaTime);
		if(Input.GetKey(KeyCode.D)){
			transform.RotateAround(Vector3.up,turnspeed*Time.deltaTime);
			cam.transform.RotateAround(Vector3.up,turnspeed*Time.deltaTime);
			torpedo.transform.RotateAround(Vector3.up,turnspeed*Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.A)){
			transform.RotateAround(Vector3.up,-1f*turnspeed*Time.deltaTime);
			cam.transform.RotateAround(Vector3.up,-1f*turnspeed*Time.deltaTime);
			torpedo.transform.RotateAround(Vector3.up,-1f*turnspeed*Time.deltaTime);}
		     cou=count;
			 if(cou !=count){
				 tor.MovePosition(torpedo.transform.position+(transform.forward*1200));
			 }
			if(Input.GetKey(KeyCode.S)){
				GameObject clone=null;
				if(clone == null){
			clone =	(GameObject)Instantiate(torpedo,torpedo.transform.position,torpedo.transform.rotation);}
				}

			if(Input.GetButtonDown("Jump") && ground){
			rb.AddForce(Vector3.up*1200);
		
            ground=false;
		}
		Debug.Log(transform.localRotation.eulerAngles);
	}
}
