using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lose : MonoBehaviour
{
    GameManager gameManager;
    public float time = 0f;

    //public AudioClip deadsound;
    //AudioSource audiosource;


    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        DontDestroyOnLoad(this);
    }

    void Start()
    {
        //audiosource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Debug.Log("a");
            GameObject.Find("man").GetComponent<Animator>().Play("disappear");
            GameObject.Find("man").GetComponent<move>().play_dead_sound = true;
            //audiosource.PlayOneShot(deadsound, 7.0f);
            //man.GetComponent<move>().dead = true;
            //Destroy(GameObject.FindWithTag("Player"));
            //Destroy(obj.gameObject);
            Destroytimer(obj);
        }

    }

    void Destroytimer(Collider2D obj)
     {
        //Destroy(obj.gameObject, 2.0f);
     }

}
