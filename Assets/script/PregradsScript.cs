using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PregradsScript : MonoBehaviour {

    // Use this for initialization
    Pause pa;
    PlayMain unit;
    Vector2 bi;
   bool udar2;
   public int a=0, udarNumber;
    bool oon;
    public bool damag=false;
    public string name;
    int c=0;
    Animator ani;
	void Start () {
        ani = GetComponent<Animator>();
        unit = GameObject.FindObjectOfType<PlayMain>();
        pa= GameObject.FindObjectOfType<Pause>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (name == "block")
        {
            ani.SetInteger("chaqer", a);
            udar2 = unit.udar;
            
            if (a > udarNumber)
                Destroy(gameObject, 0.2f);
            
        }
       if( name == "ship")
        {if (damag == true && unit.Mera == false && !pa.pause)
                {
                
                    unit.life = unit.life - 1;
                    unit.rigidbody.velocity = Vector3.zero;
                    unit.rigidbody.AddForce(transform.up * 8.0F, ForceMode2D.Impulse);
                
                

                c++;
                if (c > 0)
                    damag = false;
            }
            unit.anima.SetBool("damag", damag);

        }
        

    }
   /* void OnTriggerEnter2D(Collider2D col)
    {  
  
    }*/
    private void OnCollisionEnter2D(Collision2D col)
    {
    }
    private void OnTriggerStay2D(Collider2D coll)
    {
       
        if (coll.gameObject.tag == "Unit" && name == "ship" && gameObject.tag == "damager" && udar2 == false)
        {
            if (c == 0)
            {

                damag = true;


                // unit.life = unit.life - 1;
            }
            if (c > 0)
                c = 0;
            /*     c++;
                 if (c > 5)
                     c = 0;
                 if (c > 0)
                     damag = false;*/
        }
     
    } 
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (name == "block" && coll.gameObject.tag == "Unit")
        {

            a++;

        }



        /*
         else
         {
             damag = false;
             if (c>0)
              c = 0;
         }*/
    }
    
}
