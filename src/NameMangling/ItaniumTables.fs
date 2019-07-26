(*
  B2R2 - the Next-Generation Reversing Platform

  Author: Mehdi Aghakishiyev <agakisiyev.mehdi@gmail.com>
          Sang Kil Cha <sangkilc@kaist.ac.kr>

  Copyright (c) SoftSec Lab. @ KAIST, since 2016

  Permission is hereby granted, free of charge, to any person obtaining a copy
  of this software and associated documentation files (the "Software"), to deal
  in the Software without restriction, including without limitation the rights
  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
  copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all
  copies or substantial portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
  SOFTWARE.
*)

module B2R2.NameMangling.ItaniumTables

let getTypeS = function
  | 'v' -> "void"
  | 'w' -> "wchar_t"
  | 'b' -> "bool"
  | 'c' -> "char"
  | 'a' -> "signed char"
  | 'h' -> "unsigned char"
  | 's' -> "short"
  | 't' -> "unsigned short"
  | 'i' -> "int"
  | 'j' -> "unsigned int"
  | 'l' -> "long"
  | 'm' -> "unsigned long"
  | 'x' -> "long long"
  | 'y' -> "unsigned long long"
  | 'n' -> "__int128"
  | 'o' -> "unsigned __int128"
  | 'f' -> "float"
  | 'd' -> "double"
  | 'e' -> "long double"
  | 'g' -> "float"
  | 'z' -> "ellipsis"
  | _ -> ""
