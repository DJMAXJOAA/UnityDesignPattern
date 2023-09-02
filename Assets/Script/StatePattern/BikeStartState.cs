using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bike
{
	// IBikeState �������̽��� �����ϴ� ���� Ŭ����
	public class BikeStartState : MonoBehaviour, IBikeState
	{
		// �� �κ��� ���� ������ѳ��°� �ƴ϶� delegate�� ���� �̺�Ʈ��
		// bikestate Ŭ������ �ٸ� Ŭ������ ������ �ϴ��� �� �� ���� �ٲٴ°� ����
		// �׷��� �ٸ� Ŭ������ ���� �������� ��������
		private BikeController bikeController;

		public void Handle(BikeController _bikeController)
		{
			if(!bikeController)
			{
				// ���ڷ� �޾ƿ� _bikeController�� ������ ���
				bikeController = _bikeController;
			}
			// ���� �� ���� �ӵ��� �ְ�ӵ���
			bikeController.CurrentSpeed = _bikeController.maxSpeed;
		}

		void Update()
		{
			if(bikeController)
			{
				// ���� �ӵ��� 0 �̻��̸�
				if(bikeController.CurrentSpeed > 0)
				{
					// ������ ���ư��� ����
					bikeController.transform.Translate(
						Vector3.forward * (bikeController.CurrentSpeed * Time.deltaTime));
				}
			}
		}
	} 
}
