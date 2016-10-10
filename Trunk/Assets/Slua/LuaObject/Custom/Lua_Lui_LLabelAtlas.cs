using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Lui_LLabelAtlas : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int reload(IntPtr l) {
		try {
			Lui.LLabelAtlas self=(Lui.LLabelAtlas)checkSelf(l);
			self.reload();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_text(IntPtr l) {
		try {
			Lui.LLabelAtlas self=(Lui.LLabelAtlas)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.text);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_text(IntPtr l) {
		try {
			Lui.LLabelAtlas self=(Lui.LLabelAtlas)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.text=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_atlas(IntPtr l) {
		try {
			Lui.LLabelAtlas self=(Lui.LLabelAtlas)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.atlas);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_atlas(IntPtr l) {
		try {
			Lui.LLabelAtlas self=(Lui.LLabelAtlas)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.atlas=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Lui.LLabelAtlas");
		addMember(l,reload);
		addMember(l,"text",get_text,set_text,true);
		addMember(l,"atlas",get_atlas,set_atlas,true);
		createTypeMetatable(l,null, typeof(Lui.LLabelAtlas),typeof(UnityEngine.MonoBehaviour));
	}
}
