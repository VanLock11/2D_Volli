using UnityEngine;
using System.Collections;

public class PlayMain : MonoBehaviour {
    Pause pas;
    PregradsScript Ship;
    public float jumpForse;
    new public Rigidbody2D rigidbody;
    public Animator anima;
    
    public float speed;
    private bool isGrounded = false;
    bool run;
   public bool udar=false;
    public int udarnumber=1;
    public int life=4;
    private PregradsScript preg;
    public bool Mera=false;
    SpriteRenderer colorControler;
    
    void Start() {
        // transform.position = new Vector2(0, 3);
        preg = GameObject.FindObjectOfType<PregradsScript>();
        rigidbody = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
        colorControler = GetComponent<SpriteRenderer>();
        Ship = GameObject.FindObjectOfType<PregradsScript>();
        pas = GameObject.FindObjectOfType<Pause>();
    }

    /*private void FixedUpdate()    //ubdate s menshey chistotoy 
    {                               //ubdate s menshey chistotoy 
                                    //ubdate s menshey chistotoy 
    }*/
    void Update() {
        CheckGrounded();
        if (life == 0)
            Mera = true;
        else Mera = false;
        if (Mera == false)
        {
            if (pas.pause == false)
            {

                rigidbody.simulated = true;

                if (Input.GetKey("a"))
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                    transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speed * 1);
                    run = true;
                }
                else if (Input.GetKey("d"))
                {
                    run = true;
                    transform.localScale = new Vector3(1, 1, 1);
                    transform.Translate(new Vector2(1, 0) * Time.deltaTime * speed);
                }
                else run = false;
                if (isGrounded && Input.GetKeyDown("w"))
                {

                    rigidbody.AddForce(transform.up * jumpForse, ForceMode2D.Impulse);
                    //  transform.localScale = new Vector3(-1, 1, 1);

                }
                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (udarnumber == 1)
                    {

                        ++udarnumber;
                    }
                    else{ --udarnumber; }
                    udar = true;
                  

                }
                else { udar = false; }
            }
        
            
            if (isGrounded)
                anima.SetBool("run", run);

            anima.SetBool("Jump", !isGrounded);
            if (udarnumber == 1)
                anima.SetBool("udar", udar);
            else anima.SetBool("udar1", udar);

        }
        anima.SetBool("Merav", Mera);
        }
    
    void damagon()
    {
        
    }
    private void CheckGrounded()
    {
        Collider2D[] coliders = Physics2D.OverlapCircleAll(transform.position, 0.01f);
        isGrounded = coliders.Length > 1;
    }
    /*void OnTriggerEnter2D(Collider2D col) //проверяем пересечение через Trigger 
    {;
    }*/
   
}
