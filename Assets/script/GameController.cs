using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class GameController : MonoBehaviour
{
    [SerializeField, Header("��������")]
    static float MaxGameTime = 20;

    //�Q�[������
    float gameTime;

    //time�I�u�W�F�N�g
    GameObject timeObject;

    // Start is called before the first frame update
    void Start()
    {
        //������
        gameTime = 0;

        //�Q�[�����ĊJ����
        Time.timeScale = 1;

        timeObject = GameObject.Find("TimeObject");
    }

    // Update is called once per frame
    void Update()
    {
        //�Q�[�����Ԃ������𒴂�����Q�[�����~����
        if (gameTime > MaxGameTime)
        {
            Time.timeScale = 0;
            GameObject result = GameObject.Find("resultScore");
            result.SetActive(true);
        }

        //���Ԃ����Z
        gameTime += Time.deltaTime;

        //�^�C����\��
        timeObject.GetComponent<TextMeshProUGUI>().text = "Time : " + gameTime.ToString("f2");
    }
}
