using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolAndHome : MonoBehaviour {
    EndLvl end_LvL;
    public string comand_name;
	// Use this for initialization
	void Start () {
        end_LvL = GameObject.FindObjectOfType<EndLvl>();
	}
	
	// Update is called once per frame
	void Update () {
        

    }
    private void OnMouseDown()
    {
        switch (comand_name)
        {
            case "recol":
                Application.LoadLevel(end_LvL.lvl);
                break;
            case "home":
                Application.LoadLevel("Menu");
              
              
                break;
            default:
                break;
        }
    }
   
}
