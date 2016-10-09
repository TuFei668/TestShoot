using UnityEngine;
using System.Collections.Generic;

public class TestScrollView : SelfScrollView 
{
	protected override void AwakeBeforeHandler ()
	{
		base.AwakeBeforeHandler ();

		this.DataList = new List<object> ();
		this.DataList.Add ("这是第一条数据");
		this.DataList.Add ("这是第二条数据");
		this.DataList.Add ("这是第三条数据");
		this.DataList.Add ("这是第四条数据");
		this.DataList.Add ("这是第五条数据");
		this.DataList.Add ("这是第六条数据");
		this.DataList.Add ("这是第七条数据");
	}
}
