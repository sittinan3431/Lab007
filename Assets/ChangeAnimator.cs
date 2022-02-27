using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    public void getAnimatorWalking()
    {
        this.GetComponent<Animator>().Play("Walking");
    }

    public void getAnimatorAngry()
    {
        this.GetComponent<Animator>().Play("Angry");
    }
}
