using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour {
    public bool pause=false;
    public GameObject contr;
   int num;
	// Use this for initialization
	void Start () {
        num = 0;
    }
	
	// Update is called once per frame
	void Update () {
        if (num == 0 || num == 2)
        {
            pause = false;
            Time.timeScale =1;
        }
        else if (num == 1)
        {
            pause = true;
            Time.timeScale = 0;
        }

        contr.SetActive(pause);
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
    private void OnMouseDown()
    {
       
        if (num == 0 || num == 2)
        {
            num = 1;
        }
        else if (num == 1)
            num = 2;
    }
}
