using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapmanager : MonoBehaviour
{
    public GameObject trap1;
    public GameObject trap2;
    public GameObject trap3;
    public GameObject trap4;
    public GameObject trap5;
    public GameObject trap6;
    public GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gametrap.put == 1)
        {
            for(int i = 0; i < gametrap.prenum; i++)
            {
                if (gametrap.pre[i] == 1)
                {
                    temp = Instantiate(trap1, gametrap.prepos[i], new Quaternion(0, 0, 0, 0));
                    temp.GetComponent<rotation>().enabled = true;
                    temp.GetComponent<trapsample_rotation>().enabled = false;
                }                
                if (gametrap.pre[i] == 2)
                {
                    temp = Instantiate(trap2, gametrap.prepos[i], new Quaternion(0, 0, 0, 0));
                    temp.GetComponent<trapsample>().enabled = false;
                }                    
                if (gametrap.pre[i] == 3)
                {
                    temp = Instantiate(trap3, gametrap.prepos[i], new Quaternion(0, 0, 0, 0));
                    temp.GetComponent<trapsample>().enabled = false;
                }                   
                if (gametrap.pre[i] == 4)
                {
                    temp = Instantiate(trap4, gametrap.prepos[i], new Quaternion(0, 0, 0, 0));
                    temp.GetComponent<rotation>().enabled = true;
                    temp.GetComponent<trap_sampleball>().enabled = false;
                }                   
                if (gametrap.pre[i] == 5)
                {
                    temp = Instantiate(trap5, gametrap.prepos[i], new Quaternion(0, 0, 0, 0));
                    temp.GetComponent<trapsample>().enabled = false;
                }                  
                if (gametrap.pre[i] == 6)
                {
                    temp = Instantiate(trap6, gametrap.prepos[i], new Quaternion(0, 0, 0, 0));
                    temp.GetComponent<trapsample>().enabled = false;
                }                    
                

            }
            if(gametrap.thistrap==1)
                Instantiate(trap1, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            if (gametrap.thistrap == 2)
                Instantiate(trap2, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            if (gametrap.thistrap == 3)
                Instantiate(trap3, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            if (gametrap.thistrap == 4)
                Instantiate(trap4, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            if (gametrap.thistrap == 5)
                Instantiate(trap5, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            if (gametrap.thistrap == 6)
                Instantiate(trap6, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            gametrap.put = 0;
        }
    }
}
