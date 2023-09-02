using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bike
{
    public class BikeStopState : MonoBehaviour, IBikeState
    {
        private BikeController bikeController;

        public void Handle(BikeController _bikeController)
        {
            // ��� ������ ����� �Ǿ����� ������ ���� ���
            if(!bikeController)
            {
                bikeController = _bikeController;
            }
            // ���� �ӵ��� 0���� �����
            bikeController.CurrentSpeed = 0;
        }
    }

}