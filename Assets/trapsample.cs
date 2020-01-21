using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trapsample : MonoBehaviour
{

    public bool change;
    bool flag;

    public AudioClip puttrap;
    AudioSource audiosource;

    void Start()
    {
        flag = true;
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (change == false)
        {
            GameObject.Find("puttrap_bg").GetComponent<SpriteRenderer>().sortingOrder = 1;
            GetComponent<SpriteRenderer>().sortingOrder = 2;
            
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
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject.Find("puttrap_bg").GetComponent<SpriteRenderer>().sortingOrder = -2;
            GetComponent<SpriteRenderer>().sortingOrder = 0;
            audiosource.PlayOneShot(puttrap, 5.0f);
            change = true;          
            if (flag == true)
            {
                gametrap.pre[gametrap.prenum] = gametrap.thistrap;
                gametrap.prepos[gametrap.prenum] = this.transform.position;
                gametrap.prenum++;
                GameObject.Find("man").GetComponent<move>().enabled = true;
                GameObject.Find("man2").GetComponent<move2>().enabled = true;
                flag = false;
            }
        }
    }



}
