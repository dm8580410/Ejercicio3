using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Ejercicio3.Models
{
    public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int id  { get; set;}

        [MaxLength(100)]
        public string nombres { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set; }

        [MaxLength(100)]
        public string edad { get; set; }

        [MaxLength(300)]
        public String correo { get; set; }
        public string direccion { get; set; }
        public Byte[] foto { get; set; }

    }
}
