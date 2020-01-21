using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trap2 : MonoBehaviour
{
    public AudioClip choose_sound;
    AudioSource audiosource;
 
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

     void OnMouseOver(){
        GetComponent<SpriteRenderer>().color = new Color(255,0,0,255);
    }

    void OnMouseExit(){
        GetComponent<SpriteRenderer>().color = new Color(255,255,255,255);
    }

    void OnMouseDown()
    {
        audiosource.PlayOneShot(choose_sound, 5.0f);
        gametrap.put = 1;
        gametrap.thistrap = 2;
        if (scenechoose.scene == 1)
            SceneManager.LoadScene("gamescene1");
        if (scenechoose.scene == 2)
            SceneManager.LoadScene("gamescene2");
        if (scenechoose.scene == 3)
            SceneManager.LoadScene("gamescene3");
    }
}
