using UnityEngine;
using System.Collections;

public class lvlControler : MonoBehaviour {
    public string ComandName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        switch (ComandName)
        {
            case "1":
                Application.LoadLevel("lvl1");
                break;
            
            case "Play":
                Application.LoadLevel("urovni");
                break;
            case "Menu":
                Application.LoadLevel("Menu");
                break;
        }
        
    }
}
