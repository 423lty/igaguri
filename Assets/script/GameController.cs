using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class GameController : MonoBehaviour
{
    [SerializeField, Header("制限時間")]
    static float MaxGameTime = 20;

    //ゲーム時間
    float gameTime;

    //timeオブジェクト
    GameObject timeObject;

    // Start is called before the first frame update
    void Start()
    {
        //初期化
        gameTime = 0;

        //ゲームを再開する
        Time.timeScale = 1;

        timeObject = GameObject.Find("TimeObject");
    }

    // Update is called once per frame
    void Update()
    {
        //ゲーム時間が制限を超えたらゲームを停止する
        if (gameTime > MaxGameTime)
        {
            Time.timeScale = 0;
            GameObject result = GameObject.Find("resultScore");
            result.SetActive(true);
        }

        //時間を加算
        gameTime += Time.deltaTime;

        //タイムを表示
        timeObject.GetComponent<TextMeshProUGUI>().text = "Time : " + gameTime.ToString("f2");
    }
}
