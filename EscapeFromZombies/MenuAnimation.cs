using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimation : MonoBehaviour
{
     public Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
         animator = GetComponent<Animator>();
    }

     private void OnMouseEnter()
    {
        animator.SetBool("PlayAnimation", true);
    }

    private void OnMouseExit()
    {
        animator.SetBool("PlayAnimation", false);
    }

    
    }