// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Security.Cryptography.X509Certificates;
// using System.Text;
// using System.Threading.Tasks;
// using SQLite;

// namespace Desktop_089667.Data
// {
//     internal class Databaseclass
//     {
//         SQLiteAsyncConnection Database;
//         const SQLite.SQLiteOpenFlags Flags =
//             SQLite.SQLiteOpenFlags.ReadWrite |
//             SQLite.SQLiteOpenFlags.Create |
//             SQLite.SQLiteOpenFlags.SharedCache;

//         public async Task Init()
//         {
//             if (Database is not null)
//             {
//                 return;
//             }
//             string DatabasePath = Path.Combine(FileSystem.AppDataDirectory, "Desktop_089667.db");
//             Database = new SQLiteAsyncConnection(DatabasePath, Flags);
//             var result = await Database.CreateTableAsync<Vragen>();
//             var result2 = await Database.CreateTableAsync<Scores>();
//             if (result == CreateTableResult.Created)
//             {
//                 Vragen vraag1 = new Vragen()
//                 {
//                     Vraag = "Wie is de hoofdrolspeler in de 'God of War' games?",
//                     AntwoordA = "Zeus",
//                     AntwoordB = "Kratos",
//                     AntwoordC = "Ares",
//                     GoedeAntwoord = "B"
//                 };
//                 await SaveVraagAsync(vraag1);
//                 Vragen vraag2 = new Vragen()
//                 {
//                     Vraag = "In welke mythologie is de wereld van 'God of War' voornamelijk gebaseerd?",
//                     AntwoordA = "Griekse mythologie",
//                     AntwoordB = "Noorse mythologie",
//                     AntwoordC = "Egyptische mythologie",
//                     GoedeAntwoord = "B"
//                 };
//                 await SaveVraagAsync(vraag2);
//                 Vragen vraag3 = new Vragen()
//                 {
//                     Vraag = "Welk wapen gebruikt Kratos als zijn belangrijkste hulpmiddel in gevechten?",
//                     AntwoordA = "Zwaard van de Oorlog",
//                     AntwoordB = "Bliksemschicht van Zeus",
//                     AntwoordC = "Leviathan Axe",
//                     GoedeAntwoord = "C"
//                 };
//                 await SaveVraagAsync(vraag3);
//                 Vragen vraag4 = new Vragen()
//                 {
//                     Vraag = "Hoe heet Kratos' zoon in de nieuwere 'God of War' game?",
//                     AntwoordA = "Atreus",
//                     AntwoordB = "Deimos",
//                     AntwoordC = "Calliope",
//                     GoedeAntwoord = "A"
//                 };
//                 await SaveVraagAsync(vraag4);
//                 Vragen vraag5 = new Vragen()
//                 {
//                     Vraag = "Welke Griekse god wil Kratos wreken in het eerste deel van de 'God of War' serie?",
//                     AntwoordA = "Hera",
//                     AntwoordB = "Poseidon",
//                     AntwoordC = "Ares",
//                     GoedeAntwoord = "C"
//                 };
//                 await SaveVraagAsync(vraag5);
//             }
//         }
//         public async Task<List<Vragen>> GetVragenAsync()
//         {
//             await Init();
//             return await Database.Table<Vragen>().ToListAsync();
//         }
//         public async Task<Vragen> GetVragenAsync(int id)
//         {
//             await Init();
//             return await Database.Table<Vragen>().Where(p => p.ID == id).FirstAsync();
//         }
//         public async Task SaveVraagAsync(Vragen vragen)
//         {
//             await Init();
//             if(vragen.Id != 0)
//             {
//                 await Database.UpdateAsync(vragen);
//             }
//             else
//             {
//                 await Database.InsertAsync(vragen);
//             }
//         }

//         public async Task DeleteVragenAsync(Vragen vragen)
//         {
//             await Init();
//             await Database.DeleteAsync(vragen);
//         }

//         public async Task DeleteVragenAllAsync()
//         {
//             await Init();
//             await Database.DeleteAllAsync<Vragen>();
//         }
//     }
// }
