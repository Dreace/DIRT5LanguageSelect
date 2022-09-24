using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIRT5LanguageSelect
{
    class LanguageItem
    {

        public readonly string code;
        public readonly string fullName;
        public readonly string language;
        public LanguageItem(string code, string fullName, string language)
        {
            this.code = code;
            this.fullName = fullName;
            this.language = language;
        }
    }
    static class Language
    {
        public static List<LanguageItem> languages = new List<LanguageItem>
            {
                new LanguageItem("eng", "English", "English"),
                new LanguageItem("fre", "French", "Français"),
                new LanguageItem("spa", "Spanish", "Español"),
                new LanguageItem("ger", "German", "Deutsch"),
                new LanguageItem("ita", "Italian", "Italiano"),
                new LanguageItem("bra", "Brazilian Portuguese", "Português do Brasil"),
                new LanguageItem("sim", "Simplified Chinese", "简体中文"),
                new LanguageItem("jap", "Japanese", "日本語"),
                new LanguageItem("kor", "Korean", "한국어"),
            };
    }
}
