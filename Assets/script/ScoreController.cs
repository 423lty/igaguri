using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using Unity.VisualScripting;

public class ScoreController : MonoBehaviour
{
    [SerializeField,Header("ƒ|ƒCƒ“ƒg")]
    GameObject pointObject;

    static int count;

     static int score;
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
        score += 10;
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
