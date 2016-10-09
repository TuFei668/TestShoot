using UnityEngine;
using System.Collections;

public class TestScrollItem : SelfScrollItem 
{
	public UILabel uiLabel;

	public override void SetData (object data)
	{
		base.SetData (data);
		this.uiLabel.text = data.ToString ();
	}
}
