using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    public float speed = 0.15f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.4f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(-speed, 0, 0));
    }
}
