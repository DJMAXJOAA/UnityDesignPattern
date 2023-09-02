using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bike
{
	// ����ũ ��Ʈ�ѷ��� ���º��� ���� ���뵵 �־������ Ŭ������ �ʹ� ����������
	// ���� ���� ���� Ŭ������ ������ ����
	public class BikeStateContext : MonoBehaviour
	{
		// �б����� ������ �����صδ� ����� ��� ���� ����� �ƴϱ� ��
		// ������ �����Ѵٸ� �̺�Ʈ�� ���ļ� �������� ���ߴ� �������� ���°� ���� ��
		private readonly BikeController bikeController;

		// �ۺ� ���·� ������ ��ȯ�� �� �� �ְ� ����
		public IBikeState CurrentState { get; set; }

		// �б����� ����ũ ��Ʈ�ѷ� ��ü�� ��������� ��Ͻ�Ű��
		public BikeStateContext(BikeController _bikeController)
		{
            bikeController = _bikeController;
		}

		// ���� ������ �Լ��� ����
		public void Transition()
		{
			CurrentState.Handle(bikeController);
		}

		// ���ڷ� ���� ���·� ���¸� �����ϰ� ����
		public void Transition(IBikeState _state)
		{
			CurrentState = _state;
			CurrentState.Handle(bikeController);
		}
	}

}