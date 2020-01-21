using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firetrap : MonoBehaviour
{

    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetInteger("state2", 0);
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            GetComponent<Animator>().Play("detect");
            //GameObject.Find("man").GetComponent<Animator>().Play("disappear");
            //GameObject.Find("man").GetComponent<move>().play_dead_sound = true;
            //GameObject.Find("fire").GetComponent<fire_animator>().detect = true;
            //Destroytimer();
            Invoke("Attack", 0.5f);
        }

        if (obj.gameObject.tag == "win")
        {
            GameObject.Find("man").GetComponent<walk>().enabled = false;
            GameObject.Find("man").GetComponent<move>().enabled = false;
        }
    }

    void Attack()
    {
        GetComponent<Animator>().Play("attack");
        GameObject.Find("man").GetComponent<move>().fire_attack = true;
        Invoke("DestroyPlayer", 0.3f);

    }

    void DestroyPlayer()
    {
        //GameObject.Find("man").GetComponent<CircleCollider2D>().isTrigger = true;
        //GameObject.Find("man").GetComponent<move>().fire_attack = false;
        //GameObject.Find("man").GetComponent<move>().play_dead_sound = true;
        //attack = false;
        //GameObject.Find("man").GetComponent<Animator>().Play("disappear");
        //GameObject.Find("man").GetComponent<move>().play_dead_sound = true;

        Invoke("Destroytimer", 0.3f);
    }

    void Destroytimer()
    {
        GameObject.Find("man").GetComponent<Animator>().Play("disappear");
        Destroy(GameObject.FindWithTag("Player"), 0.3f);
        Invoke("Again", 0.3f);
    }

    void Again()
    {
        GetComponent<Animator>().Play("off");
    }

}
