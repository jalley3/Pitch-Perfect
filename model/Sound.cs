using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PitchPerfect.model
{
	
   public static class Sounds
    {
		#region fields
        //path to the User.json data
        public static readonly string SoundPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../data/sound.json");
        //transform Sound.json data into List of User objects
        //json object to c# User object uses: default (empty constructor) and property setters
        private static List<Sound> _soundList = JsonConvert.DeserializeObject<List<Sound>>(File.ReadAllText(SoundPath)); 
        #endregion
		
		#region properties (getters/setters)
        public static List<Sound> SoundList { get { return _soundList; } set { _soundList = value; } }
        #endregion
		
		#region constructor
		#endregion
	#region methods
        public static Sound GetSound(double freq)
        {
            Sound note = _soundList.SingleOrDefault(x => x.Freq == freq);
            return note;
        }
		
        public static Sound GetSound(string name)
        {
            Sound note = _soundList.SingleOrDefault(x => x.Name == name);
            return note;
        }

        public static bool AddSound(Sound note)
        {
            if (!_soundList.Exists(x => x.Name == note.Name))
            {
                _soundList.Add(note);
                return true;
            }
            return false;
        }

        public static int GetSoundCount()
        {
            return _soundList.Count;
        }

        public static void Save()
        {
            File.WriteAllText(SoundPath, JsonConvert.SerializeObject(_soundList, Formatting.Indented));
        }
		
		public static void EraseAllSounds()
        {
            _soundList.Clear();
            File.WriteAllText(SoundPath, JsonConvert.SerializeObject(_soundList, Formatting.Indented));
        }
		
		#endregion
    }
    public class Sound
    {

        #region fields
        private string _name;
        private int _freq;
        private int _duration = 3200;
        #endregion

        #region properties (getters/setters)
        public string Name { get { return _name; } set { _name = value; } }
        public int Freq { get { return _freq; } set { _freq = value; } }
        #endregion


        #region constructors
        public Sound() { }

        public Sound(string name, int freq)
        {
            _name = name;
            _freq = freq;
            _duration = 1600;
        }
        #endregion

        #region methods

        public void PlaySound()
        {
            Console.Beep((int)_freq, _duration);
        }
        #endregion
    }
    
}