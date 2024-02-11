using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationLogic : MonoBehaviour
{
    Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myAnimator.SetInteger("AnimationState", 1);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            myAnimator.SetInteger("AnimationState", 0);
        }
    }
}
