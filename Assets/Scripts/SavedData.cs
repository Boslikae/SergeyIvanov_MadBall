using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
	public sealed class SavedData<T> where T : struct
	{
		public int CountBonuses;
		public static T IdPlayer = default;
	}

}