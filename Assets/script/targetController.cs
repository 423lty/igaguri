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
            Debug.Log("���Z");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "igaguri")
        {
            //Destroy(other);
            Debug.Log("���Z");

            ScoreController.AddScore();


        }
    }


}
