using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float h = Input.GetAxis("Horizontal");
       Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
       rb.velocity = new Vector2(h*16,0);
    }
}
