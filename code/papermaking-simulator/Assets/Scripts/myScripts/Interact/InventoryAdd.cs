﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryAdd : MonoBehaviour
{
    public GameObject mtext;
    public GameObject text;

    public void get()
    {

    }

    public bool minus()
    {
        String tmp;
        tmp = mtext.GetComponent<Text>().text;
        int n = int.Parse(tmp);
        if (n > 0)
        {
            n--;
            tmp = n.ToString();
            mtext.GetComponent<Text>().text = tmp;
            return true;
        }
        else
        {
            String temp;
            temp = text.GetComponent<Text>().text;
            int nd = int.Parse(temp);
            nd--;
            temp = nd.ToString();
            text.GetComponent<Text>().text = temp;
            print("原料不足");
            return false;
        }
           
    }

    public void add()
    {
        String tmp;
        tmp = text.GetComponent<Text>().text;
        int n = int.Parse(tmp);
        n++;
        tmp = n.ToString();
        text.GetComponent<Text>().text = tmp;
    }


    public bool selfMinus()
    {
        String tmp;
        tmp = text.GetComponent<Text>().text;
        int n = int.Parse(tmp);
        if (n > 0)
        {
            n--;
            tmp = n.ToString();
            text.GetComponent<Text>().text = tmp;
            return true;
        }
        else
        {
            print("原料不足");
            return false;
        }
    }
}
