using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreController : MonoBehaviour
{
    GameObject pointObject;

     static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        pointObject = GameObject.Find("PointObject");

    }

    // Update is called once per frame
    void Update()
    {
        pointObject.GetComponent<TextMeshProUGUI>().text = "Point : " + score.ToString();
    }

    public static int AddScore()
    {
        score += 10;
        return score;
    }
}
