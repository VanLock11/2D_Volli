using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextLife : MonoBehaviour {
    PlayMain unit;
    public GameObject Over;
    Pause pa;
    public Text LifeUi;
    // Use this for initialization
    void Start () {
        unit = GameObject.FindObjectOfType<PlayMain>();
        pa = GameObject.FindObjectOfType<Pause>();
    }
	
	// Update is called once per frame
	void Update () {
        LifeUi.text = unit.life.ToString();
        if (unit.life == 0 && !pa.pause )
            Over.SetActive(true);
        else Over.SetActive(!true);
    }
}
