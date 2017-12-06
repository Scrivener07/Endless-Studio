using System;
using System.Diagnostics;


namespace ES2.Amplitude
{
	public static class Diagnostics
	{
		public static void Assert(bool condition) { }
		public static void Assert(Flags flags, bool condition) { }
		public static void Assert(StackFrame[] stackFrames, Flags flags, bool condition) { }
		public static void Assert(string format, params object[] args) { }
		public static void Assert(Flags flags, string format, params object[] args) { }
		public static void Assert(StackFrame[] stackFrames, Flags flags, string format, params object[] args) { }
		public static void Assert(bool condition, string format, params object[] args) { }
		public static void Assert(Flags flags, bool condition, string format, params object[] args) { }
		public static void Assert(StackFrame[] stackFrames, Flags flags, bool condition, string format, params object[] args) { }
		public static void AssertNotNull(object objectReference) { }
		public static void AssertNotNull(Flags flags, object objectReference) { }
		public static void AssertNotNull(StackFrame[] stackFrames, Flags flags, object objectReference) { }
		public static void Log(string message) { }
		public static void Log(string format, params object[] args) { }
		public static void Log(Flags flags, string message) { }
		public static void Log(Flags flags, string format, params object[] args) { }
		public static void LogError(string format, params object[] args) { }
		public static void LogError(string format) { }
		public static void LogError(string format, object args0) { }
		public static void LogError(Flags flags, string format, params object[] args) { }
		public static void LogError(Flags flags, string format) { }
		public static void LogError(Flags flags, string format, object arg0) { }
		public static void LogErrorNonBlocking(string format, params object[] args) { }
		public static void LogErrorNonBlocking(Flags flags, string format, params object[] args) { }
		public static void LogException(System.Exception exception) { }
		public static void LogException(Flags flags, System.Exception exception) { }
		public static void LogWarning(string format, params object[] args) { }
		public static void LogWarning(string format) { }
		public static void LogWarning(string format, object param0) { }
		public static void LogWarning(string format, object param0, object param1) { }
		public static void LogWarning(Flags flags, string format, params object[] args) { }
		public static void Flush() { }
		public static void UnPause() { }


		[Flags]
		public enum Flags
		{
			None = 0,
			All = -1,
			Default = 1,
			Audio = 2,
			AI = 4,
			Data = 8,
			Gameplay = 16,
			GUI = 32,
			Network = 64,
			Order = 128,
			Unity = 256,
			View = 512,
			Editor = 1024,
			Battle = 2048,
			Wwise = 4096,
			Framework = 8192,
			Session = 16384,
			DebugUI = 32768,
			Overlay = DebugUI,
			Runtime = 65536,
			GameServer = 131072,
			GameClient = 262144,
			Input = 524288,
			VR = 1048576,
			AGE = 2097152,
			FREETOUSE0 = 4194304,
			HxFx = 8388608,
			Quest = 16777216,
			Jenkins = 33554432,
			Prism = 67108864,
			Generator = 134217728,
		}


	}
}
