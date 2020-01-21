using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk2 : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "trap")
        {
            Destroy(this.gameObject);
        }
        if (obj.gameObject.tag == "win")
        {
            GameObject.Find("scoremanager").GetComponent<scoremanager>().type = 2;
            GameObject.Find("man2").GetComponent<walk2>().enabled = false;
            GameObject.Find("man2").GetComponent<jump2>().enabled = false;
        }
    }
}
