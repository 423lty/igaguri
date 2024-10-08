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
            //いがぐりをインスタンス
            GameObject igaguri = Instantiate(igagurPrefab);

            //rayを飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //
            Vector3 worldDir = ray.direction;

            //いがぐりで攻撃
            igaguri.GetComponent<IgaguriController>().Shoot(worldDir.normalized * 2000);
        }
    }
}
