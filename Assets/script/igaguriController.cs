using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igaguriController : MonoBehaviour
{

    [SerializeField,Header("投げるスピード")]
    float throwSpeed;

    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //キーの入力
        InputKey();
    }
    /// <summary>
    /// キーの入力
    /// </summary>
    void InputKey()
    {
        //キーの入力
        if (Input.GetMouseButton(0))
        {
            //イガグリを投げる
            ThrowIgaguri();
        }
    }
    /// <summary>
    /// イガグリを投げる
    /// </summary>
    void ThrowIgaguri()
    {
        //力
        var vector=new Vector3();

        vector.z = throwSpeed;

        //位置を更新
        this.rigidbody.AddForce(vector);
        //this.transform.position += vector;

    }
}
