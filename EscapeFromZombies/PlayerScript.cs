using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    public Animator m_Animator;
    public GameObject zombie;
    public GameObject zombie2;
    public GameObject zombie3;


    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    float h = Input.GetAxis("Horizontal");

       Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
       rb.velocity = new Vector2(h*20,0);

     if (Input.GetKey(KeyCode.RightArrow))

            m_Animator.SetInteger("States", 1);

        else if (Input.GetKey(KeyCode.LeftArrow))

           m_Animator.SetInteger("States",2);

        else if (Input.GetKey(KeyCode.Space))
        rb.velocity = new Vector2(h*6, 30);

        else

         m_Animator.SetInteger("States", 0);

       zombieSpawner();


}

public void zombieSpawner(){
    int frame = Time.frameCount;
if(frame % 500 == 0){
 int a = Random.Range(1,4);
 if(a==1)
Instantiate(zombie, new Vector2(gameObject.transform.position.x + 20,0), Quaternion.identity);
if(a==2)
Instantiate(zombie2, new Vector2(gameObject.transform.position.x + 20,0), Quaternion.identity);
if(a==3)
 Instantiate(zombie3, new Vector2(gameObject.transform.position.x + 20,0), Quaternion.identity);
} }


void OnTriggerEnter2D(Collider2D other){

    if (other.tag == "Zombie")
    {
     SceneManager.LoadScene("sampleScene");
    }


}

public void exitGame()
{
SceneManager.LoadScene("sampleScene");
}




}