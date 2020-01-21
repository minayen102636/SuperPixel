using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trap_sample : MonoBehaviour
{

	GameManager gameManager;
    public bool change;
    public bool flag;

    public AudioClip puttrap;
    AudioSource audiosource;


	void Awake()
	{
		gameManager = FindObjectOfType<GameManager>();
		DontDestroyOnLoad(this);
	}

    void Start()
    {
        flag = true;
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(change == false){
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
            audiosource.PlayOneShot(puttrap, 5.0f);
            change = true;
            GameObject.Find("spikesball(sample)").GetComponent<rotation>().enabled = true;

            if (flag == true)
            {
               // GameObject.Find("man").GetComponent<walk>().enabled = true;
                GameObject.Find("man").GetComponent<move>().enabled = true;
                GameObject.Find("man2").GetComponent<move2>().enabled = true;
                flag = false;
            }       
        }
    }

    /*void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Player")
        {
            Destroy(GameObject.FindWithTag("Player"));
        }
        if (obj.gameObject.tag == "win")
        {
            GameObject.Find("man").GetComponent<walk>().enabled = false;
            GameObject.Find("man").GetComponent<jump>().enabled = false;
        }
    }*/
    /*void OnMouseDown()
    {
            //Destroy(this.gameObject);
            //Destroy(GameObject.Find("man"));
    	//SceneManager.LoadScene("main");
        //gameManager.GetComponent<GameManager>().trap = (this.gameObject);
    	trap.GetComponent<trap>().x = 1;

    }*/

   
}
