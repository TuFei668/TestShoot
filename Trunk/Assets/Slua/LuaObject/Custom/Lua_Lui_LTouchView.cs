using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Lui_LTouchView : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerDown(IntPtr l) {
		try {
			Lui.LTouchView self=(Lui.LTouchView)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerDown(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnDrag(IntPtr l) {
		try {
			Lui.LTouchView self=(Lui.LTouchView)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnDrag(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int OnPointerUp(IntPtr l) {
		try {
			Lui.LTouchView self=(Lui.LTouchView)checkSelf(l);
			UnityEngine.EventSystems.PointerEventData a1;
			checkType(l,2,out a1);
			self.OnPointerUp(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onTouchHandler(IntPtr l) {
		try {
			Lui.LTouchView self=(Lui.LTouchView)checkSelf(l);
			UnityEngine.Events.UnityAction<UnityEngine.Vector2> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onTouchHandler=v;
			else if(op==1) self.onTouchHandler+=v;
			else if(op==2) self.onTouchHandler-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Lui.LTouchView");
		addMember(l,OnPointerDown);
		addMember(l,OnDrag);
		addMember(l,OnPointerUp);
		addMember(l,"onTouchHandler",null,set_onTouchHandler,true);
		createTypeMetatable(l,null, typeof(Lui.LTouchView),typeof(UnityEngine.MonoBehaviour));
	}
}
