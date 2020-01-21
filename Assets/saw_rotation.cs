using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw_rotation : MonoBehaviour
{

    GameManager gameManager;
    public bool change;
    bool flag;
    public bool rotation;

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
        rotation = false;
    }


    void Update()
    {
        if (change == false)
        {
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
            audiosource.PlayOneShot(puttrap, 5.0f);
            change = true;
            rotation = true;

            if (flag == true)
            {
                //GameObject.Find("man").GetComponent<walk>().enabled = true;
                GameObject.Find("man").GetComponent<move>().enabled = true;
                flag = false;
            }

        }

        if (rotation == true)
        {
            transform.Rotate(new Vector3(0, 0, 2)); //Z軸旋轉5度
            Vector3 rotate = transform.rotation.eulerAngles; //獲得遊戲物件當前的旋轉值
        }

    }

    void rotation_function()
    {

    }

}
