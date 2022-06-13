using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RobotRampage
{
    public class GearPickup : MonoBehaviour
    {
        //public Text scoreGearTotalText;
        //public int scoreGearTotalValue;
        //private int score;
        void Start()
        {
            //score = 0;
            //UpdateScore();
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "FieldCollider" || other.tag == "Player")
            {
                return;
            }

            if (other.gameObject.CompareTag("GearPickup"))
            {
                other.gameObject.GetComponent<Renderer>().enabled = true;
            }
        }

        void Update()
        {

        }
    }
    //other.gameObject.SetActive(false);    //toggle    renderer.enabled = !renderer.enabled;
}