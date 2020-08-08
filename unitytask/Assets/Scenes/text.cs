using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class text : MonoBehaviour {
	public Text txt;
	public Text uni;

	// Use this for initialization
	void Start () {
		
		
	}
	IEnumerator Timedelay(){
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene("New Scene");}

		IEnumerator TimeDelay(){
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene("final Scene");}


	public void pri(Text txt){
		txt.text =uni.text;
		
	}
	// Update is called once per frame
	void Update () {
		pri(txt);
		if(txt.text=="Collision!"){
		StartCoroutine(Timedelay());}
		else if(txt.text=="Task Completed"){
         StartCoroutine(TimeDelay());
		}
	}
}
