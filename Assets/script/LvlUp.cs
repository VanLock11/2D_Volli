using UnityEngine;
using System.Collections;
using  System.IO;

public class LvlUp : MonoBehaviour {
    public int lvlnumber;
    
    public bool block;
    public GameObject zamok;
    
	// Use this for initialization
	void Start () {

        block = false;
    }

    // Update is called once per frame
    void Update () {

        if (lvlnumber <= PlayerPrefs.GetInt("lvl"))
        {
            zamok.SetActive(false);
            block = true;

        }
        else {
            zamok.SetActive(true);
            block = false;
        }



    }
    void OnMouseDown()
    {
        if (block)
        {
          
                    Application.LoadLevel(lvlnumber + 1);
          
        }
    }
}
