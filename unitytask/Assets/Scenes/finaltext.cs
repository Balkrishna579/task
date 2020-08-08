using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class finaltext : MonoBehaviour {
    	public Text ttx;
        public Text sa;

	// Use this for initialization
	void Start () {
		
	}
	IEnumerator Timedelay(){
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene("final Scene");}
	
	// Update is called once per frame
	void Update () {
		if(sa.text=="Failed"){
			ttx.text=sa.text;
			StartCoroutine(Timedelay());
		}
		if(sa.text=="Task Completed"){
			ttx.text=sa.text;
		}
		
	}
}
