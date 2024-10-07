using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    /// çUåÇ
    /// </summary>
    /// <param name="dir"></param>
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }
    private void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector(0,200,2000));
    }

}
