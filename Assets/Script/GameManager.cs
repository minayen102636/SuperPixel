using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    static GameManager instance;

    public GameObject trap;
    //public GameObject trampoline;
    //public GameObject spikes;
    //public GameObject spikedball;
    public int x;
    public float s_width;
    public float s_height;
    //public bool create;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != instance)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        x = 0;
        //create = true;
    }


    void Update()
    {

        if (x == 1)
        {
            //if(create == true)
            //{
            //Instantiate(trampoline, trap.transform.position, trap.transform.rotation);
            trap.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load<Sprite>("trampoline");
            trap.GetComponent<SpriteRenderer>().transform.localScale = new Vector2(10, 10);
            trap.GetComponent<trap>().y = 1;
            //create = false;

        }
        if (x == 2)
        {
            //if(create == true)
            //{
            //Instantiate(spikes, trap.transform.position, trap.transform.rotation);
            //create = false;
            //}
            trap.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load<Sprite>("spikes");
            trap.GetComponent<SpriteRenderer>().transform.localScale = new Vector2(1.5f, 1.5f);
            trap.GetComponent<trap>().y = 2;
        }
        if (x == 3)
        {
            //if(create == true)
            //{
            //Instantiate(spikedball, trap.transform.position, trap.transform.rotation);
            //create = false;
            //}
            trap.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load<Sprite>("spiked ball");
            trap.GetComponent<SpriteRenderer>().transform.localScale = new Vector2(2.5f, 2.5f);
            trap.GetComponent<trap>().y = 3;
        }

        if (x == 4)
        {

            trap.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load<Sprite>("fire");
            trap.GetComponent<SpriteRenderer>().transform.localScale = new Vector2(2.5f, 2.5f);
            trap.GetComponent<trap>().y = 4;
        }

        if (x == 5)
        {

            trap.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load<Sprite>("plant");
            trap.GetComponent<SpriteRenderer>().transform.localScale = new Vector2(2.5f, 2.5f);
            trap.GetComponent<trap>().y = 5;
        }

        if (x == 6)
        {

            trap.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load<Sprite>("saw");
            trap.GetComponent<SpriteRenderer>().transform.localScale = new Vector2(2.5f, 2.5f);
            trap.GetComponent<trap>().y = 6;
        }
    }
}
