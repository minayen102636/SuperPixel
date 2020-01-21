using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atk : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timer", 1.2f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void timer()
    {
        Vector3 pos = this.transform.position;
        Instantiate(bullet, pos, new Quaternion(0, 0, 0, 0));
    }
}
