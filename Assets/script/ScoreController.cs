using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using Unity.VisualScripting;

public class ScoreController : MonoBehaviour
{
    [SerializeField,Header("ポイント")]
    GameObject pointObject;

    [SerializeField,Header("当たった回数")]
    static int count;

    [SerializeField, Header("当たった回数")]
    static int score;

    [SerializeField,Header("的に当たった回数が指定の回数ｋ￥")]
    const int HitTheTarget = 100;

    [SerializeField, Header("当たった場合の得点")]
    const int HitPoint = 10;

    [SerializeField, Header("指定の回数を超えた場合のボーナス")]
    const int Multiplay = 3;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        pointObject.GetComponent<TextMeshProUGUI>().text = "Point : " + GetScore().ToString();
    }

    public static void AddScore()
    {
        if (count > HitTheTarget) score += Multiplay;
        else score += HitPoint;
    }
    public static int GetScore()
    {
        return score;
    }

    public static void AddCount()
    {
        count ++;
    }
    public static int GetCount()
    {
        return count;
    }
}
