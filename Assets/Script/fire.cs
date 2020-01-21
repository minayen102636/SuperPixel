using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    GameManager gameManager;


	void Awake()
	{
		gameManager = FindObjectOfType<GameManager>();
	}


    void OnMouseDown()
    {
   
        gameManager.GetComponent<GameManager>().x = 4;

    }
}
