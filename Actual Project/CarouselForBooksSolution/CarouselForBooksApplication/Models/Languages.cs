using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarouselForBooksApplication.Models
{
    public class Languages
    {
        public List<SelectListItem> LanguageList { get; set; }
        public Languages()
        {
            LanguageList = new List<SelectListItem>
            {
                new SelectListItem {Text = "Afrikaans", Value = "Afrikaans"},
                new SelectListItem {Text = "Albanian", Value = "Albanian"},
                new SelectListItem {Text = "Arabic", Value = "Arabic"},
                new SelectListItem {Text = "Armenian", Value = "Armenian"},
                new SelectListItem {Text = "Basque", Value = "Basque"},
                new SelectListItem {Text = "Bengali", Value = "Bengali"},
                new SelectListItem {Text = "Bulgarian", Value = "Bulgarian"},
                new SelectListItem {Text = "Catalan", Value = "Catalan"},
                new SelectListItem {Text = "Cambodian", Value = "Cambodian"},
                new SelectListItem {Text = "Chinese (Mandarin)", Value = "Chinese (Mandarin)"},
                new SelectListItem {Text = "Croatian", Value = "Croatian"},
                new SelectListItem {Text = "Czech", Value = "Czech"},
                new SelectListItem {Text = "Danish", Value = "Danish"},
                new SelectListItem {Text = "Dutch", Value = "Dutch"},
                new SelectListItem {Text = "English", Value = "English"},
                new SelectListItem {Text = "Estonian", Value = "Estonian"},
                new SelectListItem {Text = "Fiji", Value = "Fiji"},
                new SelectListItem {Text = "Finnish", Value = "Finnish"},
                new SelectListItem {Text = "French", Value = "French"},
                new SelectListItem {Text = "Georgian", Value = "Georgian"},
                new SelectListItem {Text = "German", Value = "German"},
                new SelectListItem {Text = "Greek", Value = "Greek"},
                new SelectListItem {Text = "Gujarati", Value = "Gujarati"},
                new SelectListItem {Text = "Hebrew", Value = "Hebrew"},
                new SelectListItem {Text = "Hindi", Value = "Hindi"},
                new SelectListItem {Text = "Hungarian", Value = "Hungarian"},
                new SelectListItem {Text = "Icelandic", Value = "Icelandic"},
                new SelectListItem {Text = "Indonesian", Value = "Indonesian"},
                new SelectListItem {Text = "Irish", Value = "Irish"},
                new SelectListItem {Text = "Italian", Value = "Italian"},
                new SelectListItem {Text = "Japanese", Value = "Japanese"},
                new SelectListItem {Text = "Javanese", Value = "Javanese"},
                new SelectListItem {Text = "Korean", Value = "Korean"},
                new SelectListItem {Text = "Latin", Value = "Latin"},
                new SelectListItem {Text = "Latvian", Value = "Latvian"},
                new SelectListItem {Text = "Lithuanian", Value = "Lithuanian"},
                new SelectListItem {Text = "Macedonian", Value = "Macedonian"},
                new SelectListItem {Text = "Malay", Value = "Malay"},
                new SelectListItem {Text = "Malayalam", Value = "Malayalam"},
                new SelectListItem {Text = "Maltese", Value = "Maltese"},
                new SelectListItem {Text = "Maori", Value = "Maori"},
                new SelectListItem {Text = "Marathi", Value = "Marathi"},
                new SelectListItem {Text = "Mongolian", Value = "Mongolian"},
                new SelectListItem {Text = "Nepali", Value = "Nepali"},
                new SelectListItem {Text = "Norwegian", Value = "Norwegian"},
                new SelectListItem {Text = "Persian", Value = "Persian"},
                new SelectListItem {Text = "Polish", Value = "Polish"},
                new SelectListItem {Text = "Portuguese", Value = "Portuguese"},
                new SelectListItem {Text = "Punjabi", Value = "Punjabi"},
                new SelectListItem {Text = "Quechua", Value = "Quechua"},
                new SelectListItem {Text = "Romanian", Value = "Romanian"},
                new SelectListItem {Text = "Russian", Value = "Russian"},
                new SelectListItem {Text = "Samoan", Value = "Samoan"},
                new SelectListItem {Text = "Serbian", Value = "Serbian"},
                new SelectListItem {Text = "Slovak", Value = "Slovak"},
                new SelectListItem {Text = "Slovenian", Value = "Slovenian"},
                new SelectListItem {Text = "Spanish", Value = "Spanish"},
                new SelectListItem {Text = "Swahili", Value = "Swahili"},
                new SelectListItem {Text = "Swedish ", Value = "Swedish "},
                new SelectListItem {Text = "Tamil", Value = "Tamil"},
                new SelectListItem {Text = "Tatar", Value = "Tatar"},
                new SelectListItem {Text = "Telugu", Value = "Telugu"},
                new SelectListItem {Text = "Thai", Value = "Thai"},
                new SelectListItem {Text = "Tibetan", Value = "Tibetan"},
                new SelectListItem {Text = "Tonga", Value = "Tonga"},
                new SelectListItem {Text = "Turkish", Value = "Turkish"},
                new SelectListItem {Text = "Ukrainian", Value = "Ukrainian"},
                new SelectListItem {Text = "Urdu", Value = "Urdu"},
                new SelectListItem {Text = "Uzbek", Value = "Uzbek"},
                new SelectListItem {Text = "Vietnamese", Value = "Vietnamese"},
                new SelectListItem {Text = "Welsh", Value = "Welsh"},
                new SelectListItem {Text = "Xhosa", Value = "Xhosa"}
            };
        }
    }
}
