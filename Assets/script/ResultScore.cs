using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ResultScore : MonoBehaviour
{
    [SerializeField, Header("リザルトを表示するオブジェクト")]
    GameObject result;
    // Start is called before the first frame update
    void Start()
    {
        result.GetComponent<TextMeshProUGUI>().text = "Result\nTotalScore:" + ScoreController.GetScore().ToString();
    }
}
