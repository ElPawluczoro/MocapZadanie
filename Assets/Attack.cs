using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Do();
        }
    }


    public void Do()
    {
        GetComponent<Animator>().Play("attack");
        //yield return new WaitForSeconds(7);
        //GetComponent<Animator>().SetBool("Attack", false);
    }
}
