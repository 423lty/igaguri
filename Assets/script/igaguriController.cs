using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igaguriController : MonoBehaviour
{

    [SerializeField,Header("������X�s�[�h")]
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
        //�L�[�̓���
        InputKey();
    }
    /// <summary>
    /// �L�[�̓���
    /// </summary>
    void InputKey()
    {
        //�L�[�̓���
        if (Input.GetMouseButton(0))
        {
            //�C�K�O���𓊂���
            ThrowIgaguri();
        }
    }
    /// <summary>
    /// �C�K�O���𓊂���
    /// </summary>
    void ThrowIgaguri()
    {
        //��
        var vector=new Vector3();

        vector.z = throwSpeed;

        //�ʒu���X�V
        this.rigidbody.AddForce(vector);
        //this.transform.position += vector;

    }
}
