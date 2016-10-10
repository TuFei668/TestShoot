using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LGameConfig : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLoadUrl(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetLoadUrl(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetLoadUrlForDir(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.GetLoadUrlForDir(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstance_s(IntPtr l) {
		try {
			var ret=LGameConfig.GetInstance();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetABNameWithAtlasPath_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=LGameConfig.GetABNameWithAtlasPath(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CONFIG_FILE(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.CONFIG_FILE);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DATA_CATAGORY_LUA(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.DATA_CATAGORY_LUA);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ASSETBUNDLE_PATH(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.ASSETBUNDLE_PATH);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ASSETBUNDLE_AFFIX(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.ASSETBUNDLE_AFFIX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_FILE_AFFIX_LUA(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.FILE_AFFIX_LUA);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_UPDATE_FILE_ZIP(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.UPDATE_FILE_ZIP);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_ASSET_BASE_FORMAT(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.ASSET_BASE_FORMAT);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_EncryptKey32(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.EncryptKey32);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_EncryptKey32(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			LGameConfig.EncryptKey32=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_EncryptKey16(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.EncryptKey16);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_EncryptKey16(IntPtr l) {
		try {
			System.String v;
			checkType(l,2,out v);
			LGameConfig.EncryptKey16=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isDebug(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isDebug);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isDebug(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isDebug=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isHotFix(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isHotFix);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isHotFix(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isHotFix=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isShowFps(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isShowFps);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isShowFps(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isShowFps=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isEncrypt(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isEncrypt);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_isEncrypt(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.isEncrypt=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_SERVER_RES_URL(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.SERVER_RES_URL);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_SERVER_RES_URL(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.SERVER_RES_URL=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_DEFAULT_FRAME_RATE(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.DEFAULT_FRAME_RATE);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_DEFAULT_FRAME_RATE(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			LGameConfig.DEFAULT_FRAME_RATE=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_LOCAL_URL_PREFIX(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LGameConfig.LOCAL_URL_PREFIX);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_PersistentAssetsPath(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.PersistentAssetsPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_StreamingAssetsPath(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.StreamingAssetsPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_CachingAssetsPath(IntPtr l) {
		try {
			LGameConfig self=(LGameConfig)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.CachingAssetsPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"LGameConfig");
		addMember(l,GetLoadUrl);
		addMember(l,GetLoadUrlForDir);
		addMember(l,GetInstance_s);
		addMember(l,GetABNameWithAtlasPath_s);
		addMember(l,"CONFIG_FILE",get_CONFIG_FILE,null,false);
		addMember(l,"DATA_CATAGORY_LUA",get_DATA_CATAGORY_LUA,null,false);
		addMember(l,"ASSETBUNDLE_PATH",get_ASSETBUNDLE_PATH,null,false);
		addMember(l,"ASSETBUNDLE_AFFIX",get_ASSETBUNDLE_AFFIX,null,false);
		addMember(l,"FILE_AFFIX_LUA",get_FILE_AFFIX_LUA,null,false);
		addMember(l,"UPDATE_FILE_ZIP",get_UPDATE_FILE_ZIP,null,false);
		addMember(l,"ASSET_BASE_FORMAT",get_ASSET_BASE_FORMAT,null,false);
		addMember(l,"EncryptKey32",get_EncryptKey32,set_EncryptKey32,false);
		addMember(l,"EncryptKey16",get_EncryptKey16,set_EncryptKey16,false);
		addMember(l,"isDebug",get_isDebug,set_isDebug,true);
		addMember(l,"isHotFix",get_isHotFix,set_isHotFix,true);
		addMember(l,"isShowFps",get_isShowFps,set_isShowFps,true);
		addMember(l,"isEncrypt",get_isEncrypt,set_isEncrypt,true);
		addMember(l,"SERVER_RES_URL",get_SERVER_RES_URL,set_SERVER_RES_URL,true);
		addMember(l,"DEFAULT_FRAME_RATE",get_DEFAULT_FRAME_RATE,set_DEFAULT_FRAME_RATE,false);
		addMember(l,"LOCAL_URL_PREFIX",get_LOCAL_URL_PREFIX,null,false);
		addMember(l,"PersistentAssetsPath",get_PersistentAssetsPath,null,true);
		addMember(l,"StreamingAssetsPath",get_StreamingAssetsPath,null,true);
		addMember(l,"CachingAssetsPath",get_CachingAssetsPath,null,true);
		createTypeMetatable(l,null, typeof(LGameConfig));
	}
}
