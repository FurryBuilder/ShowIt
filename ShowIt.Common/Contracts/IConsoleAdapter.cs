using System;
using System.IO;
using System.Text;

namespace ShowIt.Common.Contracts
{
	/// <summary>
	/// Represents the standard input, output, and error streams for console applications.
	/// </summary>
	/// <filterpriority>1</filterpriority>
	public interface IConsoleAdapter
	{
		bool IsInputRedirected { get; }

		bool IsOutputRedirected { get; }

		bool IsErrorRedirected { get; }

		/// <summary>
		/// Gets or sets the standard input stream.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.IO.TextReader"/> that represents the standard input stream.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		TextReader In { get; set; }

		/// <summary>
		/// Gets or sets the standard output stream.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.IO.TextWriter"/> that represents the standard output stream.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		TextWriter Out { get; set; }

		/// <summary>
		/// Gets or sets the standard error output stream.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.IO.TextWriter"/> that represents the standard error output stream.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		TextWriter Error { get; set; }

		/// <summary>
		/// Gets or sets the encoding the console uses to read input.
		/// </summary>
		/// 
		/// <returns>
		/// The encoding used to read console input.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException">The property value in a set operation is null.</exception><exception cref="T:System.PlatformNotSupportedException">This property's set operation is not supported on Windows 98, Windows 98 Second Edition, or Windows Millennium Edition.</exception><exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception><exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception><filterpriority>1</filterpriority>
		Encoding InputEncoding { get; set; }

		/// <summary>
		/// Gets or sets the encoding the console uses to write output.
		/// </summary>
		/// 
		/// <returns>
		/// The encoding used to write console output.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException">The property value in a set operation is null.</exception><exception cref="T:System.PlatformNotSupportedException">This property's set operation is not supported on Windows 98, Windows 98 Second Edition, or Windows Millennium Edition.</exception><exception cref="T:System.IO.IOException">An error occurred during the execution of this operation.</exception><exception cref="T:System.Security.SecurityException">Your application does not have permission to perform this operation.</exception><filterpriority>1</filterpriority>
		Encoding OutputEncoding { get; set; }

		/// <summary>
		/// Gets or sets the background color of the console.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.ConsoleColor"/> that specifies the background color of the console; that is, the color that appears behind each character. The default is black.
		/// </returns>
		/// <exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		ConsoleColor BackgroundColor { get; set; }

		/// <summary>
		/// Gets or sets the foreground color of the console.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.ConsoleColor"/> that specifies the foreground color of the console; that is, the color of each character that is displayed. The default is gray.
		/// </returns>
		/// <exception cref="T:System.ArgumentException">The color specified in a set operation is not a valid member of <see cref="T:System.ConsoleColor"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		ConsoleColor ForegroundColor { get; set; }

		/// <summary>
		/// Gets or sets the height of the buffer area.
		/// </summary>
		/// 
		/// <returns>
		/// The current height, in rows, of the buffer area.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.-or- The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue"/>.-or- The value in a set operation is less than <see cref="P:System.Console.WindowTop"/> + <see cref="P:System.Console.WindowHeight"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		int BufferHeight { get; set; }

		/// <summary>
		/// Gets or sets the width of the buffer area.
		/// </summary>
		/// 
		/// <returns>
		/// The current width, in columns, of the buffer area.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than or equal to zero.-or- The value in a set operation is greater than or equal to <see cref="F:System.Int16.MaxValue"/>.-or- The value in a set operation is less than <see cref="P:System.Console.WindowLeft"/> + <see cref="P:System.Console.WindowWidth"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		int BufferWidth { get; set; }

		/// <summary>
		/// Gets or sets the height of the console window area.
		/// </summary>
		/// 
		/// <returns>
		/// The height of the console window measured in rows.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth"/> property or the value of the <see cref="P:System.Console.WindowHeight"/> property is less than or equal to 0.-or-The value of the <see cref="P:System.Console.WindowHeight"/> property plus the value of the <see cref="P:System.Console.WindowTop"/> property is greater than or equal to <see cref="F:System.Int16.MaxValue"/>.-or-The value of the <see cref="P:System.Console.WindowWidth"/> property or the value of the <see cref="P:System.Console.WindowHeight"/> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception><exception cref="T:System.IO.IOException">Error reading or writing information.</exception><filterpriority>1</filterpriority>
		int WindowHeight { get; set; }

		/// <summary>
		/// Gets or sets the width of the console window.
		/// </summary>
		/// 
		/// <returns>
		/// The width of the console window measured in columns.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value of the <see cref="P:System.Console.WindowWidth"/> property or the value of the <see cref="P:System.Console.WindowHeight"/> property is less than or equal to 0.-or-The value of the <see cref="P:System.Console.WindowHeight"/> property plus the value of the <see cref="P:System.Console.WindowTop"/> property is greater than or equal to <see cref="F:System.Int16.MaxValue"/>.-or-The value of the <see cref="P:System.Console.WindowWidth"/> property or the value of the <see cref="P:System.Console.WindowHeight"/> property is greater than the largest possible window width or height for the current screen resolution and console font.</exception><exception cref="T:System.IO.IOException">Error reading or writing information.</exception><filterpriority>1</filterpriority>
		int WindowWidth { get; set; }

		/// <summary>
		/// Gets the largest possible number of console window rows, based on the current font and screen resolution.
		/// </summary>
		/// 
		/// <returns>
		/// The height of the largest possible console window measured in rows.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		int LargestWindowHeight { get; }

		/// <summary>
		/// Gets the largest possible number of console window columns, based on the current font and screen resolution.
		/// </summary>
		/// 
		/// <returns>
		/// The width of the largest possible console window measured in columns.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		int LargestWindowWidth { get; }

		/// <summary>
		/// Gets or sets the leftmost position of the console window area relative to the screen buffer.
		/// </summary>
		/// 
		/// <returns>
		/// The leftmost console window position measured in columns.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.-or-As a result of the assignment, <see cref="P:System.Console.WindowLeft"/> plus <see cref="P:System.Console.WindowWidth"/> would exceed <see cref="P:System.Console.BufferWidth"/>. </exception><exception cref="T:System.IO.IOException">Error reading or writing information.</exception><filterpriority>1</filterpriority>
		int WindowLeft { get; set; }

		/// <summary>
		/// Gets or sets the top position of the console window area relative to the screen buffer.
		/// </summary>
		/// 
		/// <returns>
		/// The uppermost console window position measured in rows.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the value to be assigned is less than zero.-or-As a result of the assignment, <see cref="P:System.Console.WindowTop"/> plus <see cref="P:System.Console.WindowHeight"/> would exceed <see cref="P:System.Console.BufferHeight"/>.</exception><exception cref="T:System.IO.IOException">Error reading or writing information.</exception><filterpriority>1</filterpriority>
		int WindowTop { get; set; }

		/// <summary>
		/// Gets or sets the column position of the cursor within the buffer area.
		/// </summary>
		/// 
		/// <returns>
		/// The current position, in columns, of the cursor.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.-or- The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferWidth"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		int CursorLeft { get; set; }

		/// <summary>
		/// Gets or sets the row position of the cursor within the buffer area.
		/// </summary>
		/// 
		/// <returns>
		/// The current position, in rows, of the cursor.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value in a set operation is less than zero.-or- The value in a set operation is greater than or equal to <see cref="P:System.Console.BufferHeight"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority>
		int CursorTop { get; set; }

		/// <summary>
		/// Gets or sets the height of the cursor within a character cell.
		/// </summary>
		/// 
		/// <returns>
		/// The size of the cursor expressed as a percentage of the height of a character cell. The property value ranges from 1 to 100.
		/// </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified in a set operation is less than 1 or greater than 100. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		int CursorSize { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the cursor is visible.
		/// </summary>
		/// 
		/// <returns>
		/// true if the cursor is visible; otherwise, false.
		/// </returns>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		bool CursorVisible { get; set; }

		/// <summary>
		/// Gets or sets the title to display in the console title bar.
		/// </summary>
		/// 
		/// <returns>
		/// The string to be displayed in the title bar of the console. The maximum length of the title string is 24500 characters.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException">In a get operation, the retrieved title is longer than 24500 characters. </exception><exception cref="T:System.ArgumentOutOfRangeException">In a set operation, the specified title is longer than 24500 characters. </exception><exception cref="T:System.ArgumentNullException">In a set operation, the specified title is null. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		string Title
		{
			get;
			set;
		}

		/// <summary>
		/// Gets a value indicating whether a key press is available in the input stream.
		/// </summary>
		/// 
		/// <returns>
		/// true if a key press is available; otherwise, false.
		/// </returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.InvalidOperationException">Standard input is redirected to a file instead of the keyboard. </exception><filterpriority>1</filterpriority>
		bool KeyAvailable { get; }

		/// <summary>
		/// Gets a value indicating whether the NUM LOCK keyboard toggle is turned on or turned off.
		/// </summary>
		/// 
		/// <returns>
		/// true if NUM LOCK is turned on; false if NUM LOCK is turned off.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		bool NumberLock { get; }

		/// <summary>
		/// Gets a value indicating whether the CAPS LOCK keyboard toggle is turned on or turned off.
		/// </summary>
		/// 
		/// <returns>
		/// true if CAPS LOCK is turned on; false if CAPS LOCK is turned off.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		bool CapsLock { get; }

		/// <summary>
		/// Gets or sets a value indicating whether the combination of the <see cref="F:System.ConsoleModifiers.Control"/> modifier key and <see cref="F:System.ConsoleKey.C"/> console key (CTRL+C) is treated as ordinary input or as an interruption that is handled by the operating system.
		/// </summary>
		/// 
		/// <returns>
		/// true if CTRL+C is treated as ordinary input; otherwise, false.
		/// </returns>
		/// <exception cref="T:System.IO.IOException">Unable to get or set the input mode of the console input buffer. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		bool TreatControlCAsInput { get; set; }

		/// <summary>
		/// Occurs when the <see cref="F:System.ConsoleModifiers.Control"/> modifier key (CTRL) and <see cref="F:System.ConsoleKey.C"/> console key (C) are pressed simultaneously (CTRL+C).
		/// </summary>
		/// <filterpriority>1</filterpriority>
		event ConsoleCancelEventHandler CancelKeyPress;

		/// <summary>
		/// Plays the sound of a beep through the console speaker.
		/// </summary>
		/// <exception cref="T:System.Security.HostProtectionException">This method was executed on a server, such as SQL Server, that does not permit access to a user interface.</exception><filterpriority>1</filterpriority>
		void Beep();

		/// <summary>
		/// Plays the sound of a beep of a specified frequency and duration through the console speaker.
		/// </summary>
		/// <param name="frequency">The frequency of the beep, ranging from 37 to 32767 hertz.</param><param name="duration">The duration of the beep measured in milliseconds.</param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="frequency"/> is less than 37 or more than 32767 hertz.-or-<paramref name="duration"/> is less than or equal to zero.</exception><exception cref="T:System.Security.HostProtectionException">This method was executed on a server, such as SQL Server, that does not permit access to the console.</exception><filterpriority>1</filterpriority>
		void Beep(int frequency, int duration);

		/// <summary>
		/// Clears the console buffer and corresponding console window of display information.
		/// </summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority>
		void Clear();

		/// <summary>
		/// Sets the foreground and background console colors to their defaults.
		/// </summary>
		/// <exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		void ResetColor();

		/// <summary>
		/// Copies a specified source area of the screen buffer to a specified destination area.
		/// </summary>
		/// <param name="sourceLeft">The leftmost column of the source area. </param><param name="sourceTop">The topmost row of the source area. </param><param name="sourceWidth">The number of columns in the source area. </param><param name="sourceHeight">The number of rows in the source area. </param><param name="targetLeft">The leftmost column of the destination area. </param><param name="targetTop">The topmost row of the destination area. </param><exception cref="T:System.ArgumentOutOfRangeException">One or more of the parameters is less than zero.-or- <paramref name="sourceLeft"/> or <paramref name="targetLeft"/> is greater than or equal to <see cref="P:System.Console.BufferWidth"/>.-or- <paramref name="sourceTop"/> or <paramref name="targetTop"/> is greater than or equal to <see cref="P:System.Console.BufferHeight"/>.-or- <paramref name="sourceTop"/> + <paramref name="sourceHeight"/> is greater than or equal to <see cref="P:System.Console.BufferHeight"/>.-or- <paramref name="sourceLeft"/> + <paramref name="sourceWidth"/> is greater than or equal to <see cref="P:System.Console.BufferWidth"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop);

		/// <summary>
		/// Copies a specified source area of the screen buffer to a specified destination area.
		/// </summary>
		/// <param name="sourceLeft">The leftmost column of the source area. </param><param name="sourceTop">The topmost row of the source area. </param><param name="sourceWidth">The number of columns in the source area. </param><param name="sourceHeight">The number of rows in the source area. </param><param name="targetLeft">The leftmost column of the destination area. </param><param name="targetTop">The topmost row of the destination area. </param><param name="sourceChar">The character used to fill the source area. </param><param name="sourceForeColor">The foreground color used to fill the source area. </param><param name="sourceBackColor">The background color used to fill the source area. </param><exception cref="T:System.ArgumentOutOfRangeException">One or more of the parameters is less than zero.-or- <paramref name="sourceLeft"/> or <paramref name="targetLeft"/> is greater than or equal to <see cref="P:System.Console.BufferWidth"/>.-or- <paramref name="sourceTop"/> or <paramref name="targetTop"/> is greater than or equal to <see cref="P:System.Console.BufferHeight"/>.-or- <paramref name="sourceTop"/> + <paramref name="sourceHeight"/> is greater than or equal to <see cref="P:System.Console.BufferHeight"/>.-or- <paramref name="sourceLeft"/> + <paramref name="sourceWidth"/> is greater than or equal to <see cref="P:System.Console.BufferWidth"/>. </exception><exception cref="T:System.ArgumentException">One or both of the color parameters is not a member of the <see cref="T:System.ConsoleColor"/> enumeration. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		void MoveBufferArea(int sourceLeft, int sourceTop, int sourceWidth, int sourceHeight, int targetLeft, int targetTop, char sourceChar, ConsoleColor sourceForeColor, ConsoleColor sourceBackColor);

		/// <summary>
		/// Sets the height and width of the screen buffer area to the specified values.
		/// </summary>
		/// <param name="width">The width of the buffer area measured in columns. </param><param name="height">The height of the buffer area measured in rows. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="height"/> or <paramref name="width"/> is less than or equal to zero.-or- <paramref name="height"/> or <paramref name="width"/> is greater than or equal to <see cref="F:System.Int16.MaxValue"/>.-or- <paramref name="width"/> is less than <see cref="P:System.Console.WindowLeft"/> + <see cref="P:System.Console.WindowWidth"/>.-or- <paramref name="height"/> is less than <see cref="P:System.Console.WindowTop"/> + <see cref="P:System.Console.WindowHeight"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		void SetBufferSize(int width, int height);

		/// <summary>
		/// Sets the height and width of the console window to the specified values.
		/// </summary>
		/// <param name="width">The width of the console window measured in columns. </param><param name="height">The height of the console window measured in rows. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="width"/> or <paramref name="height"/> is less than or equal to zero.-or- <paramref name="width"/> plus <see cref="P:System.Console.WindowLeft"/> or <paramref name="height"/> plus <see cref="P:System.Console.WindowTop"/> is greater than or equal to <see cref="F:System.Int16.MaxValue"/>. -or-<paramref name="width"/> or <paramref name="height"/> is greater than the largest possible window width or height for the current screen resolution and console font.</exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		void SetWindowSize(int width, int height);

		/// <summary>
		/// Sets the position of the console window relative to the screen buffer.
		/// </summary>
		/// <param name="left">The column position of the upper left  corner of the console window. </param><param name="top">The row position of the upper left corner of the console window. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="left"/> or <paramref name="top"/> is less than zero.-or- <paramref name="left"/> + <see cref="P:System.Console.WindowWidth"/> is greater than <see cref="P:System.Console.BufferWidth"/>.-or- <paramref name="top"/> + <see cref="P:System.Console.WindowHeight"/> is greater than <see cref="P:System.Console.BufferHeight"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		void SetWindowPosition(int left, int top);

		/// <summary>
		/// Sets the position of the cursor.
		/// </summary>
		/// <param name="left">The column position of the cursor. </param><param name="top">The row position of the cursor. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="left"/> or <paramref name="top"/> is less than zero.-or- <paramref name="left"/> is greater than or equal to <see cref="P:System.Console.BufferWidth"/>.-or- <paramref name="top"/> is greater than or equal to <see cref="P:System.Console.BufferHeight"/>. </exception><exception cref="T:System.Security.SecurityException">The user does not have permission to perform this action. </exception><exception cref="T:System.IO.IOException">An I/O error occurred.</exception><filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.UIPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Window="SafeTopLevelWindows"/></PermissionSet>
		void SetCursorPosition(int left, int top);

		/// <summary>
		/// Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.ConsoleKeyInfo"/> object that describes the <see cref="T:System.ConsoleKey"/> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo"/> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers"/> values, whether one or more SHIFT, ALT, or CTRL modifier keys was pressed simultaneously with the console key.
		/// </returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In"/> property is redirected from some stream other than the console.</exception><filterpriority>1</filterpriority>
		ConsoleKeyInfo ReadKey();

		/// <summary>
		/// Obtains the next character or function key pressed by the user. The pressed key is optionally displayed in the console window.
		/// </summary>
		/// 
		/// <returns>
		/// A <see cref="T:System.ConsoleKeyInfo"/> object that describes the <see cref="T:System.ConsoleKey"/> constant and Unicode character, if any, that correspond to the pressed console key. The <see cref="T:System.ConsoleKeyInfo"/> object also describes, in a bitwise combination of <see cref="T:System.ConsoleModifiers"/> values, whether one or more SHIFT, ALT, or CTRL modifier keys was pressed simultaneously with the console key.
		/// </returns>
		/// <param name="intercept">Determines whether to display the pressed key in the console window. true to not display the pressed key; otherwise, false. </param><exception cref="T:System.InvalidOperationException">The <see cref="P:System.Console.In"/> property is redirected from some stream other than the console.</exception><filterpriority>1</filterpriority>
		ConsoleKeyInfo ReadKey(bool intercept);

		/// <summary>
		/// Acquires the standard error stream.
		/// </summary>
		/// 
		/// <returns>
		/// The standard error stream.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		Stream OpenStandardError();

		/// <summary>
		/// Acquires the standard error stream, which is set to a specified buffer size.
		/// </summary>
		/// 
		/// <returns>
		/// The standard error stream.
		/// </returns>
		/// <param name="bufferSize">The internal stream buffer size. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than or equal to zero. </exception><filterpriority>1</filterpriority>
		Stream OpenStandardError(int bufferSize);

		/// <summary>
		/// Acquires the standard input stream.
		/// </summary>
		/// 
		/// <returns>
		/// The standard input stream.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		Stream OpenStandardInput();

		/// <summary>
		/// Acquires the standard input stream, which is set to a specified buffer size.
		/// </summary>
		/// 
		/// <returns>
		/// The standard input stream.
		/// </returns>
		/// <param name="bufferSize">The internal stream buffer size. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than or equal to zero. </exception><filterpriority>1</filterpriority>
		Stream OpenStandardInput(int bufferSize);

		/// <summary>
		/// Acquires the standard output stream.
		/// </summary>
		/// 
		/// <returns>
		/// The standard output stream.
		/// </returns>
		/// <filterpriority>1</filterpriority>
		Stream OpenStandardOutput();

		/// <summary>
		/// Acquires the standard output stream, which is set to a specified buffer size.
		/// </summary>
		/// 
		/// <returns>
		/// The standard output stream.
		/// </returns>
		/// <param name="bufferSize">The internal stream buffer size. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="bufferSize"/> is less than or equal to zero. </exception><filterpriority>1</filterpriority>
		Stream OpenStandardOutput(int bufferSize);

		/// <summary>
		/// Reads the next character from the standard input stream.
		/// </summary>
		/// 
		/// <returns>
		/// The next character from the input stream, or negative one (-1) if there are currently no more characters to be read.
		/// </returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		int Read();

		/// <summary>
		/// Reads the next line of characters from the standard input stream.
		/// </summary>
		/// 
		/// <returns>
		/// The next line of characters from the input stream, or null if no more lines are available.
		/// </returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.OutOfMemoryException">There is insufficient memory to allocate a buffer for the returned string. </exception><exception cref="T:System.ArgumentOutOfRangeException">The number of characters in the next line of characters is greater than <see cref="F:System.Int32.MaxValue"/>.</exception><filterpriority>1</filterpriority>
		string ReadLine();

		/// <summary>
		/// Writes the current line terminator to the standard output stream.
		/// </summary>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine();

		/// <summary>
		/// Writes the text representation of the specified Boolean value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(bool value);

		/// <summary>
		/// Writes the specified Unicode character, followed by the current line terminator, value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(char value);

		/// <summary>
		/// Writes the specified array of Unicode characters, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="buffer">A Unicode character array. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(char[] buffer);

		/// <summary>
		/// Writes the specified subarray of Unicode characters, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="buffer">An array of Unicode characters. </param><param name="index">The starting position in <paramref name="buffer"/>. </param><param name="count">The number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> or <paramref name="count"/> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="index"/> plus <paramref name="count"/> specify a position that is not within <paramref name="buffer"/>. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(char[] buffer, int index, int count);

		/// <summary>
		/// Writes the text representation of the specified <see cref="T:System.Decimal"/> value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(Decimal value);

		/// <summary>
		/// Writes the text representation of the specified double-precision floating-point value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(double value);

		/// <summary>
		/// Writes the text representation of the specified single-precision floating-point value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(float value);

		/// <summary>
		/// Writes the text representation of the specified 32-bit signed integer value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(int value);

		/// <summary>
		/// Writes the text representation of the specified 32-bit unsigned integer value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(uint value);

		/// <summary>
		/// Writes the text representation of the specified 64-bit signed integer value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(long value);

		/// <summary>
		/// Writes the text representation of the specified 64-bit unsigned integer value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(ulong value);

		/// <summary>
		/// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(object value);

		/// <summary>
		/// Writes the specified string value, followed by the current line terminator, to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void WriteLine(string value);

		/// <summary>
		/// Writes the text representation of the specified object, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param><param name="arg0">An object to write using <paramref name="format"/>. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format"/> is invalid. </exception><filterpriority>1</filterpriority>
		void WriteLine(string format, object arg0);

		/// <summary>
		/// Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format"/>. </param><param name="arg1">The second object to write using <paramref name="format"/>. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format"/> is invalid. </exception><filterpriority>1</filterpriority>
		void WriteLine(string format, object arg0, object arg1);

		/// <summary>
		/// Writes the text representation of the specified objects, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format"/>. </param><param name="arg1">The second object to write using <paramref name="format"/>. </param><param name="arg2">The third object to write using <paramref name="format"/>. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format"/> is invalid. </exception><filterpriority>1</filterpriority>
		void WriteLine(string format, object arg0, object arg1, object arg2);

		/// <summary>
		/// Writes the text representation of the specified array of objects, followed by the current line terminator, to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param><param name="arg">An array of objects to write using <paramref name="format"/>. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format"/> or <paramref name="arg"/> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format"/> is invalid. </exception><filterpriority>1</filterpriority>
		void WriteLine(string format, params object[] arg);

		/// <summary>
		/// Writes the text representation of the specified object to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks). </param><param name="arg0">An object to write using <paramref name="format"/>. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format"/> is invalid. </exception><filterpriority>1</filterpriority>
		void Write(string format, object arg0);

		/// <summary>
		/// Writes the text representation of the specified objects to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format"/>. </param><param name="arg1">The second object to write using <paramref name="format"/>. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format"/> is invalid. </exception><filterpriority>1</filterpriority>
		void Write(string format, object arg0, object arg1);

		/// <summary>
		/// Writes the text representation of the specified objects to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param><param name="arg0">The first object to write using <paramref name="format"/>. </param><param name="arg1">The second object to write using <paramref name="format"/>. </param><param name="arg2">The third object to write using <paramref name="format"/>. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format"/> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format"/> is invalid. </exception><filterpriority>1</filterpriority>
		void Write(string format, object arg0, object arg1, object arg2);

		/// <summary>
		/// Writes the text representation of the specified array of objects to the standard output stream using the specified format information.
		/// </summary>
		/// <param name="format">A composite format string (see Remarks).</param><param name="arg">An array of objects to write using <paramref name="format"/>. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><exception cref="T:System.ArgumentNullException"><paramref name="format"/> or <paramref name="arg"/> is null. </exception><exception cref="T:System.FormatException">The format specification in <paramref name="format"/> is invalid. </exception><filterpriority>1</filterpriority>
		void Write(string format, params object[] arg);

		/// <summary>
		/// Writes the text representation of the specified Boolean value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(bool value);

		/// <summary>
		/// Writes the specified Unicode character value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(char value);

		/// <summary>
		/// Writes the specified array of Unicode characters to the standard output stream.
		/// </summary>
		/// <param name="buffer">A Unicode character array. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(char[] buffer);

		/// <summary>
		/// Writes the specified subarray of Unicode characters to the standard output stream.
		/// </summary>
		/// <param name="buffer">An array of Unicode characters. </param><param name="index">The starting position in <paramref name="buffer"/>. </param><param name="count">The number of characters to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> or <paramref name="count"/> is less than zero. </exception><exception cref="T:System.ArgumentException"><paramref name="index"/> plus <paramref name="count"/> specify a position that is not within <paramref name="buffer"/>. </exception><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(char[] buffer, int index, int count);

		/// <summary>
		/// Writes the text representation of the specified double-precision floating-point value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(double value);

		/// <summary>
		/// Writes the text representation of the specified <see cref="T:System.Decimal"/> value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(Decimal value);

		/// <summary>
		/// Writes the text representation of the specified single-precision floating-point value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(float value);

		/// <summary>
		/// Writes the text representation of the specified 32-bit signed integer value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(int value);

		/// <summary>
		/// Writes the text representation of the specified 32-bit unsigned integer value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(uint value);

		/// <summary>
		/// Writes the text representation of the specified 64-bit signed integer value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(long value);

		/// <summary>
		/// Writes the text representation of the specified 64-bit unsigned integer value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(ulong value);

		/// <summary>
		/// Writes the text representation of the specified object to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write, or null. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(object value);

		/// <summary>
		/// Writes the specified string value to the standard output stream.
		/// </summary>
		/// <param name="value">The value to write. </param><exception cref="T:System.IO.IOException">An I/O error occurred. </exception><filterpriority>1</filterpriority>
		void Write(string value);
	}
}
