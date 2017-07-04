using UnityEngine;
using System.Collections;

public class EndLvl : MonoBehaviour {
    public int lvl;
    bool kir=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (kir)
        {
            PlayerPrefs.SetInt("lvl", lvl);
            PlayerPrefs.Save();
            Application.LoadLevel("urovni");

        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Unit")
            kir = true;
    }
}
