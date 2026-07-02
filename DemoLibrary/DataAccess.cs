using DemoLibrary.Models;

namespace DemoLibrary {
    public static class DataAccess {

        //private static readonly string personTextFile =
        //    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PersonText.txt");
        static string basePath = AppDomain.CurrentDomain.BaseDirectory;
        static string parentPath = Directory.GetParent(basePath).Parent.Parent.Parent.FullName;
        static string path = Path.Combine(parentPath,"PersonText.txt");

        public static async Task AddNewPersonAsync(PersonModel person) {
            List<string> lines = new List<string>();
            List<PersonModel> people = await GetAllPeopleAsync();
            people.Add(person);

            foreach (PersonModel p in people) {
                lines.Add($"{p.FirstName},{p.LastName}");
            }

            await File.WriteAllLinesAsync(path, lines);
        }

        public static async Task<List<PersonModel>> GetAllPeopleAsync() {
            List<PersonModel> output = new List<PersonModel>();

            string[] content = await File.ReadAllLinesAsync(path);

            if (content.Length > 0) {
                foreach (string line in content) {
                    string[] dats = line.Split(',');
                    output.Add(new PersonModel { FirstName = dats[0], LastName = dats[1] });
                }
            }
            return output;
        }
    }
}

