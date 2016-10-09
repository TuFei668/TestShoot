using UnityEngine;
using System.Collections;

public interface ISelfScrollView
{
	/// <summary>
	/// 裁剪范围
	/// </summary>
	/// <returns>The view rect.</returns>
	Rect GetViewRect ();

	/// <summary>
	/// ITEM 裁剪范围
	/// </summary>
	/// <returns>The item rect.</returns>
	Rect GetItemRect();
}
