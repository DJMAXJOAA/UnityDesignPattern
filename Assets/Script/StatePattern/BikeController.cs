using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Bike
{
    public class BikeController : MonoBehaviour
    {
        public float maxSpeed = 2.0f;
        public float turnDistance = 2.0f;

        public float CurrentSpeed { get; set; }
        public Direciton CurrentTurnDirection { get; set; }
        private IBikeState startState, stopState, turnState;
        private BikeStateContext bikeStateContext;
        private void Start()
        {
            // context와 상태변수들의 초기화
            bikeStateContext = new BikeStateContext(this);
            startState = gameObject.AddComponent<BikeStartState>();
            stopState = gameObject.AddComponent<BikeStopState>();
            turnState = gameObject.AddComponent<BikeTurnState>();

            // 현재 상태를 stopState로 바꾸고, 상태 실행
            bikeStateContext.Transition(stopState);
        }

        public void StartBike()
        {
            bikeStateContext.Transition(startState);
        }

        public void StopBike()
        {
            bikeStateContext.Transition(stopState);
        }

        public void Turn(Direciton direction)
        {
            CurrentTurnDirection = direction;
            bikeStateContext.Transition(turnState);
        }

    }

}