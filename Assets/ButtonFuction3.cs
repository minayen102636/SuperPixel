using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonFuction3 : MonoBehaviour
{
    public GameObject scorebar;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchScene()
    {
        scorebar.SetActive(false);
        scenechoose.nextgame = 1;
        SceneManager.LoadScene("trap_sance");
    }
}
