﻿using UnityEngine;

namespace MomomaAssets
{

    public class EdgeObject : ScriptableObject
    {
        [SerializeField]
        string m_Guid = "";
        public string guid => m_Guid;

        [SerializeField]
        string m_InputGuid = "";
        public string inputGuid => m_InputGuid;

        [SerializeField]
        string m_OutputGuid = "";
        public string outputGuid => m_OutputGuid;

        void Awake()
        {
            hideFlags = HideFlags.HideAndDontSave;
        }
    }

}
