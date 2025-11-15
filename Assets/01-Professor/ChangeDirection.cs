using System.Collections;
using System.Collections.Generic;
using UnityEditor.Toolbars;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    private Animator anim;
    private float horizontalMove;
    private float verticalMove;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        if (horizontalMove < 0)
        {
            anim.SetInteger("Direction", 3);
        }
        if (horizontalMove > 0)
        {
            anim.SetInteger("Direction", 1);
        }
 	if (verticalMove < 0)
        {
            anim.SetInteger("Direction", 2);
        }
	if (verticalMove > 0)
        {
            anim.SetInteger("Direction", 0);
        }


    }
}
