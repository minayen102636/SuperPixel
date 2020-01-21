using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonFunction2 : MonoBehaviour
{

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(SwitchScene);
    }

    void Update()
    {

    }

    public void SwitchScene()
    {
        /*
        if (scenechoose.scene == 1)
            SceneManager.LoadScene("gamescene1");
        if (scenechoose.scene == 2)
            SceneManager.LoadScene("gamescene2");
        if (scenechoose.scene == 3)
            SceneManager.LoadScene("gamescene3");
        */
        SceneManager.LoadScene("main");
    }
}


