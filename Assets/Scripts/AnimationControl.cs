using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    public Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("start", false);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetBool("start", true);
        }  
    }
}
