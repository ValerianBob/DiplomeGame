using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private Transform rotationInfo;

    private void SetAnimationOfRotation(string w, string s, string a, string d)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger(w);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetTrigger("idle");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger(s);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetTrigger("idle");
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger(a);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetTrigger("idle");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger(d);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetTrigger("idle");
        }
    }

    void Start()
    {
        rotationInfo = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (rotationInfo.transform.eulerAngles.y > 0 && rotationInfo.transform.eulerAngles.y < 90)
        {
            Debug.Log("1");
            SetAnimationOfRotation("Run", "RunBackward", "RunLeft", "RunRight");
        }
        else if (rotationInfo.transform.eulerAngles.y > 90 && rotationInfo.transform.eulerAngles.y < 180)
        {
            Debug.Log("2");
            SetAnimationOfRotation("RunLeft", "RunRight", "RunBackward", "Run");
        }
        else if (rotationInfo.transform.eulerAngles.y > 180 && rotationInfo.transform.eulerAngles.y < 270)
        {
            Debug.Log("3");
            SetAnimationOfRotation("RunBackward", "Run", "RunRight", "RunLeft");
        }
        else if (rotationInfo.transform.eulerAngles.y > 270 && rotationInfo.transform.eulerAngles.y < 360)
        {
            Debug.Log("4");
            SetAnimationOfRotation("RunRight", "RunLeft", "Run", "RunBackward");         
        }

    }
}