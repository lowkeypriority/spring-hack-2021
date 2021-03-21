using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatr : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        anim.SetFloat("x", h);
        anim.SetFloat("y", v);
    }
}
