using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_LHUDSort : LuaObject {
	static public void reg(IntPtr l) {
		getTypeTable(l,"LHUDSort");
		createTypeMetatable(l,null, typeof(LHUDSort),typeof(UnityEngine.MonoBehaviour));
	}
}
