using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bike
{
	// IBikeState 인터페이스를 구현하는 상태 클래스
	public class BikeStartState : MonoBehaviour, IBikeState
	{
		// 이 부분을 따로 저장시켜놓는게 아니라 delegate를 통한 이벤트로
		// bikestate 클래스가 다른 클래스가 무엇을 하는지 알 수 없게 바꾸는게 좋음
		// 그래야 다른 클래스에 대한 의존성이 떨어진다
		private BikeController bikeController;

		public void Handle(BikeController _bikeController)
		{
			if(!bikeController)
			{
				// 인자로 받아온 _bikeController를 변수로 등록
				bikeController = _bikeController;
			}
			// 시작 시 현재 속도를 최고속도로
			bikeController.CurrentSpeed = _bikeController.maxSpeed;
		}

		void Update()
		{
			if(bikeController)
			{
				// 현재 속도가 0 이상이면
				if(bikeController.CurrentSpeed > 0)
				{
					// 앞으로 나아가게 설정
					bikeController.transform.Translate(
						Vector3.forward * (bikeController.CurrentSpeed * Time.deltaTime));
				}
			}
		}
	} 
}
