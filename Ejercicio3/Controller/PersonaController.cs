using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Ejercicio3.Models;
using System.Threading.Tasks;

namespace Ejercicio3.Controller
{
   public class PersonaController
    {
            readonly SQLiteAsyncConnection connection;


            // Constructor de clase
            public PersonaController (string dbpath)
            {
                // Crear una nueva conexion hacia la base de datos
                connection = new SQLiteAsyncConnection(dbpath);

                // Crear los objetos de base de datos que vamos a ocupar
                connection.CreateTableAsync<Personas>().Wait();
            }


            // Creacion de las operaciones CRUD - DB
            // Create 

            public Task<int> SavePerso(Personas Personas)
            {
                if (Personas.id != 0)
                    return connection.UpdateAsync(Personas);
                else
                    return connection.InsertAsync(Personas);
            }

            // Read
            public Task<List<Personas>> GetListpers()
            {
                return connection.Table<Personas>().ToListAsync();
            }

            public Task<Personas> Getperso(int pid)
            {
                return connection.Table<Personas>()
                    .Where(i => i.id == pid)
                    .FirstOrDefaultAsync();
            }

            // Delete
            public Task<int> Deleteperso(Personas Personas)
            {
                return connection.DeleteAsync(Personas);
            }
        }
    }
