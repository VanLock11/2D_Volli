using UnityEngine;
using System.Collections;

public class BuffScript : MonoBehaviour {

    PlayMain unit;
   
	void Start () {
        unit = GameObject.FindObjectOfType<PlayMain>();
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Unit")
        {if (unit.life<4)
            unit.life++;
            Destroy(gameObject);

        }
    }
}
