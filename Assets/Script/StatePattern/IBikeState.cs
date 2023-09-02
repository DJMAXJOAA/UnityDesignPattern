using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bike
{
	public interface IBikeState
	{
		void Handle(BikeController controller);
	}

}