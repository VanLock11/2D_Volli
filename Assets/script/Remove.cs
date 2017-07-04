using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Remove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        PlayerPrefs.SetInt("lvl",1);
        PlayerPrefs.Save();
    }
}
