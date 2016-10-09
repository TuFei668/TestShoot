using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelfScrollView : MonoBehaviour, ISelfScrollView 
{
	public SelfScrollDirectionTypeEnum directionTypeEnum = SelfScrollDirectionTypeEnum.Vertical;
	public int MaxItemCount;
	public SelfScrollItem ScrollItem;
	public float YOffset;
	public List<object> DataList;
	public string Response;

	public List<ISelfScrollItem> itemList;

	private bool mousePress;
	private Vector3 mousePosition;
	private Vector3 offsetPosition;

	private SelfScrollViewManager selfScrollViewManager;

	void Awake()
	{
		this.AwakeBeforeHandler ();
		this.AwakeHandler ();
		this.AwakeAfterHandler ();
	}

	protected virtual void AwakeBeforeHandler() {}
	protected virtual void AwakeHandler()
	{
		if(this.itemList == null) this.itemList = new List<ISelfScrollItem>();
		// 设置 RECT 对象
		Rect viewRect = this.GetViewRect ();
		// 设置 ITEM RECT 对象
		Rect itemRect = this.GetItemRect ();
		// 初始化滚动管理
		this.selfScrollViewManager = new SelfScrollViewManager (viewRect, itemRect, this.YOffset);
		// 初始化引用
		GameObject newGameObjectReference = null;
		// 初始化元件
		SelfScrollItem selfScrollItem = null;
		// 设置 Y 偏移
		float yOffset = viewRect.y - itemRect.y;
		// 初始化子对象
		for(int index = 0; index < this.MaxItemCount; index ++)
		{
			newGameObjectReference = GameObject.Instantiate(this.ScrollItem.GetTransform().gameObject) as GameObject;
			if(newGameObjectReference != null)
			{
				newGameObjectReference.transform.parent = this.transform;
				newGameObjectReference.transform.localScale = Vector3.one;
				newGameObjectReference.transform.localPosition = new Vector3(0f, yOffset, 0f);
				
				selfScrollItem = newGameObjectReference.GetComponent<SelfScrollItem>();
				if(selfScrollItem != null)
				{
					yOffset -= (itemRect.y - itemRect.height + this.YOffset);
					newGameObjectReference.SetActive(true);
					selfScrollItem.SetIndex(index);
					this.itemList.Add(selfScrollItem);
					selfScrollItem.SetData(this.DataList[index]);
				}
				else
				{
					newGameObjectReference.SetActive(false);
				}
			}
		}
	}
	protected virtual void AwakeAfterHandler() {}

	/// <summary>
	/// 裁剪范围
	/// </summary>
	/// <returns>The view rect.</returns>
	public virtual Rect GetViewRect () { return new Rect (150, 150, -150, -150); }
	
	/// <summary>
	/// ITEM 裁剪区域
	/// </summary>
	/// <returns>The item rect.</returns>
	public virtual Rect GetItemRect() { return new Rect(-150, 50, 150, -50); }

	void Update()
	{
		this.UpdateBeforeHandler ();
		this.UpdateHandler ();
		this.UpdateAfterHandler ();
	}

	protected virtual void UpdateBeforeHandler() {}

	private SelfScrollView selfScrollView;
	protected virtual void UpdateHandler()
	{
		if(!string.IsNullOrEmpty(this.Response))
		{
			if(UICamera.hoveredObject != null)
			{
				this.selfScrollView = UICamera.hoveredObject.GetComponent<SelfScrollView>();
				if(this.selfScrollView == null) return;
				// 如果感觉数据不正确
				if(this.Response != this.selfScrollView.Response)
				{
					this.mousePress = false;
					return;
				}
			}else
			{
				this.mousePress = false;
				return;
			}
		}
		// 如果左键按下
		if(Input.GetMouseButtonDown(0))
		{
			this.mousePosition = Input.mousePosition;
			this.mousePress = true;
		}
		
		if(Input.GetMouseButtonUp(0))
		{
			this.mousePress = false;
		}
		
		if(this.mousePress)
		{
			this.offsetPosition = Input.mousePosition - this.mousePosition;
			this.mousePosition = Input.mousePosition;
			
			if(directionTypeEnum == SelfScrollDirectionTypeEnum.Vertical)
			{
				this.VerticalScrollProgress(this.offsetPosition.y);
			}
		}
	}
	protected virtual void UpdateAfterHandler() {}

	protected virtual void VerticalScrollProgress(float offset)
	{
		this.selfScrollViewManager.VerticalOperater(offset, this.itemList, this.DataList.Count, this.ItemCallback);
	}

	protected virtual void ItemCallback(ISelfScrollItem scrollItem)
	{
		int index = scrollItem.GetIndex ();
		if(index < 0 || index >= this.DataList.Count) return;
		((SelfScrollItem)scrollItem).SetData(this.DataList[index]);
	}
}