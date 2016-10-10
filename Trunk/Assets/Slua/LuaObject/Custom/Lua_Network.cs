using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_Network : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetProtoBytes(IntPtr l) {
		try {
			Network self=(Network)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetProtoBytes(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int connect(IntPtr l) {
		try {
			Network self=(Network)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.connect(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int send(IntPtr l) {
		try {
			Network self=(Network)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			SLua.ByteArray a2;
			checkType(l,3,out a2);
			self.send(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int valid(IntPtr l) {
		try {
			Network self=(Network)checkSelf(l);
			var ret=self.valid();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int close(IntPtr l) {
		try {
			Network self=(Network)checkSelf(l);
			self.close();
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
			var ret=Network.GetInstance();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onConnect(IntPtr l) {
		try {
			Network self=(Network)checkSelf(l);
			System.Action<System.Boolean> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onConnect=v;
			else if(op==1) self.onConnect+=v;
			else if(op==2) self.onConnect-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onDisconnect(IntPtr l) {
		try {
			Network self=(Network)checkSelf(l);
			System.Action v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onDisconnect=v;
			else if(op==1) self.onDisconnect+=v;
			else if(op==2) self.onDisconnect-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_onHandleMessage(IntPtr l) {
		try {
			Network self=(Network)checkSelf(l);
			System.Action<System.UInt16,SLua.ByteArray> v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.onHandleMessage=v;
			else if(op==1) self.onHandleMessage+=v;
			else if(op==2) self.onHandleMessage-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"Network");
		addMember(l,GetProtoBytes);
		addMember(l,connect);
		addMember(l,send);
		addMember(l,valid);
		addMember(l,close);
		addMember(l,GetInstance_s);
		addMember(l,"onConnect",null,set_onConnect,true);
		addMember(l,"onDisconnect",null,set_onDisconnect,true);
		addMember(l,"onHandleMessage",null,set_onHandleMessage,true);
		createTypeMetatable(l,null, typeof(Network),typeof(UnityEngine.MonoBehaviour));
	}
}
