using UnityEngine;
using System.Collections;

public class SelfScrollItem : MonoBehaviour, ISelfScrollItem
{
	/// <summary>
	/// Transform 对象
	/// </summary>
	/// <returns>The transform.</returns>
	public virtual Transform GetTransform() { return this.transform; }

	/// <summary>
	/// 设置偏移位置
	/// </summary>
	/// <param name="xOffset">X offset.</param>
	/// <param name="yOffset">Y offset.</param>
	public virtual void SetOffset(float xOffset, float yOffset) { this.transform.localPosition += new Vector3 (xOffset, yOffset, 0f); }
	
	private int dataIndex;
	public virtual void SetIndex(int dataIndex) { this.dataIndex = dataIndex;}
	public virtual int GetIndex() { return this.dataIndex; }

	/// <summary>
	/// 设置数据
	/// </summary>
	/// <param name="data">Data.</param>
	public virtual void SetData(object data)
	{

	}
}
