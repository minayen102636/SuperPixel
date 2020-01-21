using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public float speed=5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A)) {
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
            GameObject.Find("scoremanager").GetComponent<scoremanager>().type = 1;
            GameObject.Find("man").GetComponent<walk>().enabled = false;
            GameObject.Find("man").GetComponent<jump>().enabled = false;
        }
    }
}
