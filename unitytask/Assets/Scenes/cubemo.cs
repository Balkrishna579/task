using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cubemo : MonoBehaviour {
	public Camera cam;
	public Camera cam1;
    public float speed;
	public float turnspeed;
	private Vector3 offset;
	private Vector3 offset2;
	public Rigidbody rb;
	public bool ground=true;
	public GameObject txt;
	private Text txx;
	private bool trc=false;
	private Vector3 ini;
	
	private Quaternion offsettora;
	private Quaternion inia;
	
	public Material mate;
	
	// Use this for initialization
	void Start () {
      offset=cam.transform.position-transform.position;
	  rb=GetComponent<Rigidbody>();
	 
	   txx=txt.GetComponent<Text>();
	  ini=transform.position;
	  	inia=transform.rotation;
		  offsettora=cam.transform.rotation;
	  
	  offset2=cam1.transform.position-transform.position;

	 
		
	}
	public void OnCollisionEnter(Collision col){
		if( col.gameObject.tag=="surface"){
			ground=true;
		}
		if(col.gameObject.tag=="obstask3" || col.gameObject.name=="Terrain"){
			trc=true;
			
			}
			if(col.gameObject.tag=="finish"){
				txx.text="Task Completed";
				StartCoroutine(TimeDelay());
				
			}}
	IEnumerator TimeDelay(){
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene("final scene");}

	
	
	
	IEnumerator Timedelay(){
		yield return new WaitForSeconds(1);
		transform.position=ini;
		cam.transform.rotation=offsettora;
		transform.rotation=inia;
		
			cam.transform.position=transform.position+offset;
            txx.text=" ";
		   
			trc=false;}
			

		
			

	
	// Update is called once per frame
	void Update () {
		
		
		
		cam.transform.position=offset+transform.position;
		cam1.transform.position=offset+transform.position;
		if(transform.position.y<=1){
			ground=true;
		}
	
		transform.Translate(speed*Input.GetAxis("Vertical")*Time.deltaTime,0f,-1f*speed*Input.GetAxis("Horizontal")*Time.deltaTime);
		if(Input.GetKey(KeyCode.W)){
			transform.RotateAround(Vector3.up,turnspeed*Time.deltaTime);
			cam.transform.RotateAround(Vector3.up,turnspeed*Time.deltaTime);
		}
		else if(Input.GetKey(KeyCode.S)){
			transform.RotateAround(Vector3.up,-1f*turnspeed*Time.deltaTime);
			cam.transform.RotateAround(Vector3.up,-1f*turnspeed*Time.deltaTime);
		}
		if(Input.GetButtonDown("Jump") && ground){
			rb.AddForce(Vector3.up*1200);
            ground=false;
		}
		
	
	  if(trc==true){
		  txx.text = "Collision!";
			StartCoroutine(Timedelay());
			
		}}
	
	
}
