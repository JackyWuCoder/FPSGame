using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateCube : Interactable
{
    private Animator animator;
    private string startPrompt;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
        animator = GetComponent<Animator>();
        startPrompt = promptMessage;
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Default"))
        {
            promptMessage = startPrompt;
        }
        else
        {
            promptMessage = "Animating...";
        }
    }

    protected override void Interact()
    {
        animator.Play("Spin");
    }
}
