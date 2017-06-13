using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Ignore_Editor {

	/// <summary>
	/// this class holds information about each line in the .gitignore
	/// </summary>
	class GitIgnoreLine {

		public GitIgnoreLine(string a_Base, int a_Line) {
			m_LineIndex = a_Line;
			m_BaseLine = a_Base;
			m_Line = a_Base.Replace('\\', '/');

			bool startsWithHash = false;
			bool onlySpaces = true;
			bool startsWithAllow = false;//starts with !

			bool removeStart = false;

			//char lastChar = ' ';

			char currentChar = ' ';
			int index = 0;
			for (; index < m_Line.Length; index++) {
				currentChar = m_Line[index];

				if (currentChar == '\n') {
					break;
				}

				//if there has only been spaces since the start
				if (onlySpaces) {
					if (currentChar == '!') {
						removeStart = true;
						startsWithAllow = true;
						break;
					}

					if (currentChar == '#') {
						startsWithHash = true;
						break;
					}

					if (currentChar == '/') {
						removeStart = true;
						break;
					}
				}

				if (onlySpaces) {
					if (currentChar != ' ') {
						onlySpaces = false;
						break;
					}
				}

			}

			if (currentChar != ' ') {
				onlySpaces = false;
			}

			if (onlySpaces) {
				m_Type = LineType.Empty;
			} else if (startsWithHash) {
				m_Type = LineType.Comment;
			} else if (startsWithAllow) {
				m_Type = LineType.Allow;
			} else {
				m_Type = LineType.Ignore;
			}

			if (removeStart) {
				m_Line = m_Line.Remove(0, index + 1);
			}

		}

		/// <summary>
		/// the line as it appears in the .gitignore
		/// </summary>
		public string m_BaseLine;
		/// <summary>
		/// modified version of the baseLine, removes some information
		/// </summary>
		public string m_Line;

		/// <summary>
		/// index of this line in the gitIgnore file
		/// </summary>
		public int m_LineIndex = 0;

		/// <summary>
		/// types of line each line can be
		/// </summary>
		public enum LineType {
			Ignore,
			Allow,
			Comment,
			Empty
		}

		/// <summary>
		/// which type is this line
		/// </summary>
		public LineType m_Type;
	}
}
