using System;
using System.CodeDom;
using System.Configuration;
using HarmonyLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityModManagerNet;

namespace MIRAYPerfectOnly.MainPatch {
    [HarmonyPatch(typeof(ScoreBoard), "write")]

    internal static class PerfectOnly {
        private static void Prefix(PauseUI __instance, JudgeType type) {
            if (type == JudgeType.miss) SceneManager.LoadScene("what");
        }
    }
}