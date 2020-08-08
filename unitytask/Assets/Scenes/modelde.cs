using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class modelde : MonoBehaviour {
       public Text ttx;
	// Use this for initialization
	void Start () {
		
	}
	public void OnCollisionEnter(Collision col){
		if(col.gameObject.name=="Cube" || col.gameObject.tag=="torpedo"){
			ttx.text="Failed";
			
			
}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
