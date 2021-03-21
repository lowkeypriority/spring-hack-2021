using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Peoples : NetworkBehaviour
{
    private Animator anim;
    private SpriteRenderer SpriteR;
    public Sprite sprite1;
    public RuntimeAnimatorController newAnim;
    void Start()
    {
        SpriteR = gameObject.GetComponent<SpriteRenderer>();
        anim = gameObject.GetComponent<Animator>();
        if (!isServer && isLocalPlayer)
            SpriteR.sprite = sprite1;
        if (isServer && !isLocalPlayer)
            SpriteR.sprite = sprite1;
    }

}
