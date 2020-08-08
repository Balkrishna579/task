using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loder : MonoBehaviour {
  public Dropdown gg;
  public Color c;
  public Material mat;
  
	// Use this for initialization
	void Start () {
		
        gg.onValueChanged.AddListener(delegate {
			logg(gg);
		});
		
		
	}
	
	// Update is called once per frame
	public void logg(Dropdown gg){
		if(gg.value ==0){
			mat.SetColor("_Color",Color.red);
		}else if(gg.value ==1){
			mat.SetColor("_Color",Color.green);
			
		}
		else if(gg.value ==2){
			mat.SetColor("_Color",Color.blue);
			
		}
		else{
			mat.SetColor("_Color",Color.yellow);
			
		}
           
	}
		
		
	
}