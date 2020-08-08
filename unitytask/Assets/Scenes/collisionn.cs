using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionn : MonoBehaviour {

	public GameObject model;
	void Start () {
		
	} public void OnCollisionEnter(Collision col){
		if(col.gameObject.name=="Cube" ){
              SceneManager.LoadScene("final scene");
		} if(col.gameObject.tag=="torpedo"){
             Destroy(this.gameObject);
			 Destroy(model);
		}
	}
	
	
	void Update () {
		
	}
}
