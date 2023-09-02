using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;

    private void Start()
    {
        // ���α׷� �ð��� ������ش�
        _sessionStartTime = DateTime.Now;
        Debug.Log("Game session start @ : " + DateTime.Now);
    }

    private void OnApplicationQuit()
    {
        // ���� �Ѿ�� �Ǹ� ȣ��Ǵ� �Լ�
        _sessionEndTime = DateTime.Now;
        TimeSpan timeDifference = _sessionStartTime.Subtract(_sessionStartTime);

        Debug.Log("Game session ended @ : " + DateTime.Now);
        Debug.Log("Game session lasted : " + timeDifference);
    }

    //private void OnGUI()
    //{
    //    if (GUILayout.Button("Next Scene"))
    //    {
    //        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //    }
    //}
}
