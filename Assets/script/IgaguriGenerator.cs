using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgaguriGenerator : MonoBehaviour
{
    public GameObject igagurPrefab;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //����������C���X�^���X
            GameObject igaguri = Instantiate(igagurPrefab);

            //ray���΂�
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //
            Vector3 worldDir = ray.direction;

            //��������ōU��
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
