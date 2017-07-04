using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class monsterControler : MonoBehaviour {
    public GameObject Unit;
    public float speedMonster, herr,bar;
    bool unitinzone;
    bool Bach, Bdzax;
    private Vector2 ach, dzax;
	// Use this for initialization
	void Start () {
        ach = new Vector2(transform.position.x + 1.1f, transform.position.y);
        dzax = new Vector2(transform.position.x - 1.1f, transform.position.y);
	}

    // Update is called once per frame
    void Update() {
        ach.y = transform.position.y;
        dzax.y = transform.position.y;

        if (transform.position.x - Unit.transform.position.x < 0 && Unit.transform.position.y-transform.position.y<bar-transform.position.y)
        {

            if (Unit.transform.position.x - transform.position.x <= herr)
            {
                unitinzone = true;
               
                    transform.localScale = new Vector3(1, 1, 1);
                
                transform.Translate(new Vector2(1, 0) * Time.deltaTime * speedMonster);
            }
            else unitinzone = false;
        }
        else if (transform.position.x - Unit.transform.position.x > 0 && Unit.transform.position.y - transform.position.y < bar - transform.position.y)
        {
            if (transform.position.x - Unit.transform.position.x <= herr )
            {
                unitinzone = true;
                
                    transform.localScale = new Vector3(-1, 1, 1);
                transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speedMonster * -1);
            }
            else unitinzone = false;
        }
        else unitinzone = false;

        if (!unitinzone)
        { 
            if (transform.position.x==ach.x)
            {
                Bach = true;
                Bdzax = false;
            }
            else if (transform.position.x == dzax.x)
            {
                Bdzax = true;
                Bach = false;
            }
            else if(!Bdzax&& !Bach)
            {
                Bdzax = true;
                Bach = false;
            } 

            if (Bdzax)
            {
                if (ach.x - transform.position.x > 0)
                    transform.localScale = new Vector3(1, 1, 1);
                else transform.localScale = new Vector3(-1, 1, 1);

                transform.position = Vector2.MoveTowards(transform.position, ach, Time.deltaTime * (speedMonster - 0.5f));
            }
            else if (Bach)
            {
                if (dzax.x - transform.position.x < 0)
                    transform.localScale = new Vector3(-1, 1, 1);
                else transform.localScale = new Vector3(1, 1, 1);

                transform.position = Vector2.MoveTowards(transform.position, dzax, Time.deltaTime * (speedMonster - 0.5f));
            }
    }
    }
   


}
