using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LLoadBundle : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetBundleByName(IntPtr l) {
		try {
			LLoadBundle self=(LLoadBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetBundleByName(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int LoadAllBundles(IntPtr l) {
		try {
			LLoadBundle self=(LLoadBundle)checkSelf(l);
			System.String[] a1;
			checkArray(l,2,out a1);
			UnityEngine.Events.UnityAction a2;
			LuaDelegation.checkDelegate(l,3,out a2);
			self.LoadAllBundles(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSpritesByName(IntPtr l) {
		try {
			LLoadBundle self=(LLoadBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			var ret=self.GetSpritesByName(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetSpriteByName(IntPtr l) {
		try {
			LLoadBundle self=(LLoadBundle)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.String a2;
			checkType(l,3,out a2);
			var ret=self.GetSpriteByName(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnloadBundles(IntPtr l) {
		try {
			LLoadBundle self=(LLoadBundle)checkSelf(l);
			System.String[] a1;
			checkArray(l,2,out a1);
			self.UnloadBundles(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstance_s(IntPtr l) {
		try {
			var ret=LLoadBundle.GetInstance();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LLoadBundle");
		addMember(l,GetBundleByName);
		addMember(l,LoadAllBundles);
		addMember(l,GetSpritesByName);
		addMember(l,GetSpriteByName);
		addMember(l,UnloadBundles);
		addMember(l,GetInstance_s);
		createTypeMetatable(l,null, typeof(LLoadBundle),typeof(UnityEngine.MonoBehaviour));
	}
}
