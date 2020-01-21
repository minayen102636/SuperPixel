using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trap : MonoBehaviour
{
    GameManager gameManager;

    public GameObject trampoline;
    public GameObject spikes;
    public GameObject spikedball;
    public GameObject fire;
    public GameObject plant;
    public GameObject saw;
    //public bool change;
    public bool create;
    public int y = 0;
    public bool trapkind;
    // bool flag;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        DontDestroyOnLoad(this);
    }


    void Start()
    {
        //flag = true;
        create = true;
        trapkind = false;
    }

    void Update()
    {
        if (trapkind == true)
        {
            if (y == 1 && create == true)
            {
                Instantiate(trampoline, transform.position, transform.rotation);
                create = false;
            }

            if (y == 2 && create == true)
            {
                Instantiate(spikes, transform.position, transform.rotation);
                create = false;
            }


            if (y == 3 && create == true)
            {
                Instantiate(spikedball, transform.position, transform.rotation);
                create = false;
            }


            if (y == 4 && create == true)
            {
                Instantiate(fire, transform.position, transform.rotation);
                create = false;
            }

            if (y == 5 && create == true)
            {
                Instantiate(plant, transform.position, transform.rotation);
                create = false;
            }

            if (y == 6 && create == true)
            {
                Instantiate(saw, transform.position, transform.rotation);
                create = false;
            }
        }


        /*if(change == false){
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * Time.deltaTime); //往左
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * Time.deltaTime); //往右
            }
            if (Input.GetKey(KeyCode.W)) 
            {
                transform.Translate(Vector2.up * Time.deltaTime); //往上
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * Time.deltaTime); //往下
            }
        }
            if(Input.GetKey(KeyCode.Space))
            {
                change = true;
                if (flag == true)
                {
                    GameObject.Find("man").GetComponent<walk>().enabled = true;
                    GameObject.Find("man").GetComponent<jump>().enabled = true;
                    flag = false;
                }       
            }*/


    }

    /*void Instantiate(){
         if(x == 1)
        {
            if(create == true)
            {
            Instantiate(trampoline, transform.position, transform.rotation);
            create = false;
            }
        }
    }*/


}
