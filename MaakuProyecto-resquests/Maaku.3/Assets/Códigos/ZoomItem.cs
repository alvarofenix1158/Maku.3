﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomItem : MonoBehaviour
{
    public static Sprite itemParaHacerZoom;
    private GameObject UIitemZoom;
    private PlayerControl playerControl;
    private Inventory inventory;
    public static bool itemEstaEnZoom = false;

    // Start is called before the first frame update
    void Start()
    {
        UIitemZoom = GameObject.FindGameObjectWithTag("Zoom");
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q) && inventory.isFull) //Hacer zoom al objeto del inventario
        {
            if (!itemEstaEnZoom && GameManager.menuAbierto == false)
            {
                playerControl.enabled = false;

                UIitemZoom.GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;

                UIitemZoom.GetComponent<Image>().color = new Color(255, 255, 255, 255);
                GameManager.menuAbierto = true;
            }
            else
            {
                playerControl.enabled = true;
                UIitemZoom.GetComponent<Image>().color = new Color(0, 0, 0, 0);
                GameManager.menuAbierto = false;
            }
            itemEstaEnZoom = !itemEstaEnZoom;
        }
    }
}
