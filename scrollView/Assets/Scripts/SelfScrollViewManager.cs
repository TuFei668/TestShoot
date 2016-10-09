using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class SelfScrollViewManager
{
	/// <summary>
	/// Y 轴总偏移
	/// </summary>
	public float yTotalOffset;

	/// <summary>
	/// Y 轴最大偏移
	/// </summary>
	private float yMaxOffset;

	private Rect viewRect;
	private Rect itemRect;
	private float yOffset;

	public SelfScrollViewManager(Rect viewRect, Rect itemRect, float yOffset)
	{
		this.viewRect = viewRect;
		this.itemRect = itemRect;
		this.yOffset = yOffset;
	}

	/// <summary>
	/// 垂直滚动
	/// </summary>
	/// <param name="viewRect">View rect.</param>
	/// <param name="offset">Offset.</param>
	/// <param name="itemList">Item list.</param>
	/// <param name="callback">Callback.</param>
	public void VerticalOperater(float offset, List<ISelfScrollItem> itemList, int dataLength, Action<ISelfScrollItem> callback = null)
	{
		if(this.yMaxOffset == 0)
		{
			float viewRectHeight = this.viewRect.y - this.viewRect.height;
			float itemRectHeight = this.itemRect.y - this.itemRect.height;

			this.yMaxOffset = itemRectHeight * (dataLength - (int)(viewRectHeight / itemRectHeight)) - (viewRectHeight % itemRectHeight) + yOffset * (dataLength - 1);
		}
		// 如果向下滚动
		if(offset > 0)
		{
			if(this.yTotalOffset + offset <= this.yMaxOffset)
			{
				// 设置总偏移位置
				this.yTotalOffset += offset;
			}
			else
			{
				// 如果偏移位置不为最大
				if(this.yTotalOffset != this.yMaxOffset)
				{
					// 设置新的偏移位置
					offset = this.yMaxOffset - this.yTotalOffset;
					// 设置总偏移位置为最大偏移位置
					this.yTotalOffset = this.yMaxOffset;
				}else
				{
					return;
				}
			}
		}else
		{
			// 如果没有超出整体范围
			if(this.yTotalOffset + offset >= 0)
			{
				this.yTotalOffset += offset;
			}else
			{
				// 如果偏移位置不为零
				if(this.yTotalOffset != 0)
				{
					// 设置新的偏移位置
					offset = -this.yTotalOffset;
					// 设置总偏移位置
					this.yTotalOffset = 0;
				}else
				{
					return;
				}
			}
		}

		// 变动的 ITEM 列表
		List<ISelfScrollItem> changeItemList = new List<ISelfScrollItem> ();
		// 最后操作的滚动 ITEM
		ISelfScrollItem lastSelfScrollItem = null;
		// 遍历对象列表，设置偏移位置，并且检查对象是否超过了裁剪对象
		foreach(ISelfScrollItem iSelfScrollItem in itemList)
		{
			// 设置偏移位置
			iSelfScrollItem.SetOffset(0, offset);
			// 如果不在裁剪范围内
			if(iSelfScrollItem.GetTransform().localPosition.y + this.itemRect.height > this.viewRect.y || iSelfScrollItem.GetTransform().localPosition.y + this.itemRect.y < this.viewRect.height)
			{
				changeItemList.Add(iSelfScrollItem);
			}else
			{
				// 如果是向上滚动
				if(offset > 0)
				{
					lastSelfScrollItem = iSelfScrollItem;
				}else
				{
					// 如果是向下滚动
					if(lastSelfScrollItem == null) lastSelfScrollItem = iSelfScrollItem;
				}
			}
		}

		// 如果需要更新 Item 位置
		if(changeItemList != null && changeItemList.Count > 0)
		{
			float yPos = 0f;
			// 如果是向上滚动
			if(offset > 0)
			{
				yPos = lastSelfScrollItem.GetTransform().localPosition.y - (this.itemRect.y - this.itemRect.height) - yOffset;
			}
			else
			{
				// 如果是向下滚动
				yPos = lastSelfScrollItem.GetTransform().localPosition.y + (this.itemRect.y - this.itemRect.height) + yOffset;
			}

			foreach(ISelfScrollItem iSelfScrollItem in changeItemList)
			{
				// 设置新位置
				iSelfScrollItem.GetTransform().localPosition = new Vector3(iSelfScrollItem.GetTransform().localPosition.x, yPos, 0f);
				// 从列表中移除
				itemList.Remove(iSelfScrollItem);
				// 如果是向上滚动
				if(offset > 0)
				{
					// 添加到列表的最后
					itemList.Add(iSelfScrollItem);
					// 设置新的 Y 偏移位置
					yPos = (iSelfScrollItem.GetTransform().localPosition.y - (this.itemRect.y - this.itemRect.height));
					// 检查索引正确性
					if(lastSelfScrollItem.GetIndex() + 1 < dataLength)
					{
						// 设置新的数据索引
						iSelfScrollItem.SetIndex(lastSelfScrollItem.GetIndex() + 1);
						// 调用回调函数
						if(callback != null)callback(iSelfScrollItem);
					}
				}else
				{
					// 添加到列表的最前端
					itemList.Insert(0, iSelfScrollItem);
					// 设置新的 Y 偏移位置
					yPos = (iSelfScrollItem.GetTransform().localPosition.y + (this.itemRect.y - this.itemRect.height));
					// 检查索引正确性
					if(lastSelfScrollItem.GetIndex() - 1 >= 0)
					{
						// 设置新的数据索引
						iSelfScrollItem.SetIndex(lastSelfScrollItem.GetIndex() - 1);
						// 调用回调函数
						if(callback != null)callback(iSelfScrollItem);
					}
				}
			}
		}
	}
}
