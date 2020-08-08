using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneloder : MonoBehaviour {

	// Use this for initialization
	
	public void loadscene(){
		SceneManager.LoadScene("New Scene");
	}
}
