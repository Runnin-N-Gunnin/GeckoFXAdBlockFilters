using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GeckoAdBlock
{
    public class FilterLists
    {
        public List<string> FilterListsFilePaths;
        public List<string> FilterListCustom;
        public List<string> FilterList;

        public int NumberOfFilterLists() => FilterListsFilePaths.Count;
        public int NumberOfEntries() => (FilterList.Count + FilterListCustom.Count);
        public void LoadFilterLists() => FilterList = GetFilterListEntries();

        public FilterLists()
        {
            var filterListsPath = $@"{Application.StartupPath}\AdBlock\lists";
            FilterListCustom = new List<string>();
            FilterList = new List<string>();

            FilterListsFilePaths = new List<string>
            {
                $@"{filterListsPath}\easylist-justdomains.txt",
                $@"{filterListsPath}\easyprivacy-justdomains.txt",
                $@"{filterListsPath}\adguard-justdomains.txt"
            };
        }

        public void AddCustomDomainOrKeyword(string customtext)
        {
            if (string.IsNullOrWhiteSpace(customtext)) return;
            FilterListCustom.Add(customtext);
        }

        public void AddCustomDomainsOrKeywords(params string[] textstrings)
        {
            if (textstrings == null) return;
            foreach (var txtStr in textstrings)
                if (!string.IsNullOrWhiteSpace(txtStr)) FilterListCustom.Add(txtStr);
        }

        // Load each file of domains into a temporary list, return that list
        private List<string> GetFilterListEntries()
        {
            List<string> tempFltList = new List<string>();

            foreach (var file in FilterListsFilePaths)
            {
                if (File.Exists(file)) tempFltList.AddRange(File.ReadAllLines(file));
            }
            return tempFltList;
        }
    }
}
