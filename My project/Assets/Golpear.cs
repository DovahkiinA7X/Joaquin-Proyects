using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpear : MonoBehaviour
{

    private Animator animator;
    private bool staticPunch;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        staticPunch = Input.GetKeyDown(KeyCode.F);
        bool actual = animator.GetBool("staticPunch");
        if (staticPunch && actual != staticPunch) {

            print("staticPunch " + staticPunch);
            animator.SetBool("staticPunch", staticPunch);
        }
    }
}
