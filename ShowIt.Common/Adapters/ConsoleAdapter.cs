﻿using System;
using System.IO;
using System.Text;
using ShowIt.Common.Adapters.Contracts;

namespace ShowIt.Common.Adapters
{
	public class ConsoleAdapter : IConsoleAdapter
	{
		public bool IsInputRedirected
		{
			get { return Console.IsInputRedirected; }
		}

		public bool IsOutputRedirected
		{
			get { return Console.IsOutputRedirected; }
		}

		public bool IsErrorRedirected
		{
			get { return Console.IsErrorRedirected; }
		}

		public TextReader In
		{
			get { return Console.In; }
			set { Console.SetIn(value); }
		}

		public TextWriter Out
		{
			get { return Console.Out; }
			set { Console.SetOut(value); }
		}

		public TextWriter Error
		{
			get { return Console.Error; }
			set { Console.SetError(value); }
		}

		public Encoding InputEncoding
		{
			get { return Console.InputEncoding; }
			set { Console.InputEncoding = value; }
		}

		public Encoding OutputEncoding
		{
			get { return Console.OutputEncoding; }
			set { Console.OutputEncoding = value; }
		}

		public ConsoleColor BackgroundColor
		{
			get { return Console.BackgroundColor; }
			set { Console.BackgroundColor = value; }
		}

		public ConsoleColor ForegroundColor
		{
			get { return Console.ForegroundColor; }
			set { Console.ForegroundColor = value; }
		}

		public int BufferHeight
		{
			get { return Console.BufferHeight; }
			set { Console.BufferHeight = value; }
		}

		public int BufferWidth
		{
			get { return Console.BufferWidth; }
			set { Console.BufferWidth = value; }
		}

		public int WindowHeight
		{
			get { return Console.WindowHeight; }
			set { Console.WindowHeight = value; }
		}

		public int WindowWidth
		{
			get { return Console.WindowWidth; }
			set { Console.WindowWidth = value; }
		}

		public int LargestWindowHeight
		{
			get { return Console.LargestWindowHeight; }
		}

		public int LargestWindowWidth
		{
			get { return Console.LargestWindowWidth; }
		}

		public int WindowLeft
		{
			get { return Console.WindowLeft; }
			set { Console.WindowLeft = value; }
		}

		public int WindowTop
		{
			get { return Console.WindowTop; }
			set { Console.WindowTop = value; }
		}

		public int CursorLeft
		{
			get { return Console.CursorLeft; }
			set { Console.CursorLeft = value; }
		}

		public int CursorTop
		{
			get { return Console.CursorTop; }
			set { Console.CursorTop = value; }
		}

		public int CursorSize
		{
			get { return Console.CursorSize; }
			set { Console.CursorSize = value; }
		}

		public bool CursorVisible
		{
			get { return Console.CursorVisible; }
			set { Console.CursorVisible = value; }
		}

		public string Title
		{
			get { return Console.Title; }
			set { Console.Title = value; }
		}

		public bool KeyAvailable
		{
			get { return Console.KeyAvailable; }
		}

		public bool NumberLock
		{
			get { return Console.NumberLock; }
		}

		public bool CapsLock
		{
			get { return Console.CapsLock; }
		}

		public bool TreatControlCAsInput
		{
			get { return Console.TreatControlCAsInput; }
			set { Console.TreatControlCAsInput = value; }
		}

		public event ConsoleCancelEventHandler CancelKeyPress
		{
			add { Console.CancelKeyPress += value; }
			remove { Console.CancelKeyPress -= value; }
		}

		public void Beep()
		{
			Console.Beep();
		}

		public void Beep(int frequency, int duration)
		{
			Console.Beep(frequency, duration);
		}

		public void Clear()
		{
			Console.Clear();
		}

		public void ResetColor()
		{
			Console.ResetColor();
		}

		public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop)
		{
			Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop);
		}

		public void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor)
		{
			Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop, sourceChar, sourceForeColor, sourceBackColor);
		}

		public void SetBufferSize(int width, int height)
		{
			Console.SetBufferSize(width, height);
		}

		public void SetWindowSize(int width, int height)
		{
			Console.SetWindowSize(width, height);
		}

		public void SetWindowPosition(int left, int top)
		{
			Console.SetWindowPosition(left, top);
		}

		public void SetCursorPosition(int left, int top)
		{
			Console.SetCursorPosition(left, top);
		}

		public ConsoleKeyInfo ReadKey()
		{
			return Console.ReadKey();
		}

		public ConsoleKeyInfo ReadKey(bool intercept)
		{
			return Console.ReadKey(intercept);
		}

		public Stream OpenStandardError()
		{
			return Console.OpenStandardError();
		}

		public Stream OpenStandardError(int bufferSize)
		{
			return Console.OpenStandardError(bufferSize);
		}

		public Stream OpenStandardInput()
		{
			return Console.OpenStandardInput();
		}

		public Stream OpenStandardInput(int bufferSize)
		{
			return Console.OpenStandardInput(bufferSize);
		}

		public Stream OpenStandardOutput()
		{
			return Console.OpenStandardOutput();
		}

		public Stream OpenStandardOutput(int bufferSize)
		{
			return Console.OpenStandardOutput(bufferSize);
		}

		public int Read()
		{
			return Console.Read();
		}

		public string ReadLine()
		{
			return Console.ReadLine();
		}

		public void WriteLine()
		{
			Console.WriteLine();
		}

		public void WriteLine(bool value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(char value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(char[] buffer)
		{
			Console.WriteLine(buffer);
		}

		public void WriteLine(char[] buffer, int index, int count)
		{
			Console.WriteLine(buffer, index, count);
		}

		public void WriteLine(decimal value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(double value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(float value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(int value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(uint value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(long value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(ulong value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(object value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(string value)
		{
			Console.WriteLine(value);
		}

		public void WriteLine(string format, object arg0)
		{
			Console.WriteLine(format, arg0);
		}

		public void WriteLine(string format, object arg0, object arg1)
		{
			Console.WriteLine(format, arg0, arg1);
		}

		public void WriteLine(string format, object arg0, object arg1, object arg2)
		{
			Console.WriteLine(format, arg0, arg1, arg2);
		}

		public void WriteLine(string format, params object[] arg)
		{
			Console.WriteLine(format, arg);
		}

		public void Write(string format, object arg0)
		{
			Console.Write(format, arg0);
		}

		public void Write(string format, object arg0, object arg1)
		{
			Console.Write(format, arg0, arg1);
		}

		public void Write(string format, object arg0, object arg1, object arg2)
		{
			Console.Write(format, arg0, arg1, arg2);
		}

		public void Write(string format, params object[] arg)
		{
			Console.Write(format, arg);
		}

		public void Write(bool value)
		{
			Console.Write(value);
		}

		public void Write(char value)
		{
			Console.Write(value);
		}

		public void Write(char[] buffer)
		{
			Console.Write(buffer);
		}

		public void Write(char[] buffer, int index, int count)
		{
			Console.Write(buffer, index, count);
		}

		public void Write(double value)
		{
			Console.Write(value);
		}

		public void Write(decimal value)
		{
			Console.Write(value);
		}

		public void Write(float value)
		{
			Console.Write(value);
		}

		public void Write(int value)
		{
			Console.Write(value);
		}

		public void Write(uint value)
		{
			Console.Write(value);
		}

		public void Write(long value)
		{
			Console.Write(value);
		}

		public void Write(ulong value)
		{
			Console.Write(value);
		}

		public void Write(object value)
		{
			Console.Write(value);
		}

		public void Write(string value)
		{
			Console.Write(value);
		}
	}
}