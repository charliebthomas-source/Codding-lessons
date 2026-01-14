using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;       



      
public class ButtonPress : MonoBehaviour
{
    InputAction jumpAction;
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpAction.IsPressed())
        {
            animator.SetBool("ButtonPressed", true);
            Debug.Log("Pressed the A Key");
        }
        else{
            animator.SetBool("ButtonPressed", false);
        }
        
    }
}
