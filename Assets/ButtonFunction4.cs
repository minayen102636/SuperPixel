using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonFunction4 : MonoBehaviour
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
        SceneManager.LoadScene("ChooseScene");
    }
}


