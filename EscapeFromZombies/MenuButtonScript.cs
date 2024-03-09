using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void SmartPressed(){
        SceneManager.LoadScene("SmartScene");

    }

  public void  StupidPressed(){
        SceneManager.LoadScene("StupidScene");

    }

   public void HunPressed(){
        SceneManager.LoadScene("HunScene");

    }

    public void CunPressed(){
        SceneManager.LoadScene("CunScene");
        
    }



}
