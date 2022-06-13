using System.Collections;
using UnityEngine;

namespace RobotRampage
{
    public class FuelDispenser : MonoBehaviour
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

            if (other.gameObject.CompareTag("FuelDispenserCollider"))
            {
                other.gameObject.GetComponent<MeshCollider>().enabled = false;
            }
        }

        void Update()
        {

        }
    }
    //other.gameObject.SetActive(false);    //toggle    renderer.enabled = !renderer.enabled;
}


