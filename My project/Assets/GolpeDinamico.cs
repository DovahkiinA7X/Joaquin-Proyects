using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolpeDinamico : MonoBehaviour
{

    private Animator animator;
    private bool dinamicPunch;

    // Start is called before the first frame update

    void Start()
    {

        animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {


        dinamicPunch = Input.GetKeyDown(KeyCode.G);
        bool actual = animator.GetBool("dinamicPunch");
        if (dinamicPunch && actual != dinamicPunch)

        
        {

            print("dinamicPunch " + dinamicPunch);
            animator.SetBool("dinamicPunch", dinamicPunch);
        }


    }
}
