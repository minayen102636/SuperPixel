using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texteffect : MonoBehaviour
{
	public Text mytext;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("showHide", 0.5f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showHide()
    {
    	if(mytext.text == "")
    	{
    		mytext.text = "PRESS START";
    	}

    	else
    	{
    		mytext.text = "";
    	}
    }
}
