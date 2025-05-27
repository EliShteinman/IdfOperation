using Newtonsoft.Json;

namespace IdfOperation.Utils.NameGenerator
{
    public class RandomName
    {
        private readonly Random rand = new();
        private readonly List<string> Male;
        private readonly List<string> Female;
        private readonly List<string> Last;

        private class NameList
        {
            public string[] boys { get; set; }
            public string[] girls { get; set; }
            public string[] last { get; set; }
        }

        public RandomName()
        {
            // טוען את הקובץ ישירות מהתיקייה שלך בפרויקט
            string path = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "NameGenerator", "names.json");
            path = Path.GetFullPath(path);
            var serializer = new JsonSerializer();

            NameList names;
            using (StreamReader reader = new(path))
            using (JsonReader jreader = new JsonTextReader(reader))
            {
                names = serializer.Deserialize<NameList>(jreader);
            }

            Male = new List<string>(names.boys);
            Female = new List<string>(names.girls);
            Last = new List<string>(names.last);
        }

        public string GenerateName(bool male = true, int middleCount = 0, bool useInitials = false)
        {
            string first = male ? GetRandom(Male) : GetRandom(Female);
            string last = GetRandom(Last);

            var middles = new List<string>();
            for (int i = 0; i < middleCount; i++)
            {
                if (useInitials)
                    middles.Add(((char)('A' + rand.Next(0, 26))) + ".");
                else
                    middles.Add(male ? GetRandom(Male) : GetRandom(Female));
            }

            return $"{first} {string.Join(" ", middles)} {last}".Trim();
        }

        private string GetRandom(List<string> list) => list[rand.Next(list.Count)];
    }
}