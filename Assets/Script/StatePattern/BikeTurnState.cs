using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bike
{
	public class BikeTurnState : MonoBehaviour, IBikeState
	{
		// 어느쪽으로 방향을 꺾을건지
		private Vector3 turnDirection;
		// 인자로 받아온 _bikeController를 멤버 변수에 저장
		private BikeController bikeController;

		public void Handle(BikeController _bikeController)
		{
			// 멤버 변수에 등록이 안되어있으면, 인자를 멤버 변수에 저장
			if(!bikeController)
			{
				bikeController = _bikeController;
			}
			// 왼쪽으로 갈지 오른쪽으로 갈지 (left -1, right 1)
			turnDirection.x = (float)bikeController.CurrentTurnDirection;

			if(bikeController.CurrentSpeed > 0)
			{
				// Translate 함수로 입력받은 Vec3 방향으로 이동시킴
				transform.Translate(turnDirection * bikeController.turnDistance);
			}
		}
	}
}