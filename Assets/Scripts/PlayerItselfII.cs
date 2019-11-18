using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerItselfII : MonoBehaviour
{
    private Animator walkAnim;
    private void Start()
    {
        walkAnim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            walkAnim.SetBool("Moving?", true);
        }
        else
        {
            walkAnim.SetBool("Moving?", false);
        }
    }
}
