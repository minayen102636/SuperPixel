using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trampoline : MonoBehaviour
{
	public GameObject man;
	GameManager gameManager;


	void Awake()
	{
		gameManager = FindObjectOfType<GameManager>();
	}


    void OnMouseDown()
    {
            //Destroy(this.gameObject);
            //Destroy(GameObject.Find("man"));
    	//SceneManager.LoadScene("main");
        //gameManager.GetComponent<GameManager>().trap = (this.gameObject);
    	gameManager.GetComponent<GameManager>().x = 1;

    }

   
}
