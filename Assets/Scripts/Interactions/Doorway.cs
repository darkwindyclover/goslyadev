﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorway : Interactable
{
    public FadeToBlack fade;
    public Transform destination;
    public GameObject cam;

    void Start()
    {
        
    }

    protected override void Action()
    {
        base.Action();
        CancelInvoke();
        fade.FadeTransition(out float halfTime);
        Invoke("Teleport", halfTime);
    }

    void Teleport()
    {
        //потому что менять Z-координату у камеры это игрушки дьявола!
        Vector2 destVector = new Vector2(destination.position.x, destination.position.y);
        cam.transform.position = destVector;
        player.transform.position = destVector;
    }
}
