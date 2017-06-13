using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Ignore_Editor {
	class FileFolderHolder {
		public string m_Filename;
		public string m_RelativePath;
		public string m_Path;

		public bool m_IsExcluded;

		public bool m_IsFile;

		public TreeNode m_Node;
		public FileFolderHolder m_Parent;

		public List<FileFolderHolder> m_Children;

		public List<GitIgnoreLine> m_Effects;

		public GitIgnoreLine getLastLineOfEffect() {
			if(m_Effects == null) {
				return null;
			}

			return m_Effects[m_Effects.Count - 1];

		}
	}
}
