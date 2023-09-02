using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bike
{
	public class BikeTurnState : MonoBehaviour, IBikeState
	{
		// ��������� ������ ��������
		private Vector3 turnDirection;
		// ���ڷ� �޾ƿ� _bikeController�� ��� ������ ����
		private BikeController bikeController;

		public void Handle(BikeController _bikeController)
		{
			// ��� ������ ����� �ȵǾ�������, ���ڸ� ��� ������ ����
			if(!bikeController)
			{
				bikeController = _bikeController;
			}
			// �������� ���� ���������� ���� (left -1, right 1)
			turnDirection.x = (float)bikeController.CurrentTurnDirection;

			if(bikeController.CurrentSpeed > 0)
			{
				// Translate �Լ��� �Է¹��� Vec3 �������� �̵���Ŵ
				transform.Translate(turnDirection * bikeController.turnDistance);
			}
		}
	}
}