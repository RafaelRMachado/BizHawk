using System;

using BizHawk.Client.Common;
using BizHawk.Emulation.Common;

using NLua;

namespace BizHawk.Client.EmuHawk
{
	/// <summary>
	/// Methods intentionally blank.
	/// </summary>
	public sealed class UnixLuaLibraries : LuaLibraries
	{
		public override string EngineName => null;

		public override void CallExitEvent(LuaFile lf)
		{
		}
		public override void CallFrameAfterEvent()
		{
		}
		public override void CallFrameBeforeEvent()
		{
		}
		public override void CallLoadStateEvent(string name)
		{
		}
		public override void CallSaveStateEvent(string name)
		{
		}
		public override void Close()
		{
		}

		public override NamedLuaFunction CreateAndRegisterNamedFunction(LuaFunction function, string theEvent, Action<string> logCallback, LuaFile luaFile, string name = null) => null;

		public override void EndLuaDrawing()
		{
		}
		public override void ExecuteString(string command)
		{
		}

		public override NLuaTableHelper GetTableHelper() => null;

		private static readonly LuaFunctionList EmptyLuaFunList = new LuaFunctionList();
		public override LuaFunctionList RegisteredFunctions => EmptyLuaFunList;
		public override GuiLuaLibrary GuiLibrary => null;

		public override bool RemoveNamedFunctionMatching(Func<NamedLuaFunction, bool> predicate) => false;

		public override void Restart(IEmulatorServiceProvider newServiceProvider)
		{
		}

		public override (bool WaitForFrame, bool Terminated) ResumeScript(LuaFile lf) => (false, false);

		public override void SpawnAndSetFileThread(string pathToLoad, LuaFile lf)
		{
		}
		public override void StartLuaDrawing()
		{
		}

		public override void RunScheduledDisposes()
		{
		}
	}
}