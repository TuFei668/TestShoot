using UnityEngine;
using System.Collections;

public interface ISelfScrollItem
{
	/// <summary>
	/// Transform 对象
	/// </summary>
	/// <returns>The transform.</returns>
	Transform GetTransform();

	/// <summary>
	/// 设置偏移位置
	/// </summary>
	/// <param name="xOffset">X offset.</param>
	/// <param name="yOffset">Y offset.</param>
	void SetOffset(float xOffset, float yOffset);

	/// <summary>
	/// 设置数据索引
	/// </summary>
	/// <param name="dataIndex">Data index.</param>
	void SetIndex(int dataIndex);

	/// <summary>
	/// 获取数据索引
	/// </summary>
	/// <returns>The index.</returns>
	int GetIndex();

	/// <summary>
	/// 设置数据
	/// </summary>
	/// <param name="data">Data.</param>
	void SetData(object data);
}
