using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace Euaungkul.GameDev3.Chapter1
{
    [CreateAssetMenu(menuName = "GameDev3/Chapter11/SoundSettingsPreset", fileName = "SoundSettingsPreset")]
    public class SoundSettings : ScriptableObject
    {
        // Start is called before the first frame update
        public AudioMixer AudioMixer;
        [Header("MasterVolume")] public string MasterVolumeName = "MasterVolume";
        [Range(-80, 20)] public float MasterVolume;
        [Header("MusicVolume")] public string MusicVolumeName = "MusicVolume";
        [Range(-80, 20)] public float MusicVolume;
        [Header("MasterSFXVolume")] public string MasterSFXVolumeName = "MasterSFXVolume";
        [Range(-80, 20)] public float MasterSFXVolume;
        [Header("SFXVolume")] public string SFXVolumeName = "SFXVolume";
        [Range(-80, 20)] public float SFXVolume;
        [Header("UIVolume")] public string UIVolumeName = "UIVolume";
        [Range(-80, 20)] public float UIVolume;
    }

}
