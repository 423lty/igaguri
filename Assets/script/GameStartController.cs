using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartController : MonoBehaviour
{
    [SerializeField,Header("GameContrllor")]
    public GameObject gameController;

    [SerializeField,Header("GameStartButton")]
    public GameObject startButton;

    [SerializeField, Header("igaguriGenerator")]
    public GameObject igaguri;

    [SerializeField, Header("TimeObject")]
    public GameObject time;

    [SerializeField, Header("PointObject")]
    public GameObject point;

    [SerializeField, Header("Main Camera")]
    public Camera MainCamera;

    public void OnClickGameStartButton()
    {
        if (MainCamera != null && MainCamera.enabled)
        {
            //ボタンの表示をオフ
            startButton.SetActive(false);

            //ゲームコントローラーをオン
            gameController.SetActive(true);

            //イガグリをオン
            igaguri.SetActive(true);

            //ゲームコントローラーをオン
            time.SetActive(true);

            //イガグリをオン
            point.SetActive(true);
        }
    }
}
