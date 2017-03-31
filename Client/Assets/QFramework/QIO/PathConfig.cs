using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace QFramework {

	public enum PATH_ROOT {
		ApplicationPersistentDataPath,
		ApplicationDataPath,
		ApplicationStreamingAssetsPath
	}

	[System.Serializable]
	public class PathItem {
		[Header("描述")]
		[SerializeField] string m_Description;
		[SerializeField] PATH_ROOT m_Root;
		[SerializeField] string m_Name;
		[SerializeField] string m_Path;

		public string Path {
			get {
				switch (m_Root) {
				case PATH_ROOT.ApplicationDataPath:
					return Application.dataPath + "/" + m_Path;
				case PATH_ROOT.ApplicationPersistentDataPath:
					return PATH_ROOT.ApplicationPersistentDataPath + "/" + m_Path;
				case PATH_ROOT.ApplicationStreamingAssetsPath:
					return PATH_ROOT.ApplicationStreamingAssetsPath + "/" + m_Path;
				}
				return m_Path;
			}
		}

	}
		
	/// <summary>
	/// Path配置
	/// </summary>
	public class PathConfig : ScriptableObject {
		[SerializeField]  string Description;
		[SerializeField]  List<PathItem> m_PathList;

		public List<PathItem> List {
			get {
				return m_PathList;
			}
		}
	}
}
