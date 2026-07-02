using DemoLibrary.Models;

namespace DemoLibrary {
    public static class DataAccess {

        //private static readonly string personTextFile =
        //    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PersonText.txt");
        static string basePath = AppDomain.CurrentDomain.BaseDirectory;
        static string parentPath = Directory.GetParent(basePath).Parent.Parent.Parent.FullName;
        static string path = Path.Combine(parentPath,"PersonText.txt");

        public static async Task AddNewPersonAsync(PersonModel person) {

            List<PersonModel> people = await GetAllPeopleAsync();

            AddPersonToPeopleList(people, person);

            List<string> lines = ConvertModelsToCSV(people);

            await File.WriteAllLinesAsync(path, lines);
        }

        public static void AddPersonToPeopleList(List<PersonModel> people, PersonModel person) {

            if(string.IsNullOrWhiteSpace(person.FirstName)) {
                throw new ArgumentException("You passed in an invalid parameter","FirstName");
            }

            if (string.IsNullOrWhiteSpace(person.LastName)) {
                throw new ArgumentException("You passed in an invalid parameter", "LastName");
            }

            people.Add(person);
        }

        public static List<string> ConvertModelsToCSV(List<PersonModel> people) {
            List<string> output = new List<string>();
            foreach (PersonModel p in people) {
                output.Add($"{p.FirstName},{p.LastName}");
            }
            return output;
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

