using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class IgaguriController : MonoBehaviour
{
    [SerializeField, Header("得点")]
    static int igaguriPoint = 10;

    [SerializeField,Header("フレームカウント最大")]
    const int MaxFrameCount = 3;


    // Start is called before the first frame update
    public static int IgaguriPoint
    {
        get=>igaguriPoint;
    }

    /// <summary>
    /// 攻撃
    /// </summary>
    /// <param name="dir"></param>
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        //GetComponent<SphereCollider>().isTrigger = true;
        GetComponent<ParticleSystem>().Play();
       
        //スコア,当たった回数を加算
        if (collision.gameObject.CompareTag("target"))
        { 
            ScoreController.AddScore(); 
            ScoreController.AddCount();
        }


        Destroy(gameObject,MaxFrameCount);

    }

    private void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector(0,200,2000));
    }
    private void Update()
    {
  
    }

}
