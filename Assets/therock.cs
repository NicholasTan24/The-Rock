using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class therock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5 || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * 10 * Time.deltaTime, 0f, 0f));
        }
        if (Input.GetAxisRaw("Vertical") > 0.5 || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Vertical") * 10 * Time.deltaTime, 0f, 0f));
        }
    }
}
