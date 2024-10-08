using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetController : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "igaguri")
        {
           // Destroy(target);
            Debug.Log("‰ÁŽZ");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "igaguri")
        {
            //Destroy(other);
            Debug.Log("‰ÁŽZ");

            ScoreController.AddScore();


        }
    }


}
