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
            // 멤버 변수에 등록이 되어있지 않으면 새로 등록
            if(!bikeController)
            {
                bikeController = _bikeController;
            }
            // 현재 속도를 0으로 만든다
            bikeController.CurrentSpeed = 0;
        }
    }

}