//
// JSScanner.cs:
//
// Author:
//	Cesar Lopez Nataren (cesar@ciencias.unam.mx)
//
// (C) 2003, Cesar Lopez Nataren
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.IO;

namespace Microsoft.JScript {

	public sealed class JSScanner {

		public JSScanner ()
		{}

		public JSScanner (Context sourceContext)
		{
			throw new NotImplementedException ();
		}


		public void SetAuthoringMode (bool mode)
		{
			throw new NotImplementedException ();
		}


		public void SetSource (Context sourceContext)
		{
			throw new NotImplementedException ();
		}


		public void GetNextToken ()
		{
			throw new NotImplementedException ();
		}


		public int GetCurrentPosition (bool absolute)
		{
			throw new NotImplementedException ();
		}


		public int GetCurrentLine ()
		{
			throw new NotImplementedException ();
		}


		public int GetStartLinePosition ()
		{
			throw new NotImplementedException ();
		}


		public string GetStringLiteral ()
		{
			throw new NotImplementedException ();
		}


		public string GetSourceCode ()
		{
			throw new NotImplementedException ();
		}


		public bool GetEndOfLine ()
		{
			throw new NotImplementedException ();
		}


		public int SkipMultiLineComment ()
		{
			throw new NotImplementedException ();
		}


		public static bool IsOperator (JSToken token)
		{
			throw new NotImplementedException ();
		}


		public static bool IsKeyword (JSToken token)
		{
				throw new NotImplementedException ();
		}
	}
}
