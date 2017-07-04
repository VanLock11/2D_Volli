 using UnityEngine;
using System.Collections;

public class Monster1 : MonoBehaviour {
    public GameObject Unit;
    Animator anima;
   public float her,speedMonster;
    float S, ax, bx; // ax- Unit.x , bx-GameObject.x;
    Vector2 ach, dzax; // ach dzax gnalu keter@;
    bool Bach, Bdzax; //ete hach =true apa gna dzax , ev hakarak@ ;

    void Start () {
        ach = new Vector2(transform.position.x + 0.7f, transform.position.y);
        dzax = new Vector2(transform.position.x -0.7f, transform.position.y);
        anima = GetComponent<Animator>();
    }
	
		void Update () {
        ach.y = transform.position.y;
        dzax.y = transform.position.y;
        ax = Unit.transform.position.x;
        bx = transform.position.x;
        S = ax - bx; //Определили расстояние меж обектами а и б и назвали его S, а знак S будет нам говорить где находиться а ,а где б ;
        if (S * S <= her * her && Unit.transform.position.y - transform.position.y < 0.6f)//Проверим входит ли обект а в активную зону проекта б . так как S может быть отрецательным то возьмоем его кодрат ; хз как взять модуль
        {
            anima.SetBool("Norun", false);
            if (S < 0)   // b.....a;
            {
                transform.localScale = new Vector3(-1, 1, 1);
                transform.Translate(new Vector2(1, 0) * Time.deltaTime * speedMonster);
            }
            else if (S > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
                transform.Translate(new Vector2(1, 0) * Time.deltaTime * speedMonster);
            }
            //transform.LookAt(Unit.transform);
            //transform.Translate(new Vector2(1, 0) * Time.deltaTime * speedMonster);
        }
        else
               
        {
            anima.SetBool("Norun", true);
            if (transform.position.x == ach.x)
            {
                Bach = true;
                Bdzax = false;
            }
            else if (transform.position.x == dzax.x)
            {
                Bdzax = true;
                Bach = false;
            }
            else if (!Bdzax && !Bach)
            {
                Bdzax = true;
                Bach = false;
            }

            if (Bdzax)
            {
                if (ach.x - transform.position.x > 0)
                    transform.localScale = new Vector3(1, 1, 1);
                else transform.localScale = new Vector3(-1, 1, 1);

                transform.position = Vector2.MoveTowards(transform.position, ach, Time.deltaTime * (speedMonster - 0.7f));
            }
            else if (Bach)
            {
                if (dzax.x - transform.position.x < 0)
                    transform.localScale = new Vector3(-1, 1, 1);
                else transform.localScale = new Vector3(1, 1, 1);

                transform.position = Vector2.MoveTowards(transform.position, dzax, Time.deltaTime * (speedMonster - 0.7f));
            }
        }

    }
}
