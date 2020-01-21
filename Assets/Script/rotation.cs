using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 2)); //Z軸旋轉5度

        Vector3 rotate = transform.rotation.eulerAngles; //獲得遊戲物件當前的旋轉值
    }
}
