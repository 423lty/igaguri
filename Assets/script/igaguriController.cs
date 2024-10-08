using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    [SerializeField, Header("ìæì_")]
    static int igaguriPoint = 10;

    // Start is called before the first frame update
    public static int IgaguriPoint
    {
        get=>igaguriPoint;
    }

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

        if(CompareTag("target")) ScoreController.AddScore();

    }
    private void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector(0,200,2000));
    }

}
