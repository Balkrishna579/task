using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collisonf : MonoBehaviour {
public GameObject model;
 public Text ttx;
	// Use this for initialization
	void Start () {
		
	} public void OnCollisionEnter(Collision col){
		if(col.gameObject.name=="Cube" ){
              SceneManager.LoadScene("final scene");
		} if(col.gameObject.tag=="torpedo"){
			ttx.text="task Completed";
             Destroy(this.gameObject);
			 Destroy(model);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
