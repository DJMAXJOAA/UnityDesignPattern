using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bike
{
    public class ClientState : MonoBehaviour
    {
        private BikeController bikeController;

        private void Start()
        {
            // ��������� ��Ʈ�ѷ� ���
            bikeController = FindObjectOfType<BikeController>();
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Start Bike"))
            {
                bikeController.StartBike();
            }
            if (GUILayout.Button("Turn Left"))
            {
                bikeController.Turn(Direciton.Left);
            }
            if (GUILayout.Button("Turn Right"))
            {
                bikeController.Turn(Direciton.Right);
            }
            if (GUILayout.Button("Stop Bike"))
            {
                bikeController.StopBike();
            }
        }
    }

}