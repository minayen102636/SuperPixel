using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    public GameObject you;
    public GameObject friend;
    public GameObject scorebar;
    public int type = 0;

    public AudioClip win_sound;
    AudioSource audiosource;
    public AudioSource mainaudio;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (type == 1)
        {   
            audiosource.PlayOneShot(win_sound, 1.0f);
            mainaudio.GetComponent<AudioSource>().volume=0.2f;
            //Debug.Log("in");
            scorebar.SetActive(true);
            gametrap.youpoint += 2.16f;
            you.transform.position += new Vector3(gametrap.youpoint, 0, 0);
            friend.transform.position += new Vector3(gametrap.friendpoint, 0, 0);
            type = 0;
        }
        if (type == 2)
        {
            audiosource.PlayOneShot(win_sound, 1.0f);
            mainaudio.GetComponent<AudioSource>().volume=0.2f;
            scorebar.SetActive(true);
            gametrap.friendpoint += 2.16f;
            you.transform.position += new Vector3(gametrap.youpoint, 0, 0);
            friend.transform.position += new Vector3(gametrap.friendpoint, 0, 0);
            type = 0;
        }

    }

}
