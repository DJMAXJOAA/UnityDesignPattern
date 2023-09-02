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
        // 프로그램 시간을 출력해준다
        _sessionStartTime = DateTime.Now;
        Debug.Log("Game session start @ : " + DateTime.Now);
    }

    private void OnApplicationQuit()
    {
        // 씬이 넘어가게 되면 호출되는 함수
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
