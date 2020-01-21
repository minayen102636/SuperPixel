using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonFunction : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(SwitchScene);
        //如果這支程式碼附在一個有Button component的物件上
        //他會讀取Button，並且在Button上面加一個method
        //在你點擊該該Button的時候執行你設定的method
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DoSomething1()
    {
        print("this button is on clicked.");
    }
    public void SwitchScene()
    {
        SceneManager.LoadScene("OtherScene");
    }
}


