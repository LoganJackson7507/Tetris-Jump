using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("AnimState", 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("AnimState", 2);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            animator.SetInteger("AnimState", 3);
        }



        else
        {
            animator.SetInteger("AnimState", 0);
        }
    }
}
