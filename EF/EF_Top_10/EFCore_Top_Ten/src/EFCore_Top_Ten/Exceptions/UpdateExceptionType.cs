﻿#region copyright
// // Copyright Information
// // ==============================
// // EFCore_Top_Ten - UpdateExceptionType.cs
// // All samples copyright Philip Japikse 
// // http://www.skimedic.com 2016/08/10
// // See License.txt for more information
// // ==============================
#endregion
namespace EFCore_Top_Ten.Exceptions
{
	public enum UpdateExceptionType
	{
		Concurrency,
		PrimaryKey,
		UniqueIndex,
		Unknown,
	    MaxRetries
	}
}