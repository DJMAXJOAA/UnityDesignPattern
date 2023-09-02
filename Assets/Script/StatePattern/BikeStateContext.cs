using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bike
{
	// 바이크 컨트롤러에 상태변경 관련 내용도 넣어버리면 클래스가 너무 복잡해져서
	// 상태 변경 관련 클래스를 나눠서 관리
	public class BikeStateContext : MonoBehaviour
	{
		// 읽기전용 변수로 저장해두는 방식은 사실 좋은 방식은 아니긴 함
		// 실제로 구현한다면 이벤트를 거쳐서 의존성을 낮추는 방향으로 가는게 좋을 듯
		private readonly BikeController bikeController;

		// 퍼블릭 상태로 수정과 반환을 할 수 있게 설정
		public IBikeState CurrentState { get; set; }

		// 읽기전용 바이크 컨트롤러 객체를 멤버변수로 등록시키기
		public BikeStateContext(BikeController _bikeController)
		{
            bikeController = _bikeController;
		}

		// 현재 상태의 함수를 실행
		public void Transition()
		{
			CurrentState.Handle(bikeController);
		}

		// 인자로 받은 상태로 상태를 변경하고 실행
		public void Transition(IBikeState _state)
		{
			CurrentState = _state;
			CurrentState.Handle(bikeController);
		}
	}

}