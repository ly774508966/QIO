using System;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

namespace QFramework.Editor
{
    public class AppConfigEditor
    {
        [MenuItem("Assets/AppConfig/Build AppConfig")]
        public static void BuildAppConfig()
        {

			PathConfig data = null;
            string folderPath = EditorUtils.GetSelectedDirAssetsPath();
            string spriteDataPath = folderPath + "Path.asset";

			data = AssetDatabase.LoadAssetAtPath<PathConfig>(spriteDataPath);
            if (data == null)
            {
				data = ScriptableObject.CreateInstance<PathConfig>();
                AssetDatabase.CreateAsset(data, spriteDataPath);
            }

            EditorUtility.SetDirty(data);
            AssetDatabase.SaveAssets();
        }
    }
}
