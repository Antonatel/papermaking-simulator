﻿using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drypaper : GrabAndThrow
{
    public GameObject counter;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "desk")
        {
            counter = GameObject.Find("counter");
            if (counter.transform.position.z == 0)
            {
                gameObject.GetComponent<PhotonTransformView>().m_SynchronizeScale = true;   
                counter.transform.position = new Vector3(counter.transform.position.x, counter.transform.position.y, (float)1);
                gameObject.transform.localScale = new Vector3(0, 0, 0);
                PhotonNetwork.Destroy(gameObject);
                
            }
        }
    }
}
