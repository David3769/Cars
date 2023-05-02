using TMPro;
using UnityEngine;
using UnityEngine.Audio;

namespace Cars.UI
{
    public class GameSettings : MonoBehaviour
    {
        [SerializeField] private AudioMixerGroup _master;
        [SerializeField] private TMP_Text _textButtonMusic;

        private static bool _isMusic = true;

        private void OnEnable()
        {
            if (_isMusic)
                SetOnMusic();
            else
                SetOffMusic();
        }

        public void OnMusic()
        {
            if (_isMusic)
                SetOffMusic();
            else
                SetOnMusic();
        }

        private void SetOnMusic()
        {
            _master.audioMixer.SetFloat("Music", 0);
            _textButtonMusic.text = "вкл";
            _isMusic = true;
        }

        private void SetOffMusic()
        {
            _master.audioMixer.SetFloat("Music", -80);
            _textButtonMusic.text = "выкл";
            _isMusic = false;
        }
    }
}
