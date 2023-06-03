#if UNITY_EDITOR
using System;
using System.Net;
using System.IO;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Networking;
using UnityEditor;

using PlayFab;
using PlayFab.ClientModels;

namespace AdvancedPlayFab
{
    [CustomEditor(typeof(AdvancedPlayfab))]
    public class AdvancedPlayfabGUI : Editor
    {
        private Texture2D logo;

        public override void OnInspectorGUI()
        {
            if (logo == null)
                logo = Resources.Load<Texture2D>("AdvancedPlayfab/Images/AdvancedPlayfabLogoLong");
            GUILayout.Label(new GUIContent() { image = logo });

            base.OnInspectorGUI();
            GUILayout.Space(10);

            AdvancedPlayfab advancedPlayfab = (AdvancedPlayfab)target;

            if (EditorApplication.isPlaying && PlayFabClientAPI.IsClientLoggedIn() && advancedPlayfab != null)
            {
                GUILayout.Label("PLAYER DATA", EditorStyles.boldLabel);
                GUILayout.Label($"Loaded Catalogs: {advancedPlayfab.Catalogs.Count}");
                GUILayout.Label($"Player Name: {advancedPlayfab.NamingPC.NameVar}");
                GUILayout.Label($"Player ID: {advancedPlayfab.PlayFabID}");
                GUILayout.Label($"Player Cash: {advancedPlayfab.CurrencyAmount.ToString()}");
            }
            else if (EditorApplication.isPlaying && advancedPlayfab != null)
            {
                GUILayout.Label("Logging in...");
            }
            EditorGUILayout.Separator();
            if (GUILayout.Button("Need Help?", GUILayout.Width(80)))
            {
            Application.OpenURL("https://discord.gg/e6QQBcdPPT");
            }
        }
    }
}
#endif