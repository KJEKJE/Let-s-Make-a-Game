using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerItself : MonoBehaviour
{
    private Animator swipeAnim;
    private void Start()
    {
        swipeAnim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            swipeAnim.SetBool("Firing?", true);
        }
        else
        {
            swipeAnim.SetBool("Firing?", false);
        }
    }
}

